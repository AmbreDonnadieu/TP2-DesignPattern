using System;
using System.Collections.Generic;
using System.Reflection;
using System.Text;

namespace TP2_Code
{
    public enum Unite { pourcentage, gBym3, celsius, fahrenheit, kelvin };
    public enum TypeCapteur { temperature, humidite };

    class Visualizer
    {
        SensorDirector SensorDirectorAll;
        IConvertisseur convertisseur;

        public Visualizer() { }

        public void ShowAllSensors(SensorDirector Allcapteur)
        {
            foreach(Sensor s in Allcapteur.Capteurs)
            {
                Console.WriteLine("Capteur " + s.SensorID + " : " + s.SensorValue + " " + s.SensorUnity + ".");
            }  
        }

        public void ShowOneSensor(Sensor s)
        {
            s.ToString();
        }
    }
}
