using System;
using System.Collections.Generic;
using System.Text;

namespace TP2_Code
{
    class Hygrometre : Sensor
    {
        System.Random rand = new Random();
        public string SensorID { get {return SensorID; } set { } }

        public enum Unite { pourcentage, gBym3 };

        public enum Type { humidite };
        public Unite UniteMesure { get { return UniteMesure; } set { } }
        public Type TypeMesure { get { return TypeMesure; } set { } }

        public double SensorValue
        {
            get
            {
                return new double();
            }
            set
            { }
        }

        public Hygrometre(string name, Unite unite)
        {
            SensorID = name;
            UniteMesure = unite;
            TypeMesure = Type.humidite;
        }

        public void updateSensor()
        {
            var rand = new Random();
            SensorValue = rand.Next(101);
        }
    }
}
