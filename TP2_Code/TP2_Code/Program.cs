﻿using System;
using System.Collections.Generic;
using System.IO;
using System.Reflection;

namespace TP2_Code
{
    class Program
    {
        static void Main(string[] args)
        {
            //Exo1();
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

            //DicoFinal.Add("chat1",Bleriot);


            //Console.WriteLine(DicoFinal["chat1"].ToString() );
            //(DicoFinal as MyJson).JsonSerialize(Bleriot);
        }

        static void Exo2()
        {

        }

    }
}
