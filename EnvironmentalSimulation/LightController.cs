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
    public partial class LightController : Form
    {
        public EventHandler ChangeLight;

        public LightController()
        {
            InitializeComponent();
        }

        private void BackGround1_TextChanged(object sender, EventArgs e)
        {

        }

        private void textBox2_TextChanged(object sender, EventArgs e)
        {

        }

        private void currentTime_Tick(object sender, EventArgs e)
        {
            Form1 form1 = (Form1)this.Owner;
            Color color = form1.GetRoom1data();
            textBox2.BackColor = color;
        }

        private void LightController_Load(object sender, EventArgs e)
        {
            currentTime.Start();
            Form1 form1 = (Form1)this.Owner;
            Color color = form1.GetRoom1data();
            textBox3.BackColor = color;
        }

       


        private void lightturn_Click(object sender, EventArgs e)
        {
            Form1 form1 = (Form1)this.Owner;
            if (form1.Room1Light == false)
            {
                if (ChangeLight != null)
                {
                    ChangeLight(this, new EventArgs());
                }
            }
            else
            {
                form1.Room1Light = false ;//배경 색으로 변경 필요
            }
        }

        public Color GetLightnessValue()
        {
            return textBox3.BackColor;
        }

        private void hsbright_Scroll(object sender, ScrollEventArgs e)
        {
            Color color = Color.FromArgb(255, 255, hsbright.Value);
            textBox3.BackColor = color;
        }
    }
}
