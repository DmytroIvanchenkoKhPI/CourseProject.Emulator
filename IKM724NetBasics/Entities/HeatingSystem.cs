using IKM724NetBasics.Entities.Sensors;
using IKM724NetBasics.Entities.Systems;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace IKM724NetBasics.Entities
{
    public class HeatingSystem
    {
        public List<Sensor> Sensors { get; set; }

        public HeatingSystem()
        {
            Sensors = new List<Sensor>();
        }

        public void Monitor()
        {
            foreach (var sensor in Sensors) 
            { 
                sensor.ReadValue(); 
            }
        }
    }
}