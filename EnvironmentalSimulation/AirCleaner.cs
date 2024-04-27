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
    public partial class AirCleaner : Form
    {
        public AirCleaner()
        {
            InitializeComponent();
        }

        private void AirCleaner_Shown(object sender, EventArgs e)
        {
            Graphics g = base.CreateGraphics();
            SolidBrush brush = new SolidBrush(Color.DarkGray);

            g.FillEllipse(brush, 10, 10, 280, 280);
        }

        private void btnPower_Click(object sender, EventArgs e)
        {
            
        }
    }
}
