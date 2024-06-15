using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Security.Cryptography.X509Certificates;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace EnvironmentalSimulation
{
    public class Aircleaner
    {
        private RoomData room;
        
        private float curFineDust;
        private float maxFineDust;
        private float minFineDust;

        private float[] varFineDust;    // 풍량별 미세먼지 농도 증감
        private int modeIndex;

        private bool powerOn;
        private bool nightOn;
        private bool timerOn;
        private bool autoOn;

        private int timer;
        private int interval;
        private int i;

        public Aircleaner(RoomData room)
        {
            this.room = room;

            curFineDust = room.getFineDust();
            maxFineDust = curFineDust;
            minFineDust = curFineDust;

            varFineDust = new float[5] {    // 모드에 따른 미세먼지 증감량
                0.03f,  // Off
                -0.1f,  // Low
                -0.15f, // Mid
                -0.2f,  // High
                -0.05f  // Night mode
            };

            modeIndex = 0;

            powerOn = false;
            timerOn = false;
            autoOn = false;

            timer = 0;
            interval = 100;
            i = 0;
        }

        public void SetSeason(string season)
        {
            switch (season) // 계절에 따라 미세먼지 초기화
            {
                case "봄":
                    curFineDust = 57;
                    break;
                case "여름":
                    curFineDust = 25;
                    break;
                case "가을":
                    curFineDust = 26;
                    break;
                default:
                    curFineDust = 47;
                    break;
            }

            maxFineDust = curFineDust;
            room.setFineDust((int)curFineDust);
        }

        public void UpdateTimeAccel(bool isTimeAccel)   // Form1.cs 타이머에서 호출
        {
            if (isTimeAccel) interval = 10;
            else interval = 100;
        }

        public void Update()    // AirCleanerController.cs 타이머에서 호출
        {
            if (IsTimerOn()) Timer();
            if (IsAutoOn()) Auto();
            UpdateFineDust();
            room.setFineDust((int)curFineDust);
        }

        private void UpdateFineDust()
        {
            switch(modeIndex)
            {
                case 1:
                    minFineDust = 10;
                    break;
                case 2:
                    minFineDust = 6;
                    break;
                case 3:
                    minFineDust = 2;
                    break;
                case 4:
                    minFineDust = 15;
                    break;
                default:
                    minFineDust = maxFineDust;
                    break;
            }   // 모드에 따라 최소 미세먼지 설정

            if (curFineDust + varFineDust[modeIndex] > maxFineDust) // 미세먼지 상한
            {
                curFineDust = maxFineDust;
            }
            else if (curFineDust + varFineDust[modeIndex] < minFineDust)    // 미세먼지 하한
            {
                curFineDust += varFineDust[0];
            }
            else // 모드에 따른 미세먼지 증감
            {
                curFineDust += varFineDust[modeIndex];
            }
        }

        private void Timer()
        {
            if (i == 10)
            {
                timer--;
                i = 0;
            }
            i++;

            if (timer == 0)
            {
                timerOn = false;
                autoOn = false;
                SetMode(0);
                NightOff();
                PowerOff();
            }
        }

        private void Auto()
        {
            if (curFineDust > 35)
                SetMode(3);
            else if (curFineDust > 20)
                SetMode(2);
            else if (curFineDust > 15)
                SetMode(1);
            else
                SetMode(4);
        }

        public void SetMode(int modeIndex)
        {
            this.modeIndex = modeIndex;
        }

        public int GetMode()
        {
            return modeIndex;
        }

        public bool isPowerOn()
        {
            return powerOn;
        }

        public void PowerOn()
        {
            powerOn = true;
        }

        public void PowerOff()
        {
            powerOn = false;
        }

        public bool IsNightOn()
        {
            return nightOn;
        }

        public void NightOnOff()
        {
            if (IsNightOn())
            {
                SetMode(0);
                PowerOff();
                nightOn = false;
            }
            else
            {
                SetMode(4);
                PowerOn();
                nightOn = true;
            }
        }

        public void NightOff()
        {
            nightOn = false;
        }

        public bool IsTimerOn()
        {
            return timerOn;
        }

        public void TimerOn(int interval)
        {
            timerOn = true;
            timer += interval;
        }

        public int GetTimer()
        {
            return timer;
        }

        public bool IsAutoOn()
        {
            return autoOn;
        }

        public void AutoOnOff()
        {
            if (IsAutoOn())
            {
                PowerOff();
                autoOn = false;
                SetMode(0);
            }
            else
            {
                PowerOn();
                autoOn = true;
                nightOn = false;
            }
        }

        public int GetFineDust()
        {
            return (int)curFineDust;
        }

        public int GetInterval()
        {
            return interval;
        }
    }
}
