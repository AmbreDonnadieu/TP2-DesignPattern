using System;
using System.Collections.Generic;
using System.IO;


namespace TP2_Code
{
    class Program
    {
        //note : le fichier json utilisé pour les tests du projet a été pris du site suivant :
        // https://support.oneskyapp.com/hc/en-us/articles/208047697-JSON-sample-files

        Dictionary<string, Type> DicoFinal;

        static void Main(string[] args)
        {
            Console.WriteLine("Hello World!");

            string pathJson = "Jsontest.json";

            bool existance = File.Exists(pathJson);

            Console.WriteLine(existance);


            Console.ReadKey();

        }


        //JSONSerialize(jsonfile)
        // 1- récupère tous les json objects simple (int, char etc + string)
        // 2- récupère les membres privés 
        // 3- récupère les sous-objets sauf tableaux et IEnumarable
        // 4- récupère les tableaux et IEnumerable


    }
}
