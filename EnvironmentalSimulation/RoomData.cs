using System;
using System.Collections.Generic;
using System.Configuration;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EnvironmentalSimulation
{
    public class RoomData
    {
        private int fineDust;//방의 농도
        private float degree;//방의 온도
        private bool lightonoff;
        public RoomData() { 
            fineDust = 0;
            degree = 0;
            lightonoff = false;
        }
        public void setFineDust(int setting)
        {
            fineDust = setting;
        }
        public void setDegree(float setting)
        {
            degree= setting;
        }
        public void setlightonoff(bool onoff)
        {
            lightonoff = onoff;
        }
      
        public int getFineDust()
        {
            return fineDust;
        }
        public float getDegree()
        {
            return degree;
        }
        public bool getlightonoff()
        {
            return lightonoff;
        }
        
    }
}
