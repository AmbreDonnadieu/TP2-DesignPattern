using System;
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
            bool existance = File.Exists("Jsontest.json");
            
            Console.WriteLine(existance);


            //lire le json ici
            string typeJson = new string("pomme");
            char[] chars = new char[] { 'm', 'a', 'm', 'a' };
            object json = Activator.CreateInstance(typeJson.GetType(), new Object[] { chars} ) ;
            
            
            Console.WriteLine(json.GetType().ToString() +" : " + json.ToString());


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
            string nom;
            int age;
            string race;
            enum CouleursYeux{ Bleu, Jaune, marron, vert};
            enum TypePoil {  Long, court, ras};
            List<DateTime> DatesVaccination;
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
