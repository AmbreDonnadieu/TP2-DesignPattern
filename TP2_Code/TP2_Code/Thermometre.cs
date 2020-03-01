using System;
using System.Collections.Generic;
using System.Text;

namespace TP2_Code
{
    public class Thermometre : Sensor
    {
        System.Random rand = new Random();

        public string SensorID { get { return SensorID; } set { } }

        public enum Unite {celsius, fahrenheit };

        public enum Type { temperature};
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

        public Thermometre(string id, Unite unite)
        {
            SensorID = id;
            UniteMesure = unite;
            TypeMesure = Type.temperature;

        }

        public void updateSensor()
        {
            var rand = new Random();
            SensorValue = rand.Next(101);
        }
    }
}
