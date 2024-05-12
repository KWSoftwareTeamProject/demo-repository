using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace EnvironmentalSimulation
{
    public partial class HeaterController : Form
    {
        public bool power;

        public HeaterController()
        {
            InitializeComponent();
        }

        private void HeaterOn()
        {
            gBox.BackColor = Color.FromArgb(255, 255, 200);
            btnUp.Click += btnUp_Click;
            btnDown.Click += btnDown_Click;
        }

        private void HeaterOff()
        {
            gBox.BackColor = Color.FromArgb(160, 160, 160);
            btnUp.Click -= btnUp_Click;
            btnDown.Click -= btnDown_Click;
        }

        private void HeaterController_Load(object sender, EventArgs e)
        {
            btnUp.Click -= btnUp_Click;
            btnDown.Click -= btnDown_Click;
        }

        private void btnPower_Click(object sender, EventArgs e)
        {           
            if (power == false)
            {
                power = true;
                HeaterOn();
            }
            else
            {               
                power = false;
                HeaterOff();               
            }
        }

        private void btnUp_Click(object sender, EventArgs e)
        {
            int currentTemp;
            if (int.TryParse(lblTemp.Text, out currentTemp))
            {
                if (currentTemp == 30)
                {
                    currentTemp = 30;
                    lblTemp.Text = currentTemp.ToString();
                }
                else
                {
                    currentTemp = currentTemp + 1;
                    lblTemp.Text = currentTemp.ToString();
                }
            }
        }

        private void btnDown_Click(object sender, EventArgs e)
        {
            int currentTemp;
            if (int.TryParse(lblTemp.Text, out currentTemp))
            {
                if (currentTemp == 18)
                {
                    currentTemp = 18;
                    lblTemp.Text = currentTemp.ToString();
                }
                else
                {
                    currentTemp = currentTemp - 1;
                    lblTemp.Text = currentTemp.ToString();
                }
            }
        }
    }
}
