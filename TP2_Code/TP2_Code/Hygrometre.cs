using System;
using System.Collections.Generic;
using System.Text;

namespace TP2_Code
{
    class Hygrometre : Sensor
    {
        System.Random rand = new Random();
        public string SensorID { get; set; }
        public double SensorValue { get; set; }
        public Unite SensorUnity { get; set; }
        public TypeCapteur typeCapteur { get; set; }

        TypeCapteur Capteurtype = TypeCapteur.humidite;
        


        public Hygrometre(string name, Unite unite)
        {
            SensorID = name;
            SensorValue = 0;
            SensorUnity = unite;
            typeCapteur = TypeCapteur.humidite;

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
