using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Net.NetworkInformation;
using System.Runtime.InteropServices;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace EnvironmentalSimulation
{
    public partial class AirCleanerController : Form
    {
        private const int INTERVAL = 15;    // 타이머 설정 간격

        private Aircleaner aircleaner;

        public AirCleanerController(Aircleaner aircleaner)
        {
            InitializeComponent();

            this.aircleaner = aircleaner;
            Paint += new PaintEventHandler(PaintBackgroundHandler);

            timer1.Start();
        }

        private void PaintBackgroundHandler(object sender, EventArgs e)
        {
            Graphics g = CreateGraphics();
            SolidBrush brush = new SolidBrush(Color.DarkGray);

            g.FillEllipse(brush, 10, 10, 280, 280);

            rdoLow.BackColor = Color.DarkGray;
            rdoMid.BackColor = Color.DarkGray;
            rdoHigh.BackColor = Color.DarkGray;
        }

        private void btnPower_Click(object sender, EventArgs e)
        {
            aircleaner.PowerOn();
            if (rdoLow.Checked)
            {
                ChangeMode(2);
            }
            else if (rdoMid.Checked)
            {
                ChangeMode(3);
            }
            else if (rdoHigh.Checked)
            {
                ChangeMode(0);
                aircleaner.PowerOff();
            }
            else
            {
                ChangeMode(1);
            }

            aircleaner.NightOff();
        }

        private void btnNight_Click(object sender, EventArgs e)
        {
            aircleaner.NightOnOff();
        }

        private void btnTimer_Click(object sender, EventArgs e)
        {
            aircleaner.TimerOn(INTERVAL);
        }

        private void btnAuto_Click(object sender, EventArgs e)
        {
            aircleaner.AutoOnOff();
        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            int fineDust = aircleaner.GetFineDust();
            if (fineDust > 75)
                lblPMSensor.BackColor = Color.Black;
            else if (fineDust > 35)
                lblPMSensor.BackColor = Color.Red;
            else if (fineDust > 15)
                lblPMSensor.BackColor = Color.Green;
            else
                lblPMSensor.BackColor = Color.Blue;

            ChangeRadioButtons(aircleaner.GetMode());
            ChangeTimer(aircleaner.GetTimer());
        }
        
        private void ChangeMode(int modeIndex)
        {
            ChangeRadioButtons(modeIndex);
            aircleaner.SetMode(modeIndex);
        }

        private void ChangeRadioButtons(int modeIndex)
        {
            rdoLow.Checked = false;
            rdoMid.Checked = false;
            rdoHigh.Checked = false;

            switch (modeIndex)
            {
                case 1:
                    rdoLow.Checked = true;
                    break;
                case 2:
                    rdoMid.Checked = true;
                    break;
                case 3:
                    rdoHigh.Checked = true;
                    break;
            }
        }

        private void ChangeTimer(int timer)
        {
            StringBuilder stringBuilder = new StringBuilder();
            int hour = timer / 60;
            int minute = timer % 60;

            if (hour < 10)
                stringBuilder.Append("0");
            stringBuilder.Append(hour);
            stringBuilder.Append(":");
            if (minute < 10)
                stringBuilder.Append("0");
            stringBuilder.Append(minute);

            btnTimer.Text = stringBuilder.ToString();
        }

        private void AirCleanerController_FormClosing(object sender, FormClosingEventArgs e)
        {
            timer1.Stop();
        }
    }
}
