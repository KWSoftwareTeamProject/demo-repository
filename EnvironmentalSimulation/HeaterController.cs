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
        public HeaterController()
        {
            InitializeComponent();
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
