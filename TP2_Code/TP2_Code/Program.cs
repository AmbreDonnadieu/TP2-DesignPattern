using System;
using System.Collections.Generic;
using System.IO;


namespace TP2_Code
{
    class Program
    {//note : le fichier json utilisé pour les tests du projet a été pris du site suivant :
        // https://support.oneskyapp.com/hc/en-us/articles/208047697-JSON-sample-files


        static void Main(string[] args)
        {
            Dictionary<string, object> DicoFinal = new MyJson();

            Console.WriteLine("Hello World!");

            List<DateTime> datesTest = new List<DateTime>();
            datesTest.Add(new DateTime(2019, 10, 31));
            
            Animal Bleriot = new Chat("Marie","Angorra", Chat.CouleursYeux.Bleu, Chat.TypePoil.Long, datesTest);
            Console.WriteLine(Bleriot.age);
            Bleriot.age = 1;


            DicoFinal.Add("chat1",Bleriot);

            Console.WriteLine(DicoFinal["chat1"].ToString() );

            Console.ReadKey();

        }

        public class MyJson : Dictionary<string, object>
        {

            public MyJson(): base (new Dictionary<string, object>())
            {

            }
            public void JsonSerialize(object a)
            {

            }
            
        }


        public class Animal
        {
            public int age;
            public Animal(int age) { this.age = age; }
        }
        class Chat : Animal
        {
            public enum CouleursYeux { Bleu, Jaune, marron, vert };
            public enum TypePoil { Long, court, ras };

            public string nom;
            //public int age;
            public string race;
            public CouleursYeux yeuxchat;
            public TypePoil poilchat;
            List<DateTime> DatesVaccination;

            public string Nom { get { return nom; } }
           // public int Age { get { return age; } }
            public string Race { get { return race; } }
            public CouleursYeux Yeux { get { return yeuxchat; } }
            public TypePoil Poil { get { return poilchat; } }
            List<DateTime> Vaccin { get { return DatesVaccination; } }

            public Chat(string nom,  string race, CouleursYeux yeux, TypePoil poil, List<DateTime> Vaccination) : base(0)
            {
                this.nom = nom;
                this.race = race;
                yeuxchat = yeux;
                poilchat = poil;
                DatesVaccination = Vaccination;
            }

            public override string ToString()
            {
                string varia = "Le chat s'appelle " + Nom + " et il a " + age + " années.";
                return varia;
            }
        }


    }
}
