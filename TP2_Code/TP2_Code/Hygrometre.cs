using System;
using System.Collections.Generic;
using System.Text;

namespace TP2_Code
{
    class Hygrometre : Sensor
    {
        public string SensorID { get => throw new NotImplementedException(); set => throw new NotImplementedException(); }
        public double SensorValue { get => throw new NotImplementedException(); set => throw new NotImplementedException(); }

        public enum Unite { pourcentage, gParm3 };

        public enum Type { humidite };
        public Unite UniteMesure { get { return UniteMesure; } }
        public Type TypeMesure { get { return TypeMesure; } }
    }
}
