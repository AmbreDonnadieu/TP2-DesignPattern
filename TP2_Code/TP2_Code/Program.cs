using System;
using System.Collections.Generic;
using System.IO;
using System.Reflection;

namespace TP2_Code
{
    class Program
    {
        static void Main(string[] args)
        {
            Exo1();
            Exo2();

            Console.ReadKey();

        }

        static void Exo1()
        {
            Dictionary<string, object> DicoFinal = new MyJson();

            Console.WriteLine("Hello World!");

            List<DateTime> datesTest = new List<DateTime>();
            datesTest.Add(new DateTime(2019, 10, 31));

            Animal Bleriot = new Chat("Marie", "Angorra", Chat.CouleursYeux.Bleu, Chat.TypePoil.Long, datesTest);
            Console.WriteLine(Bleriot.age);
            Bleriot.age = 1;

            (DicoFinal as MyJson).JsonSerialize(Bleriot);

            foreach(KeyValuePair<string, object> key in DicoFinal)
            {
                Console.Write(key.Key.ToString() + " : " + key.Value.ToString() + "\n");
            }
            
        }

        static void Exo2()
        {
            Thermometre th = new Thermometre("th1", Thermometre.Unite.celsius);
            Hygrometre hy = new Hygrometre("hy1", Hygrometre.Unite.pourcentage);
            SensorDirector sd = new SensorDirector();
            sd.addSensor(th);
            sd.addSensor(hy);
            sd.updateSensorValues();
            Visualizer vs = new Visualizer();
            vs.ShowSensor(th);
            Console.WriteLine("coucou \n");

        }

    }
}
