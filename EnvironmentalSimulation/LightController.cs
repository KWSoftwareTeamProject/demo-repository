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
        public Color RoomColor;
        public Color buttonColor;
        public Form1 form1;
        public float buttonsize = 120f;
        public Point buttonPoint;
        public Pen linepen;
        public float angle;
        public int ButtonInfo { get; set; }//몇번째 룸인지 확인 받는 방법

        public LightController()
        {
            InitializeComponent();
        }
        private void setvalue()
        {
            buttonColor = Color.FromArgb(200, 200, 200);
            linepen =new Pen(Color.Black,2);
            
            float currentangle = (float)((RoomColor.B-10)*(2*Math.PI)/240);
            buttonPoint = new Point((int)(panel1.Width / 2 + buttonsize / 2 * Math.Sin(currentangle)), (int)(panel1.Height / 2 - buttonsize / 2 * Math.Cos(currentangle)));

        }


        private void currentTime_Tick(object sender, EventArgs e)
        {
            currentRoomInfo();
            textBox2.BackColor = RoomColor;//룸1의 현재 방 색이 무엇인지 표기
        }

        private void LightController_Load(object sender, EventArgs e)
        {

            currentTime.Start();
            form1 = (Form1)this.Owner;
            switch (ButtonInfo)
            {
                case 1:
                    {
                        Room1Set();
                        break;
                    }
                case 2:
                    {
                        Room2Set();
                        break;
                    }
                case 3:
                    {
                        Room3Set();
                        break;
                    }
                case 4:
                    {
                        Room4Set();
                        break;
                    }
            }
            currentRoomInfo();
            setvalue();

        }

        private void currentRoomInfo()//현재 방색
        {
            switch (ButtonInfo)
            {
                case 1:
                    {
                        RoomColor = form1.GetRoom1data();
                        break;
                    }
                case 2:
                    {
                        RoomColor = form1.GetRoom2data();
                        break;
                    }
                case 3:
                    {
                        RoomColor = form1.GetRoom3data();
                        break;
                    }
                case 4:
                    {
                        RoomColor = form1.GetRoom4data();
                        break;
                    }
            }
        }
       
        private void Room1Set()
        {
            if (form1.Room1data.getlightonoff() == false)
            {
                this.lightturn.Enabled = false;
                lightturn.ForeColor = Color.Black;
            }
            else
            {
                this.lightturn.Enabled = true;
                lightturn.ForeColor = Color.DarkRed;
            }
        }
        private void Room2Set()
        {
            if (form1.Room2data.getlightonoff() == false)
            {
                this.lightturn.Enabled = false;
                lightturn.ForeColor = Color.Black;
            }
            else
            {
                this.lightturn.Enabled = true;
                lightturn.ForeColor = Color.DarkRed;
            }
        }
        private void Room3Set()
        {
            if (form1.Room3data.getlightonoff() == false)
            {
                this.lightturn.Enabled = false;
                lightturn.ForeColor = Color.Black;
            }
            else
            {
                this.lightturn.Enabled = true;
                lightturn.ForeColor = Color.DarkRed;
            }

        }
        private void Room4Set()
        {
            if (form1.Room4data.getlightonoff() == false)
            {
                this.lightturn.Enabled = false;
                lightturn.ForeColor = Color.Black;
            }
            else
            {
                this.lightturn.Enabled = true;
                lightturn.ForeColor = Color.DarkRed;
            }
        }

        private void lightturn_Click(object sender, EventArgs e)
        {
            if (ChangeLight != null)
            {
                turnlight();
            }
        }

        private void turnlight()
        {
            switch (ButtonInfo)
            {
                case 1:
                    {
                        if (form1.Room1data.getlightonoff() == false)
                        {
                            ChangeLight(this, new EventArgs());
                            form1.Room1data.setlightonoff(true);
                            lightturn.ForeColor = Color.DarkRed;
                        }
                        else
                        {
                            form1.Room1data.setlightonoff(false);//배경 색으로 변경 필요
                            lightturn.ForeColor = Color.Black;

                        }
                        break;
                    }
                case 2:
                    {
                        if (form1.Room2data.getlightonoff() == false)
                        {
                            ChangeLight(this, new EventArgs());
                            form1.Room2data.setlightonoff(true);
                            lightturn.ForeColor = Color.DarkRed;

                        }
                        else
                        {
                            form1.Room2data.setlightonoff(false);//배경 색으로 변경 필요
                            lightturn.ForeColor = Color.Black;

                        }
                        break;
                    }
                case 3:
                    {
                        if (form1.Room3data.getlightonoff() == false)
                        {
                            ChangeLight(this, new EventArgs());
                            form1.Room3data.setlightonoff(true);
                            lightturn.ForeColor = Color.DarkRed;


                        }
                        else
                        {
                            form1.Room3data.setlightonoff(false);//배경 색으로 변경 필요
                            lightturn.ForeColor = Color.Black;

                        }
                        break;
                    }
                case 4:
                    {
                        if (form1.Room4data.getlightonoff() == false)
                        {
                            ChangeLight(this, new EventArgs());
                            form1.Room4data.setlightonoff(true);
                            lightturn.ForeColor = Color.DarkRed;



                        }
                        else
                        {
                            form1.Room4data.setlightonoff(false);//배경 색으로 변경 필요
                            lightturn.ForeColor = Color.Black;

                        }
                        break;
                    }
            }
        }

        public Color GetLightnessValue()
        {
            return textBox3.BackColor;
        }

      

        private void textBox2_TextChanged(object sender, EventArgs e)
        {

        }

        private void panel1_Paint(object sender, PaintEventArgs e)
        {
            Graphics G = e.Graphics;
            SolidBrush GrayBursh = new SolidBrush(buttonColor);
            SolidBrush darkgrayBrush = new SolidBrush(Color.FromArgb(160, 160, 160));
            
            G.FillEllipse(darkgrayBrush,(panel1.Width-buttonsize)/2-9,(panel1.Height-buttonsize)/2-6,buttonsize+8,buttonsize+5);
            G.FillEllipse(GrayBursh, (panel1.Width-buttonsize)/2, (panel1.Height-buttonsize)/2, buttonsize,buttonsize);
            G.DrawLine(linepen, new Point(panel1.Width/2, panel1.Height/2), buttonPoint);
            G.FillEllipse(GrayBursh, (panel1.Width - buttonsize) / 2+10, (panel1.Height - buttonsize) / 2+10, buttonsize-20, buttonsize-20);

        }

        private void panel1_MouseDown(object sender, MouseEventArgs e)
        {

            double diagonal = Math.Sqrt(Math.Pow(panel1.Width / 2 - e.X, 2) + Math.Pow(panel1.Height / 2 - e.Y, 2));
            double straight = panel1.Height / 2 - e.Y;
            if (diagonal < buttonsize / 2)
            {
                angle = (float)Math.Acos(straight / diagonal);

                if (e.X > (panel1.Width / 2))//마우스가 중심보다 오른쪽
                {
                    angle = (float)Math.Acos(straight / diagonal);
                }
                else//마우스가 중심보다 왼쪽
                {
                    angle = (float)(2 * Math.PI - Math.Acos(straight / diagonal));
                }

                buttonPoint.X = (int)(panel1.Width / 2 + (buttonsize / 2) * Math.Sin(angle));
                buttonPoint.Y = (int)(panel1.Height / 2 - (buttonsize / 2) * Math.Cos(angle));
                panel1.Invalidate(true);
                panel1.Update();

                currentcolorsetting();
            }
            if (lightturn.ForeColor == Color.DarkRed)
            {
                ChangeLight(this, new EventArgs());

            }


        }

        private void currentcolorsetting()
        {
            this.lightturn.Enabled = true;
            Color color = Color.FromArgb(255, 255, 10 + (int)(angle / (2 * Math.PI) * 240));
            textBox3.BackColor = color;
        }

      

       
    }
}
