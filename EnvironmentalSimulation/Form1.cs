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
        public bool Room1Light = false;
        public Form1()
        {
            InitializeComponent();
        }

        private void 방1전등_Click(object sender, EventArgs e)
        {
            LightController LC= new LightController();
            LC.Owner = this;
            LC.ChangeLight += new EventHandler(Change_Light);
            LC.Show();
        }

        private void Change_Light(object sender, EventArgs e)
        {
            LightController Lc= sender as LightController;
            Color Lightness=Lc.GetLightnessValue();
            방1.BackColor = Lightness;
        }

        public Color GetRoom1data()
        {
            Color color = Color.FromArgb(방1.BackColor.R, 방1.BackColor.G, 방1.BackColor.B);
            return color;
        }
    }
}
