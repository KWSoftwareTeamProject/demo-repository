using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EnvironmentalSimulation
{
    public class Aircon
    {
        public int roomN;//방번호
        public bool turnOn;//전원이 켜졌는지
        public bool turnOnSwing;//회전이 켜졌는지
        public int fanSpeedN;//약풍 = 0, 강풍 = 1
        public int setToTemp;//희망온도

        public Aircon(int roomN)
        {
            this.roomN = roomN;
            turnOn = false;
            turnOnSwing = false;
            fanSpeedN = 0;
            setToTemp = 26;
        }

        public void copy_AC(bool turnOn, bool turnOnSwing, int fanSpeedN, int setToTemp)
        {
            this.turnOn = turnOn;
            this.turnOnSwing = turnOnSwing;
            this.fanSpeedN = fanSpeedN;
            this.setToTemp = setToTemp;
        }

        public void EV_Check(string season, int temp)
        {
            if (season == "여름")
                turnOn = true;
            //여기에는 28도 이상 되면 turnOn이 켜지도록
            //여기에는 32도 이상 되면 fanSpeedN = 1이 되도록
        }
    }
}
