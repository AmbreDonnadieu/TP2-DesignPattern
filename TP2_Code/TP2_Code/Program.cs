﻿using System;
using System.Collections.Generic;
using System.IO;


namespace TP2_Code
{
    class Program
    {
        //note : le fichier json utilisé pour les tests du projet a été pris du site suivant :
        // https://support.oneskyapp.com/hc/en-us/articles/208047697-JSON-sample-files

        static Dictionary<string, Object> DicoFinal = new Dictionary<string, object>();

        static void Main(string[] args)
        {
            Console.WriteLine("Hello World!");

            List<DateTime> datesTest = new List<DateTime>();
            datesTest.Add(new DateTime(2019, 10, 31));

            Chat miaou = new Chat("Marie", 1, "Angorra", Chat.CouleursYeux.Bleu, Chat.TypePoil.Long, datesTest);

            object Poire = new object();
            Poire = "poire";
            DicoFinal.Add("fruit", Poire);
            foreach(KeyValuePair<string, object> obj in DicoFinal)
            {
                Console.WriteLine(obj.Key + " : " + obj.Value);
            }

            Console.ReadKey();

        }

        class Chat
        {
            public enum CouleursYeux { Bleu, Jaune, marron, vert };
            public enum TypePoil { Long, court, ras };

            public string nom;
            public int age;
            public string race;
            public CouleursYeux yeuxchat;
            public TypePoil poilchat;
            List<DateTime> DatesVaccination;

            public string Nom { get { return nom; } }  
            public int Age { get { return age; } }  
            public string Race { get { return race; } }  
            public CouleursYeux Yeux { get { return yeuxchat; } }  
            public TypePoil Poil { get { return poilchat; } }    
            List<DateTime> Vaccin { get { return DatesVaccination; } }

            public Chat(string nom, int age, string race, CouleursYeux yeux, TypePoil poil, List<DateTime> Vaccination)
            {
                this.nom = nom;
                this.race = race;
                yeuxchat = yeux;
                poilchat = poil;
                DatesVaccination = Vaccination;
            }

        }

        
    }
}
