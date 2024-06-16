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
        public float SunUp;
        public float SunDown;

        public bool istimeaccel;
        //Roomdata는 set get으로 데이터 설정 가능

        public RoomData Room1data;//방 1의 데이터 (온도, 미세먼지)
        public RoomData Room2data;//방 2의 데이터 (온도, 미세먼지)
        public RoomData Room3data;//방 3의 데이터 (온도, 미세먼지)
        public RoomData Room4data;//방 4의 데이터 (온도, 미세먼지)

        public string season = "봄";//계절
        public float dayTime = 0;//시간
        //시간 관련 변수 만들어서 변경할 거 필요

        public bool isstart = false;//모든건 이게 true여야만 실행됨
        public int lastTemperatureChangeHour = -1; // 마지막으로 온도를 변경한 시간

        public Aircon room1AC = new Aircon(1);//방 1의 에어컨 클래스
        public Aircon room2AC = new Aircon(2);//방 2의 에어컨 클래스
        public Aircon room3AC = new Aircon(3);//방 3의 에어컨 클래스
        public Aircon room4AC = new Aircon(4);//방 4의 에어컨 클래스

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
            setValue();
        }

        private void setValue()
        {
            Room1data = new RoomData();
            Room2data = new RoomData();
            Room3data = new RoomData();
            Room4data = new RoomData();

            room1Aircleaner = new Aircleaner(Room1data);
            room2Aircleaner = new Aircleaner(Room2data);
            room3Aircleaner = new Aircleaner(Room3data);
            room4Aircleaner = new Aircleaner(Room4data);

            room1Heater = new Heater(Room1data);
            room2Heater = new Heater(Room2data);
            room3Heater = new Heater(Room3data);
            room4Heater = new Heater(Room4data);
            istimeaccel = false;//시간 가속
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

        private void 방전등_Click(object sender, EventArgs e)
        {
            if (isstart == true)
            {
                LightController LC = new LightController();
                LC.Owner = this;
                if (((Button)sender).Name == "방1전등")
                {
                    LC.ButtonInfo = 1;
                    LC.ChangeLight += new EventHandler(Change_Light1);
                }
                else if (((Button)sender).Name == "방2전등")
                {
                    LC.ButtonInfo = 2;
                    LC.ChangeLight += new EventHandler(Change_Light2);
                }
                else if (((Button)sender).Name == "방3전등")
                {
                    LC.ButtonInfo = 3;
                    LC.ChangeLight += new EventHandler(Change_Light3);
                }
                else if (((Button)sender).Name == "방4전등")
                {
                    LC.ButtonInfo = 4;
                    LC.ChangeLight += new EventHandler(Change_Light4);
                }
                LC.Show();
            }
        }

        private void Change_Light1(object sender, EventArgs e)//컨트롤러에서 인자 전달(방1 전등)
        {

            LightController Lc = sender as LightController;
            Color Lightness = Lc.GetLightnessValue();
            방1.BackColor = Lightness;
        }
        private void Change_Light2(object sender, EventArgs e)//컨트롤러에서 인자 전달(방2 전등)
        {

            LightController Lc = sender as LightController;
            Color Lightness = Lc.GetLightnessValue();
            방2.BackColor = Lightness;
        }
        private void Change_Light3(object sender, EventArgs e)//컨트롤러에서 인자 전달(방3 전등)
        {

            LightController Lc = sender as LightController;
            Color Lightness = Lc.GetLightnessValue();
            방3.BackColor = Lightness;
        }
        private void Change_Light4(object sender, EventArgs e)//컨트롤러에서 인자 전달(방4 전등)
        {

            LightController Lc = sender as LightController;
            Color Lightness = Lc.GetLightnessValue();
            방4.BackColor = Lightness;
        }

        public Color GetRoom1data()//방1의 배경색 전달
        {
            Color color = Color.FromArgb(방1.BackColor.R, 방1.BackColor.G, 방1.BackColor.B);
            return color;
        }
        public Color GetRoom2data()//방1의 배경색 전달
        {
            Color color = Color.FromArgb(방2.BackColor.R, 방2.BackColor.G, 방2.BackColor.B);
            return color;
        }

        public Color GetRoom3data()//방1의 배경색 전달
        {
            Color color = Color.FromArgb(방3.BackColor.R, 방3.BackColor.G, 방3.BackColor.B);
            return color;
        }
        public Color GetRoom4data()//방1의 배경색 전달
        {
            Color color = Color.FromArgb(방4.BackColor.R, 방4.BackColor.G, 방4.BackColor.B);
            return color;
        }




        private void setTime_Tick(object sender, EventArgs e)//시간 작동 (작동이 안되어 있을 시 시간 변동 x)(0.1초 마다 작동)
        {
            presettinglight();

            room1Aircleaner.UpdateTimeAccel(istimeaccel);
            room2Aircleaner.UpdateTimeAccel(istimeaccel);
            room3Aircleaner.UpdateTimeAccel(istimeaccel);
            room4Aircleaner.UpdateTimeAccel(istimeaccel);

            room1AC.EV_Check(Room1data.getDegree());
            room2AC.EV_Check(Room2data.getDegree());
            room3AC.EV_Check(Room3data.getDegree());
            room4AC.EV_Check(Room4data.getDegree());

            if(isstart == true)
            {
                if(room1AC.turnOn == true)
                    방1에어컨.BackColor = Color.Blue;
                else
                    방1에어컨.BackColor = Color.White;
                if (room2AC.turnOn == true)
                    방2에어컨.BackColor = Color.Blue;
                else
                    방2에어컨.BackColor = Color.White;
                if (room3AC.turnOn == true)
                    방3에어컨.BackColor = Color.Blue;
                else
                    방3에어컨.BackColor = Color.White;
                if (room4AC.turnOn == true)
                    방4에어컨.BackColor = Color.Blue;
                else
                    방4에어컨.BackColor = Color.White;
            }

            int texttime = (int)dayTime;
            timedatalb.Text = texttime.ToString() + " 시";

            if ((texttime == 12 || texttime == 13 || texttime == 14 || texttime == 15) && lastTemperatureChangeHour != texttime)
            {
                IncreaseTemperature();
                lastTemperatureChangeHour = texttime; // 마지막으로 온도를 변경한 시간 기록
            }
            else if ((texttime == 16 || texttime == 17 || texttime == 18 || texttime == 19) && lastTemperatureChangeHour != texttime)
            {
                DecreaseTemperature();
                lastTemperatureChangeHour = texttime; // 마지막으로 온도를 변경한 시간 기록
            }

            rmlbset();
        }

        private void IncreaseTemperature()
        {
            Room1data.setDegree(Room1data.getDegree() + 1);
            Room2data.setDegree(Room2data.getDegree() + 1);
            Room3data.setDegree(Room3data.getDegree() + 1);
            Room4data.setDegree(Room4data.getDegree() + 1);

            UpdateTemperatureLabels();
        }

        private void DecreaseTemperature()
        {
            Room1data.setDegree(Room1data.getDegree() - 1);
            Room2data.setDegree(Room2data.getDegree() - 1);
            Room3data.setDegree(Room3data.getDegree() - 1);
            Room4data.setDegree(Room4data.getDegree() - 1);

            UpdateTemperatureLabels();
        }

        private void UpdateTemperatureLabels()
        {
            rm1dgdata.Text = Room1data.getDegree().ToString();
            rm2dgdata.Text = Room2data.getDegree().ToString();
            rm3dgdata.Text = Room3data.getDegree().ToString();
            rm4dgdata.Text = Room4data.getDegree().ToString();
        }

        private void presettinglight()
        {
            if (Room1data.getlightonoff() == false)//of일떄 기본으로 세팅
            {
                방1.BackColor = currentDateColor;
                방1전등.ForeColor = Color.Black;
            }
            else
            {
                방1전등.ForeColor = Color.Red;
            }
            if (Room2data.getlightonoff() == false)
            {
                방2.BackColor = currentDateColor;
                방2전등.ForeColor = Color.Black;
            }
            else
            {
                방2전등.ForeColor = Color.Red;

            }
            if (Room3data.getlightonoff() == false)
            {
                방3.BackColor = currentDateColor;
                방3전등.ForeColor = Color.Black;
            }
            else
            {
                방3전등.ForeColor = Color.Red;

            }
            if (Room4data.getlightonoff() == false)
            {
                방4.BackColor = currentDateColor;
                방4전등.ForeColor = Color.Black;
            }
            else
            {
                방4전등.ForeColor = Color.Red;
            }
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
            //example.BackColor = Color.Transparent;

            rmlbset();
        }

        private void roomAC_Changed(object obj, EventArgs e)//에어컨 컨트롤러를 닫을 때 컨트롤러의 마지막 정보를 폼1에 저장
        {
            AirconController AC = obj as AirconController;
            switch (AC.roomN)
            {
                case 1:
                    room1AC.copy_AC(AC.turnOn, AC.turnOnSwing, AC.fanSpeedN, AC.setToTemp);
                    break;
                case 2:
                    room2AC.copy_AC(AC.turnOn, AC.turnOnSwing, AC.fanSpeedN, AC.setToTemp);
                    break;
                case 3:
                    room3AC.copy_AC(AC.turnOn, AC.turnOnSwing, AC.fanSpeedN, AC.setToTemp);
                    break;
                case 4:
                    room4AC.copy_AC(AC.turnOn, AC.turnOnSwing, AC.fanSpeedN, AC.setToTemp);
                    break;
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

            switch (AC.roomN)
            {
                case 1:
                    방1에어컨.BackColor = color;
                    break;
                case 2:
                    방2에어컨.BackColor = color;
                    break;
                case 3:
                    방3에어컨.BackColor = color;
                    break;
                case 4:
                    방4에어컨.BackColor = color;
                    break;
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
            EnvironmentalChange EC = new EnvironmentalChange();
            EC.Owner = this;
            EC.settingDatahandler += new EventHandler(setting_dataset);
            EC.Show();
        }

        private void SetRoomTemperaturesAndFineDusts(string season)
        {
            Random rand = new Random();
            int temperature, fineDust;

            switch (season)
            {
                case "봄":
                    temperature = 15 + rand.Next(-5, 6);
                    fineDust = 57;
                    break;
                case "여름":
                    temperature = 25 + rand.Next(-5, 6);
                    fineDust = 25; 
                    break;
                case "가을":
                    temperature = 15 + rand.Next(-5, 6);
                    fineDust = 26; 
                    break;
                case "겨울":
                    temperature = 5 + rand.Next(-5, 6);
                    fineDust = 47; 
                    break;
                default:
                    temperature = 20 + rand.Next(-5, 6);
                    fineDust = 57;
                    break;
            }

            // 각 방의 온도를 baseTemperature ± 5 범위 내에서 랜덤하게 설정
            Room1data.setDegree(temperature);
            Room2data.setDegree(temperature);
            Room3data.setDegree(temperature);
            Room4data.setDegree(temperature);

            Room1data.setFineDust(fineDust);
            Room2data.setFineDust(fineDust);
            Room3data.setFineDust(fineDust);
            Room4data.setFineDust(fineDust);

            rmlbset();
        }

        private void setting_dataset(object sender, EventArgs e)
        {
            EnvironmentalChange EC = sender as EnvironmentalChange;
            string seasondata = EC.getseasonData();
            string timedata = EC.gettimeData();
            season = seasondata;
            dayTime = Int32.Parse(timedata);
            seasondatalb.Text = seasondata;
            timedatalb.Text = timedata;

            room1Aircleaner.SetSeason(season);
            room2Aircleaner.SetSeason(season);
            room3Aircleaner.SetSeason(season);
            room4Aircleaner.SetSeason(season);

            SetRoomTemperaturesAndFineDusts(season); // 각 방의 온도를 설정하는 메서드 호출
        }

        private void timestartbt_Click(object sender, EventArgs e)
        {
            if (isstart == false)//꺼져있을 경우 실행
            {
                timestartbt.ForeColor = Color.Red;
                lightfunction();
                //계절과 온도에 따라서 에어컨 전력 등 설정
                room1AC.EV_Check(Room1data.getDegree());
                room2AC.EV_Check(Room2data.getDegree());
                room3AC.EV_Check(Room3data.getDegree());
                room4AC.EV_Check(Room4data.getDegree());
                if (room1AC.turnOn == false)
                    방1에어컨.BackColor = Color.White;
                if (room2AC.turnOn == false)
                    방2에어컨.BackColor = Color.White;
                if (room3AC.turnOn == false)
                    방3에어컨.BackColor = Color.White;
                if (room4AC.turnOn == false)
                    방4에어컨.BackColor = Color.White;
                setTime.Start();
                time1second.Start();
                isstart = true;
            }
            else//켜져있을 경우 멈춤
            {
                timestartbt.ForeColor = Color.Black;
                isstart = false;
                setTime.Stop();
                time1second.Stop();

                방1에어컨.BackColor = Color.Blue;
                방2에어컨.BackColor = Color.Blue;
                방3에어컨.BackColor = Color.Blue;
                방4에어컨.BackColor = Color.Blue;
                resetvalue();

            }
        }

        private void resetvalue()
        {
            dayTime = 0;
            setTime.Stop();
            time1second.Stop();
            방1.BackColor = Color.FromArgb(192, 255, 255);
            방2.BackColor = Color.FromArgb(192, 255, 255);
            방3.BackColor = Color.FromArgb(192, 255, 255);
            방4.BackColor = Color.FromArgb(192, 255, 255);
            방1전등.ForeColor = Color.Black;
            방2전등.ForeColor = Color.Black;
            방3전등.ForeColor = Color.Black;
            방4전등.ForeColor = Color.Black;
            Room1data.setlightonoff(false);
            Room2data.setlightonoff(false);
            Room3data.setlightonoff(false);
            Room4data.setlightonoff(false);
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


        private void lightfunction()
        {
            //currentDateColor = Color.FromArgb(255, 255, (int)(130-120*Math.Cos(2*Math.PI*dayTime/24)));
            currentDateColor = Color.FromArgb((int)(130 - 100 * Math.Cos(2 * Math.PI * dayTime / 24)), (int)(130 - 100 * Math.Cos(2 * Math.PI * dayTime / 24)), 10);
        }

        private void time1second_Tick(object sender, EventArgs e)
        {
            if (isstart == true)
            {
                if (istimeaccel == false)
                {
                    dayTime += 0.1f;
                }
                else
                {
                    dayTime += 1;
                }
                if (dayTime > 24)
                {
                    dayTime = 0;
                }

                lightfunction();//계절별 시간 고려 필요
            }
        }

        private void timeaccel_Click(object sender, EventArgs e)
        {
            if (istimeaccel == false)
            {
                istimeaccel = true;
                timeaccel.ForeColor = Color.Red;
            }
            else
            {
                istimeaccel = false;
                timeaccel.ForeColor = Color.Black;
            }
        }
        private void 방2에어컨_Click(object sender, EventArgs e)
        {
            if (isstart == true)
            {
                AirconController AC = new AirconController();
                AC.Owner = this;
                AC.AC_Changed(room2AC);
                AC.roomAC_Changed += new EventHandler(roomAC_Changed);
                AC.Changed_Aircon += new EventHandler(Changed_Aircon);
                AC.Show();
            }
        }

        private void 방3에어컨_Click(object sender, EventArgs e)
        {
            if (isstart == true)
            {
                AirconController AC = new AirconController();
                AC.Owner = this;
                AC.AC_Changed(room3AC);
                AC.roomAC_Changed += new EventHandler(roomAC_Changed);
                AC.Changed_Aircon += new EventHandler(Changed_Aircon);
                AC.Show();
            }
        }

        private void 방4에어컨_Click(object sender, EventArgs e)
        {
            if (isstart == true)
            {
                AirconController AC = new AirconController();
                AC.Owner = this;
                AC.AC_Changed(room4AC);
                AC.roomAC_Changed += new EventHandler(roomAC_Changed);
                AC.Changed_Aircon += new EventHandler(Changed_Aircon);
                AC.Show();
            }
        }
    }
}

