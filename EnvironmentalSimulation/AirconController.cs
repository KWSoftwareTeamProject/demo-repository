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
        public AirconController()
        {
            InitializeComponent();
        }

        private void turnOn_btn_Click(object sender, EventArgs e)
        {
            turnOnLight_btn.BackColor = Color.Red;
        }

        private void swing_btn_Click(object sender, EventArgs e)
        {
            swingOnLight_btn.BackColor = Color.Red;
        }
    }
}
