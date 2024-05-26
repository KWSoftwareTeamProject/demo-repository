using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Runtime.Remoting.Channels;
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

        public Aircon room1AC = new Aircon(1);//방 1의 에어컨 클래스
        public Aircon room2AC = new Aircon(1);//방 2의 에어컨 클래스
        public Aircon room3AC = new Aircon(1);//방 3의 에어컨 클래스
        public Aircon room4AC = new Aircon(1);//방 4의 에어컨 클래스

        public Aircleaner room1Aircleaner;
        public Aircleaner room2Aircleaner;
        public Aircleaner room3Aircleaner;
        public Aircleaner room4Aircleaner;

        public Heater room1Heater;
        public Heater room2Heater;
        public Heater room3Heater;
        public Heater room4Heater;

        public Form1()
        {
            InitializeComponent();
            Room1data=new RoomData();
            Room2data=new RoomData();
            Room3data=new RoomData();
            Room4data=new RoomData();

            room1Aircleaner = new Aircleaner(Room1data);
            room2Aircleaner = new Aircleaner(Room2data);
            room3Aircleaner = new Aircleaner(Room3data);
            room4Aircleaner = new Aircleaner(Room4data);

            room1Heater = new Heater(Room1data);
            room2Heater = new Heater(Room2data);
            room3Heater = new Heater(Room3data);
            room4Heater = new Heater(Room4data);
        }

        private void 공기청정기_Click(object sender, EventArgs e)
        {
            if (isstart)
            {
                AirCleanerController airCleanerController;
                if (sender == 방1공기청정기)
                    airCleanerController = new AirCleanerController(room1Aircleaner);
                else if (sender == 방2공기청정기)
                    airCleanerController = new AirCleanerController(room2Aircleaner);
                else if (sender == 방3공기청정기)
                    airCleanerController = new AirCleanerController(room3Aircleaner);
                else
                    airCleanerController = new AirCleanerController(room4Aircleaner);

                airCleanerController.Owner = this;
                airCleanerController.Show();
            }
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

            room1Aircleaner.Update();
            room2Aircleaner.Update();
            room3Aircleaner.Update();
            room4Aircleaner.Update();

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

        private void roomAC_Changed(object obj, EventArgs e)//에어컨 컨트롤러를 닫을 때 컨트롤러의 마지막 정보를 폼1에 저장
        {
            AirconController AC = obj as AirconController;
            switch(AC.roomN)
            {
                case 1:
                    room1AC.copy_AC(AC.turnOn, AC.turnOnSwing, AC.fanSpeedN, AC.setToTemp);
                    break;
                    /*
                case 2:
                    room2AC.copy_AC(AC.turnOn, AC.turnOnSwing, AC.fanSpeedN, AC.setToTemp);
                    break;
                case 3:
                    room3AC.copy_AC(AC.turnOn, AC.turnOnSwing, AC.fanSpeedN, AC.setToTemp);
                    break;
                case 4:
                    room4AC.copy_AC(AC.turnOn, AC.turnOnSwing, AC.fanSpeedN, AC.setToTemp);
                    break;
                    */
            }
        }

        private void Changed_Aircon(object sender, EventArgs e)
        {
            AirconController AC = sender as AirconController;

            Color color = new Color();
            if (AC.turnOn == false)
                color = Color.White;
            else
                color = Color.Blue;

            switch(AC.roomN)
            {
                case 1:
                    방1에어컨.BackColor = color;
                    break;
                    /*
                case 2:
                    방2에어컨.BackColor = color;
                    break;
                case 3:
                    방3에어컨.BackColor = color;
                    break;
                case 4:
                    방4에어컨.BackColor = color;
                    break;
                    */
            }
        }

        private void 방1에어컨_Click(object sender, EventArgs e)//방1의 에어컨 컨트롤러 오픈
        {
            if (isstart == true)
            {
                AirconController AC = new AirconController();
                AC.Owner = this;
                AC.AC_Changed(room1AC);
                AC.roomAC_Changed += new EventHandler(roomAC_Changed);
                AC.Changed_Aircon += new EventHandler(Changed_Aircon);
                AC.Show();
            }
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

            room1Aircleaner.SetSeason(season);
            room2Aircleaner.SetSeason(season);
            room3Aircleaner.SetSeason(season);
            room4Aircleaner.SetSeason(season);
        }

        private void timestartbt_Click(object sender, EventArgs e)
        {
            if (isstart == false)
            {
                //계절과 온도에 따라서 에어컨 전력 등 설정
                /*room1AC.EV_Check(seasondatalb.Text, 온도);
                room2AC.EV_Check(seasondatalb.Text, 온도);
                room3AC.EV_Check(seasondatalb.Text, 온도);
                room4AC.EV_Check(seasondatalb.Text, 온도);*/
                if(room1AC.turnOn ==  false)
                    방1에어컨.BackColor = Color.White;
                /*
                if(room2AC.turnOn ==  false)
                    방2에어컨.BackColor = Color.White;
                if(room3AC.turnOn ==  false)
                    방3에어컨.BackColor = Color.White;
                if(room4AC.turnOn ==  false)
                    방4에어컨.BackColor = Color.White;
                */
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
                방1에어컨.BackColor = Color.Blue;/*
                방2에어컨.BackColor = Color.Blue;
                방3에어컨.BackColor = Color.Blue;
                방4에어컨.BackColor = Color.Blue;*/
            }
        }

        private void 난방_Click(object sender, EventArgs e)
        {
            if (isstart == true)
            {
                HeaterController HC = new HeaterController();
                HC.Owner = this;

                if (sender == 방1난방)
                {
                    HC.SetRoomData(Room1data);
                }
                else if (sender == 방2난방)
                {
                    HC.SetRoomData(Room2data);
                }
                else if (sender == 방3난방)
                {
                    HC.SetRoomData(Room3data);
                }
                else if (sender == 방4난방)
                {
                    HC.SetRoomData(Room4data);
                }

                HC.Show();
            }
        }
    }
}
