using System;
using System.Collections.Generic;
using System.Text;

namespace TP2_Code
{
    class Hygrometre : Sensor
    {
        public string SensorID { get {return SensorID; } set { } }

        public enum Unite { pourcentage, gBym3 };

        public enum Type { humidite };
        public Unite UniteMesure { get { return UniteMesure; } set { } }
        public Type TypeMesure { get { return TypeMesure; } set { TypeMesure = Type.humidite; } }

        public double SensorValue
        {
            get
            {
                return SensorValue;
            }
            set
            {
                var rand = new Random();
                SensorValue = rand.Next(101);
            }
        }

        public Hygrometre(string name, Unite unite)
        {
            SensorID = name;
            UniteMesure = unite;
        }

        public void updateSensor()
        {
            var rand = new Random();
            SensorValue = rand.Next(101);
        }
    }
}
