using System;
using System.Collections;
using System.Collections.Generic;
using System.Text;

namespace TP2_Code
{
    class SensorDirector
    {
        private ArrayList Capteurs = new ArrayList();

        public SensorDirector() { }

        public void addSensor(Sensor entree)
        {
            Capteurs.Add(entree);
        }

        public Sensor deleteSensor(string id)
        {
            foreach(Sensor i in Capteurs)
            {
                if(i.SensorID == id)
                {
                    Capteurs.Remove(i);
                    return i;
                }
            }
            return null;
        }

        public void updateSensorValues()
        {
            var rand = new Random();
            foreach(Sensor i in Capteurs)
            {
                i.updateSensor();
            }
        }
    }
}
