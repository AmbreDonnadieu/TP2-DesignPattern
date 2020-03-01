using System;
using System.Collections.Generic;
using System.Text;

namespace TP2_Code
{
    public class Thermometre : Sensor
    {
        public string SensorID { get { return SensorID; } set { } }

        public enum Unite {celsius, fahrenheit };

        public enum Type { temperature};
        public Unite UniteMesure { get { return UniteMesure; } }
        public Type TypeMesure { get { return TypeMesure; } set { TypeMesure = Type.temperature; } }

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

        public Thermometre(string id)
        {
            SensorID = id;
        }

        public void updateSensor()
        {
            var rand = new Random();
            SensorValue = rand.Next(101);
        }
    }
}
