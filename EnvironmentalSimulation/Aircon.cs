using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EnvironmentalSimulation
{
    public class Aircon
    {
        public int roomN;
        public bool turnOn;
        public bool turnOnSwing;
        public int fanSpeedN;
        public int setToTemp;

        public Aircon(int roomN)
        {
            this.roomN = roomN;
            turnOn = false;
            turnOnSwing = false;
            fanSpeedN = 0;
            setToTemp = 26;
        }
    }
}
