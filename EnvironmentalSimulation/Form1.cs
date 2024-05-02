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
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void 공기청정기_Click(object sender, EventArgs e)
        {
            AirCleaner airCleaner = new AirCleaner
            {
                Owner = this
            };
            airCleaner.Show();
        }
    }
}
