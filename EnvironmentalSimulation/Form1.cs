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
    public partial class Form1 : Form
    {
        public Color currentDateColor;//현제 날짜의 색깔 여부


        public bool Room1Light = false;//방1의 전등 on/off여부

        public Aircon room1AC = new Aircon(1);

        public Form1()
        {
            InitializeComponent();
        }

        private void 공기청정기_Click(object sender, EventArgs e)
        {
            AirCleanerController airCleaner = new AirCleanerController
            {
                Owner = this
            };
            airCleaner.Show();
        }

        private void 방1전등_Click(object sender, EventArgs e)
        {
            LightController LC= new LightController();
            LC.Owner = this;
            LC.ChangeLight += new EventHandler(Change_Light);
            LC.Show();
        }

        private void Change_Light(object sender, EventArgs e)//컨트롤러에서 인자 전달
        {
            LightController Lc= sender as LightController;
            Color Lightness=Lc.GetLightnessValue();
            방1.BackColor = Lightness;
        }

        public Color GetRoom1data()//방1의 배경색 전달
        {
            Color color = Color.FromArgb(방1.BackColor.R, 방1.BackColor.G, 방1.BackColor.B);
            return color;
        }

        private void setTime_Tick(object sender, EventArgs e)
        {
           if(Room1Light==false)//방1의 전등이 on 되어 있을때 작동
            {
                방1.BackColor = currentDateColor;
            }
            
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            currentDateColor = new Color();
            //currentDateColor = Color.FromArgb();//배경색깔 추가
            setTime.Start();
        }

        private void roomAC_Changed(object obj, EventArgs e)
        {
            AirconController AC = (AirconController)obj;
            switch(AC.roomN)
            {
                case 1:
                    room1AC.turnOn = AC.turnOn;
                    room1AC.turnOnSwing = AC.turnOnSwing;
                    room1AC.fanSpeedN = AC.fanSpeedN;
                    room1AC.setToTemp = AC.setToTemp;
                    break;
            }
        }

        private void 방1에어컨_Click(object sender, EventArgs e)//방1의 에어컨 컨트롤러 오픈
        {
            AirconController AC = new AirconController();
            AC.Owner = this;
            AC.AC_Changed(room1AC);
            AC.Changed += new EventHandler(roomAC_Changed);
            AC.Show();
        }
    }
}
