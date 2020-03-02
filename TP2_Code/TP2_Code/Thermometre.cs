using System;
using System.Collections.Generic;
using System.Text;

namespace TP2_Code
{
    public class Thermometre : Sensor
    {
        public string SensorID { get; set; }
        public double SensorValue { get; set; }
        public Unite SensorUnity { get; set; }
        public TypeCapteur typeCapteur{ get; set; }

        System.Random rand = new Random();
       
        public Thermometre(string id, Unite unite)
        {
            SensorID = id;
            SensorUnity = unite;
            SensorValue = 0;
            typeCapteur = TypeCapteur.temperature;
        }

        public void updateSensor()
        {
            var rand = new Random();
            SensorValue = rand.Next(101);
        }

        public override string ToString()
        {
            return "Capteur " + SensorID + " : " + SensorValue + " " + SensorUnity + ".";
        }
    }
}
