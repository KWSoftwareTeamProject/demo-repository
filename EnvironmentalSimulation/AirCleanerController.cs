using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Net.NetworkInformation;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace EnvironmentalSimulation
{
    public partial class AirCleanerController : Form
    {
        private const int INTERVAL = 15;    // 타이머 설정 간격

        private Aircleaner aircleaner;

        private bool nightOn;
        private bool timerOn;
        private bool autoOn;

        private int timer;
        private int i;

        public AirCleanerController(Aircleaner aircleaner)
        {
            InitializeComponent();
            this.aircleaner = aircleaner;
            timer1.Start();

            nightOn = false;
            timerOn = false;
            autoOn = false;

            timer = 0;
            i = 0;
        }

        private void AirCleanerController_Shown(object sender, EventArgs e)
        {
            Graphics g = this.CreateGraphics();
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

            nightOn = false;
        }

        private void btnNight_Click(object sender, EventArgs e)
        {
            if (nightOn)
            {
                ChangeMode(0);
                aircleaner.PowerOff();
                nightOn = false;
            }
            else
            {
                ChangeMode(4);
                aircleaner.PowerOn();
                nightOn = true;
                btnNight.BackColor = Color.Red;
            }
        }

        private void btnTimer_Click(object sender, EventArgs e)
        {
            aircleaner.PowerOn();
            timerOn = true;
            timer += INTERVAL;
        }

        private void btnAuto_Click(object sender, EventArgs e)
        {
            if (autoOn)
            {
                aircleaner.PowerOff();
                autoOn = false;
                ChangeMode(0);
            }
            else
            {
                aircleaner.PowerOn();
                autoOn = true;
                nightOn = false;
            }
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

            if (timerOn) Timer();
            if (autoOn) Auto();
        }

        private void Timer()
        {
            if (i == 10)
            {
                timer--;
                i = 0;
            }
            i++;

            if (timer == 0)
            {
                nightOn = false;
                timerOn = false;
                autoOn = false;
                ChangeMode(0);
                aircleaner.PowerOff();
            }

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

        private void Auto()
        {
            int fineDust = aircleaner.GetFineDust();
            if (fineDust > 35)
            {
                ChangeMode(3);
            }
            else if (fineDust > 15)
            {
                ChangeMode(2);
            }
            else
            {
                ChangeMode(4);
            }
        }

        private void ChangeMode(int modeIndex)
        {
            rdoLow.Checked = false;
            rdoMid.Checked = false;
            rdoHigh.Checked = false;

            switch(modeIndex)
            {
                case 1:
                    rdoLow.Checked = true;
                    aircleaner.SetMode(1);
                    break;
                case 2:
                    rdoMid.Checked = true;
                    aircleaner.SetMode(2);
                    break;
                case 3:
                    rdoHigh.Checked = true;
                    aircleaner.SetMode(3);
                    break;
                case 4:
                    aircleaner.SetMode(4);
                    break;
            }

            aircleaner.SetMode(modeIndex);
        }

        private void AirCleanerController_FormClosing(object sender, FormClosingEventArgs e)
        {
            timer1.Stop();
        }

        private void AirCleanerController_Load(object sender, EventArgs e)
        {

        }
    }
}
