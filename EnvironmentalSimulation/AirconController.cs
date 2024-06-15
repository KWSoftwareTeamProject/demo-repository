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
        Form1 form1;

        public event EventHandler roomAC_Changed;
        public event EventHandler Changed_Aircon;

        public AirconController()
        {
            InitializeComponent();
        }

        public void AC_Changed(Aircon aircon)//폼1에서 받아온 특정 방의 에어컨 정보를 저장
        {
            turnOn = aircon.turnOn;
            turnOnSwing = aircon.turnOnSwing;
            fanSpeedN = aircon.fanSpeedN;
            setToTemp = aircon.setToTemp;
            roomN = aircon.roomN;
        }

        private void turnOn_btn_Click(object sender, EventArgs e)//전원 버튼을 누른 경우
        {
            if(turnOn == false)
            {
                turnOn = true;
                AirconControllerON();
                Changed_Aircon(this, new EventArgs());
            }
            else
            {
                turnOn = false;
                AirconControllerOFF();
                Changed_Aircon(this, new EventArgs());
            }
        }

        private void swing_btn_Click(object sender, EventArgs e)//회전 버튼을 누른 경우
        {
            if(turnOn == false)
                return;
            if(turnOnSwing == false)
            {
                swingOnLight_btn.BackColor = Color.Red;
                swing_lbl.Text = "On";
                turnOnSwing = true;
            }
            else
            {
                swingOnLight_btn.BackColor = Color.White;
                swing_lbl.Text = "Off";
                turnOnSwing = false;
            }
        }

        private void AirconController_Load(object sender, EventArgs e)//폼1에서 show()로 창이 열릴 때
        {
            if (turnOn == false)
            {
                AirconControllerOFF();
            }
            else
            {
                AirconControllerON();
            }
            form1 = (Form1)this.Owner;
            ACtimer.Start();
        }

        private void AirconController_FormClosed(object sender, FormClosedEventArgs e)//창이 닫힐 때 가지고 있던 정보를 넘겨줌
        {
            roomAC_Changed(this, new EventArgs());
            ACtimer.Stop();
        }

        private void fanSpeed_btn_Click(object sender, EventArgs e)//풍향세기 버튼을 누른 경우
        {
            if (turnOn == false)
                return;
            if (fanSpeedN == 0)
            {
                fanSpeed_lbl.Text = "강풍";
                fanSpeedN = 1;
            }
            else
            {
                fanSpeed_lbl.Text = "약풍";
                fanSpeedN = 0;
            }
        }

        private void tempUp_btn_Click(object sender, EventArgs e)
        {
            if (turnOn == false)
                return;
            if (setToTemp == 30)
                return;
            else
            {
                setToTemp++;
                setToTemp_lbl.Text = setToTemp.ToString() + "dddd";
            }
        }

        private void tempDown_btn_Click(object sender, EventArgs e)
        {
            if (turnOn == false)
                return;
            if (setToTemp == 16)
                return;
            else
            {
                setToTemp--;
                setToTemp_lbl.Text = setToTemp.ToString() + "도";
            }
        }

        private void AirconControllerON()//전원이 켜져 있는 경우 전체 세팅
        {
            turnOnLight_btn.BackColor = Color.Red;
            if (turnOnSwing == false)
            {
                swingOnLight_btn.BackColor = Color.White;
                swing_lbl.Text = "Off";
            }
            else
            {
                swingOnLight_btn.BackColor = Color.Red;
                swing_lbl.Text = "On";
            }
            if (fanSpeedN == 0)
                fanSpeed_lbl.Text = "약풍";
            else
                fanSpeed_lbl.Text = "강풍";
            setToTemp_lbl.Text = setToTemp.ToString() + "도";
        }

        private void AirconControllerOFF()//전원이 꺼져 있는 경우 전체 세팅
        {
            turnOnLight_btn.BackColor = Color.White;
            swingOnLight_btn.BackColor = Color.White;
            swing_lbl.Text = "---";
            fanSpeed_lbl.Text = "---";
            setToTemp_lbl.Text = "---";
        }

        private void swing_lbl_Click(object sender, EventArgs e)
        {

        }

        private void ACtimer_Tick(object sender, EventArgs e)
        {
            float degree = form1.Room1data.getDegree();
            if (degree >= 25)
            {
                turnOn = true;
                if (degree >= 30)
                    fanSpeedN = 1;
                else if (degree <= 28)
                    fanSpeedN = 0;
            }
            else
                turnOn = false;
            if(turnOn == true)
                AirconControllerON();
            else
                AirconControllerOFF();
        }
    }
}
