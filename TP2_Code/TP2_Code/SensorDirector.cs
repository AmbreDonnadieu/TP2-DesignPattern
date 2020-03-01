using System;
using System.Collections;
using System.Collections.Generic;
using System.Text;
using System.Threading;

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
            foreach (Sensor i in Capteurs)
            {
                if (i.SensorID == id)
                {
                    Capteurs.Remove(i);
                    return i;
                }
            }
            return null;
        }

        public void updateSensorValues()
        {
            Thread thread = new Thread(Sense);
            thread.Start();
        }

        private void Sense()
        {
            int j = 0;
            while (j < 10)
            {
                foreach (Sensor i in Capteurs)
                {
                    i.updateSensor();
                    Thread.Sleep(1000);
                }
                j++;
            }
        }
    }
}
