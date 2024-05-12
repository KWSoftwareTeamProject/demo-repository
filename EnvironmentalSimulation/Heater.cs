using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EnvironmentalSimulation
{
    public class Heater
    {
        private RoomData room;
        private float temp;
        private bool power;

        public Heater(RoomData room)
        {
            this.room = room;
            temp = room.getDegree();
            power = false;
        }

        public float GetDegree()
        {
            return (float)temp;
        }
    }
}
