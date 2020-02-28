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
            Dictionary<string, object> DicoFinal = new MyJson();

            Console.WriteLine("Hello World!");

            List<DateTime> datesTest = new List<DateTime>();
            datesTest.Add(new DateTime(2019, 10, 31));

            Animal Bleriot = new Chat("Marie", "Angorra", Chat.CouleursYeux.Bleu, Chat.TypePoil.Long, datesTest);
            Console.WriteLine(Bleriot.age);
            Bleriot.age = 1;

            //DicoFinal.Add("chat1",Bleriot);
            

            //Console.WriteLine(DicoFinal["chat1"].ToString() );
            //(DicoFinal as MyJson).JsonSerialize(Bleriot);

            Console.ReadKey();

        }


        public class MyJson : Dictionary<string, object>
        {

            public MyJson(): base (new Dictionary<string, object>())
            {

            }
            public void JsonSerialize(object a)
            {
                Type leType = a.GetType();
                FieldInfo[] myFieldInfo = leType.GetFields(BindingFlags.NonPublic | BindingFlags.Instance| BindingFlags.Public);
                
                for(int i = 0; i<myFieldInfo.Length; i++)
                {
                    if (myFieldInfo[i].IsPublic)
                    {
                        this.Add(myFieldInfo[i].Name, myFieldInfo[i].FieldType);
                    }
                    else
                    {
                        if(myFieldInfo[i].IsPrivate)
                        {
                            this.Add(myFieldInfo[i].Name, myFieldInfo[i].FieldType);
                        }
                        else
                        {
                            Type b = myFieldInfo[i].GetType();
                            if (b is System.Collections.IEnumerable || b is System.Array)
                            {
                                this.Add(myFieldInfo[i].Name, myFieldInfo[i].FieldType);
                            }
                        }
                    }

                }
                myFieldInfo.ToString();
                

                //this.Add(myFieldInfo[0].Name, myFieldInfo[0].FieldType);
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
