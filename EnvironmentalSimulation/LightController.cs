﻿using System;
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

 
        private void currentTime_Tick(object sender, EventArgs e)
        {
            Form1 form1 = (Form1)this.Owner;
            Color color = form1.GetRoom1data();//룸1의 방을 설정
            textBox2.BackColor = color;//룸1의 현재 방 색이 무엇인지 표기
        }

        private void LightController_Load(object sender, EventArgs e)
        {
            currentTime.Start();
            Form1 form1 = (Form1)this.Owner;
            Color R1color = form1.GetRoom1data();//현재 방의 색깔이 무엇인지 표기
            textBox2.BackColor = R1color;
            if (form1.Room1data.getlightonoff() == false)
            {
                this.lightturn.Enabled = false;
            }
            else
                this.hsbright.Enabled = false;
        }

       


        private void lightturn_Click(object sender, EventArgs e)
        {
            Form1 form1 = (Form1)this.Owner;
            if (ChangeLight != null)
            {
                if (form1.Room1data.getlightonoff() == false)
                {
                    ChangeLight(this, new EventArgs());
                    form1.Room1data.setlightonoff(true);
                    this.hsbright.Enabled = false;

                }
                else
                {
                    form1.Room1data.setlightonoff(false);//배경 색으로 변경 필요
                    this.hsbright.Enabled = true;
                    
                }
            }
        }

        public Color GetLightnessValue()
        {
            return textBox3.BackColor;
        }

        private void hsbright_Scroll(object sender, ScrollEventArgs e)
        {
            this.lightturn.Enabled = true;
            Color color = Color.FromArgb(255, 255, hsbright.Value);
            textBox3.BackColor = color;
        }

    }
}
