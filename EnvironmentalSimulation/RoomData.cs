using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EnvironmentalSimulation
{
    public class RoomData
    {
        private float fineDust;//방의 농도
        private float degree;//방의 온도
        private bool lightonoff;
        public RoomData() { 
            fineDust = 0;//여기에 미세먼지 농도 설정 부탁
            degree = 36.5f;
            lightonoff = false;
        }
        public void setFineDust(float setting)
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
        public float getFineDust()
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
