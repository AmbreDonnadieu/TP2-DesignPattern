﻿using System;
using System.Collections.Generic;
using System.IO;


namespace TP2_Code
{
    class Program
    {
        //note : le fichier json utilisé pour les tests du projet a été pris du site suivant :
        // https://support.oneskyapp.com/hc/en-us/articles/208047697-JSON-sample-files

        Dictionary<string, Object> DicoFinal = new Dictionary<string, object>();

        static void Main(string[] args)
        {
            Console.WriteLine("Hello World!");

            string pathJson = "Jsontest.json";

            bool existance = File.Exists(pathJson);

            //string text = System.IO.File.ReadAllText("Jsontest.json");

            // Display the file contents to the console. Variable text is a string.
            //System.Console.WriteLine("Contents of WriteText.txt = {0}", text);

            Console.WriteLine(existance);

            Console.ReadKey();

        }


        //JSONSerialize(jsonfile)
        // 1- récupère tous les json objects simple (int, char etc + string)
        // 2- récupère les membres privés 
        // 3- récupère les sous-objets sauf tableaux et IEnumarable
        // 4- récupère les tableaux et IEnumerable

        // a- parcourir le fichier json comme un arbre
        // b- à chaque noeud, tu checks les conditions ci-dessus pour voir si tu l'ajoutes au dico ou non
        //en gros, on veut convertir un fichier json en dictionary <string, object>
    }
}
