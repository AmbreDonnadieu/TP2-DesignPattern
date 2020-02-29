using System;
using System.Collections.Generic;
using System.Text;
using System.Reflection;

namespace TP2_Code
{
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

        public Chat(string nom, string race, CouleursYeux yeux, TypePoil poil, List<DateTime> Vaccination) : base(0)
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
    public class MyJson : Dictionary<string, object>
    {

        public MyJson() : base(new Dictionary<string, object>())
        {

        }
        public void JsonSerialize(object a)
        {
            Type leType = a.GetType();
            FieldInfo[] myFieldInfo = leType.GetFields(BindingFlags.NonPublic | BindingFlags.Instance | BindingFlags.Public);

            // On ajoute les informations de type primitif (int, char, string, etc...)
            for (int i = 0; i < myFieldInfo.Length; i++)
            {
                if (myFieldInfo[i].FieldType.IsPrimitive
                    && (myFieldInfo[i].IsPublic || myFieldInfo[i].IsPrivate))
                {
                    Add(myFieldInfo[i].Name, myFieldInfo[i].Attributes);
                }

            }
            //On ajoute les informations de type objet qui ne sont ni primitif ni IEnumerable/tableau
            for (int i = 0; i < myFieldInfo.Length; i++)
            {
                if (!myFieldInfo[i].FieldType.IsPrimitive
                    && !(myFieldInfo[i].FieldType is System.Collections.IEnumerable || myFieldInfo[i].FieldType is Array)
                    && (myFieldInfo[i].IsPublic || myFieldInfo[i].IsPrivate))
                {
                    Add(myFieldInfo[i].Name, myFieldInfo[i]);
                }
            }

            // On ajoute les informations de type IEnumerable ou sous forme de tableau
            for (int i = 0; i < myFieldInfo.Length; i++)
            {
                if (myFieldInfo[i].FieldType is System.Collections.IEnumerable
                    || myFieldInfo[i].FieldType is Array
                    && (myFieldInfo[i].IsPublic || myFieldInfo[i].IsPrivate))
                {
                    Add(myFieldInfo[i].Name, myFieldInfo[i]);
                }
            }

        }

    }

}
