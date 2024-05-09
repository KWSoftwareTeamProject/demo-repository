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
        public Color currentDateColor;//현재 날짜의 색깔 여부

        //Roomdata는 set get으로 데이터 설정 가능

        public RoomData Room1data;//방 1의 데이터 (온도, 미세먼지)
        public RoomData Room2data;//방 2의 데이터 (온도, 미세먼지)
        public RoomData Room3data;//방 3의 데이터 (온도, 미세먼지)
        public RoomData Room4data;//방 4의 데이터 (온도, 미세먼지)

        public string season="봄";//계절
        public float dayTime=0;//시간
        //시간 관련 변수 만들어서 변경할 거 필요

        public bool isstart = false;//모든건 이게 true여야만 실행됨
        public Aircon room1AC = new Aircon(1);

        public Form1()
        {
            InitializeComponent();
            Room1data=new RoomData();
            Room2data=new RoomData();
            Room3data=new RoomData();
            Room4data=new RoomData();
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
            if (isstart == true)
            {
                LightController LC = new LightController();
                LC.Owner = this;
                LC.ChangeLight += new EventHandler(Change_Light);
                LC.Show();
            }
        }

        private void Change_Light(object sender, EventArgs e)//컨트롤러에서 인자 전달
        {
            
                LightController Lc = sender as LightController;
                Color Lightness = Lc.GetLightnessValue();
                방1.BackColor = Lightness;
        }

        public Color GetRoom1data()//방1의 배경색 전달
        {
            Color color = Color.FromArgb(방1.BackColor.R, 방1.BackColor.G, 방1.BackColor.B);
            return color;
        }

       
        private void setTime_Tick(object sender, EventArgs e)//시간 작동 (작동이 안되어 있을 시 시간 변동 x)
        {
           if(Room1data.getlightonoff()==false)//방1의 전등이 on 되어 있을때 작동
            {
                방1.BackColor = currentDateColor;
                방2.BackColor = currentDateColor;
                방3.BackColor = currentDateColor;
                방4.BackColor = currentDateColor;

            }
            timedatalb.Text = dayTime.ToString();
            rmlbset();
        }

        private void rmlbset()//각 방의 데이타 정보 표기 세팅
        {
            rm1dgdata.Text = Room1data.getDegree().ToString();
            rm2dgdata.Text = Room2data.getDegree().ToString();
            rm3dgdata.Text = Room3data.getDegree().ToString();
            rm4dgdata.Text = Room4data.getDegree().ToString();

            rm1fddata.Text = Room1data.getFineDust().ToString();
            rm2fddata.Text = Room2data.getFineDust().ToString();
            rm3fddata.Text = Room3data.getFineDust().ToString();
            rm4fddata.Text = Room4data.getFineDust().ToString();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            currentDateColor = new Color();
            //currentDateColor = Color.FromArgb();//배경색깔 추가

            rmlbset();
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

        private void SettingData_Click(object sender, EventArgs e)//환경변수 설정
        {
            EnvironmentalChange EC=new EnvironmentalChange();
            EC.Owner = this;
            EC.settingDatahandler += new EventHandler(setting_dataset);
            EC.Show();
        }
        private void setting_dataset(object sender, EventArgs e)//환경변수 폼에서 받아와서 텍스트에 작성
        {
            EnvironmentalChange EC = sender as EnvironmentalChange;
            string seasondata=EC.getseasonData();
            string timedata = EC.gettimeData();
            season = seasondata;
            dayTime = Int32.Parse(timedata);
            seasondatalb.Text = seasondata;
            timedatalb.Text = timedata;

            float fineDust;
            switch (season) // 계절에 따라 미세먼지 초기화
            {
                case "봄":
                    fineDust = 25;
                    break;
                case "여름":
                    fineDust = 16;
                    break;
                case "가을":
                    fineDust = 15;
                    break;
                default:
                    fineDust = 29;
                    break;
            }

            Room1data.setFineDust(fineDust);
            Room2data.setFineDust(fineDust);
            Room3data.setFineDust(fineDust);
            Room4data.setFineDust(fineDust);
        }

        private void timestartbt_Click(object sender, EventArgs e)
        {
            if (isstart == false)
            {
                setTime.Start();
                isstart = true;
            }
            else
            {
                isstart = false;
                setTime.Stop();
                방1.BackColor = Color.FromArgb(192, 255, 255);
                방2.BackColor = Color.FromArgb(192, 255, 255);
                방3.BackColor= Color.FromArgb(192, 255, 255);
                방4.BackColor= Color.FromArgb(192, 255, 255);
            }
        }

  
    }
}
