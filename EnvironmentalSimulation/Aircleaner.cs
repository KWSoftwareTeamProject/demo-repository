using System;
using System.Collections.Generic;
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

        public Aircleaner(RoomData room)
        {
            this.room = room;

            curFineDust = room.getFineDust();
            maxFineDust = curFineDust;
            minFineDust = curFineDust;

            varFineDust = new float[5] { 0.03f, -0.1f, -0.15f, -0.2f, -0.05f };   // { x, 약, 중, 강, Night mode }
            modeIndex = 0;

            powerOn = false;
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

        public void Update()    // Form1.cs 타이머에서 호출
        {
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
            }

            if (curFineDust + varFineDust[modeIndex] > maxFineDust)
            {
                curFineDust = maxFineDust;
            }
            else if (curFineDust + varFineDust[modeIndex] < minFineDust)
            {
                curFineDust += varFineDust[0];
            }
            else
            {
                curFineDust += varFineDust[modeIndex];
            }
        }

        public void SetMode(int modeIndex)
        {
            this.modeIndex = modeIndex;
        }

        public void PowerOn()
        {
            powerOn = true;
        }

        public void PowerOff()
        {
            powerOn = false;
        }

        public int GetFineDust()
        {
            return (int)curFineDust;
        }
    }
}
