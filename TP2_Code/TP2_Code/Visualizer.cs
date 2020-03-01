using System;
using System.Collections.Generic;
using System.Reflection;
using System.Text;

namespace TP2_Code
{
    class Visualizer
    {
        public Visualizer() { }

        public void ShowSensor(Sensor capteur)
        {
            Object a = capteur;
            Type leType = capteur.GetType();
            FieldInfo[] myFieldInfo = leType.GetFields(BindingFlags.NonPublic | BindingFlags.Instance | BindingFlags.Public);

            for (int i = 0; i < myFieldInfo.Length; i++)
            {
                var test = myFieldInfo[i].GetValue(a);
                string t = myFieldInfo[i].Name;
                Console.WriteLine(t);
                Console.WriteLine(test);

            }
        }
    }
}
