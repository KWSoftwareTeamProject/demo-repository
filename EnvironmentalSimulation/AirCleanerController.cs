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
        private int timer;
        private int curDust;
        private bool auto;

        public AirCleanerController()
        {
            InitializeComponent();
        }

        private void AirCleaner_Shown(object sender, EventArgs e)
        {
            Graphics g = this.CreateGraphics();
            SolidBrush brush = new SolidBrush(Color.DarkGray);

            g.FillEllipse(brush, 10, 10, 280, 280);

            rdoLow.BackColor = Color.DarkGray;
            rdoMid.BackColor = Color.DarkGray;
            rdoHigh.BackColor = Color.DarkGray;            
        }

        private void PowerOff()
        {

        }

        private void PowerOn(RadioButton rdoBtn)
        {

        }

        private void btnPower_Click(object sender, EventArgs e)
        {
            RadioButton checkedRdoBtn = Change();

            if (checkedRdoBtn == null) PowerOff();
            else PowerOn(checkedRdoBtn);


        }

        private RadioButton Change()
        {
            if (rdoLow.Checked)
            {
                rdoMid.Checked = true;
                return rdoMid;
            }
            else if (rdoMid.Checked)
            {
                rdoHigh.Checked = true;
                return rdoHigh;
            }
            else if (rdoHigh.Checked)
            {
                rdoHigh.Checked = false;
                return null;
            }
            else
            {
                rdoLow.Checked = true;
                return rdoLow;
            }
        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            Generate_dusts();
        }

        private void Generate_dusts()
        {
            Random rand = new Random();
            Graphics g = this.CreateGraphics();

            for (int i = 0; i < 400; i++)
            {
                int X = rand.Next(1, 100);

            }
        }

        private void Timer()
        {

        }

        private void btnNight_Click(object sender, EventArgs e)
        {

        }

        private void btnTimer_Click(object sender, EventArgs e)
        {

        }

        private void btnAuto_Click(object sender, EventArgs e)
        {

        }
    }
}
