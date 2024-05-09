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
    public partial class AirconController : Form
    {
        public int roomN;
        public bool turnOn;
        public bool turnOnSwing;
        public int fanSpeedN;
        public int setToTemp;

        public event EventHandler Changed;

        public AirconController()
        {
            InitializeComponent();
        }

        public void AC_Changed(Aircon aircon)
        {
            turnOn = aircon.turnOn;
            turnOnSwing = aircon.turnOnSwing;
            fanSpeedN = aircon.fanSpeedN;
            setToTemp = aircon.setToTemp;
            roomN = aircon.roomN;
        }

        private void turnOn_btn_Click(object sender, EventArgs e)
        {
            if(turnOn == false)
            {
                turnOn = true;
                turnOnLight_btn.BackColor = Color.Red;
            }
            else
            {
                turnOn = false;
                turnOnLight_btn.BackColor = Color.White;
            }
        }

        private void swing_btn_Click(object sender, EventArgs e)
        {
            swingOnLight_btn.BackColor = Color.Red;
        }

        private void AirconController_Load(object sender, EventArgs e)
        {
        }

        private void AirconController_FormClosed(object sender, FormClosedEventArgs e)
        {
            Changed(this, new EventArgs());
        }
    }
}
