using System;
using System.Collections.Generic;
using System.Text;

namespace TP2_Code
{
    public class Thermometre : Sensor
    {
        public string SensorID { get => throw new NotImplementedException(); set => throw new NotImplementedException(); }
        public double SensorValue { get => throw new NotImplementedException(); set => throw new NotImplementedException(); }

        public enum Unite {celsius, fahrenheit };

        public enum Type { temperature};
        public Unite UniteMesure { get { return UniteMesure; } }
        public Type TypeMesure { get { return TypeMesure; } }

    }
}
