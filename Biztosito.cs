using System;
using System.IO;
using System.Collections.Generic;



namespace Biztosito
{
    class Biztosito
    {
        static List<Szerzodes> szerzodesek;


        static void Main(string[] args)
        {
        //1. feladat
            szerzodesek = new List<Szerzodes>();


        //2. feladat
            string fajlNev = @"./szerzodesek.txt";

            fajlBeolvasas(fajlNev);


        //3. feladat
            int noTulajdonosDB = noTulajdonos();

            Console.WriteLine($"3. feladat: Az ügyfelek közül {noTulajdonosDB} db a nő.\n");


        //4/A. feladat





        //4/B. feladat






        //4/C. feladat





        //5/A. feladat





        //5/B. feladat






        //5/C. feladat




        //6/A. feladat





    












        }



        public static void fajlBeolvasas(string fajl) {

            try
            {
                using(StreamReader olvaso = new StreamReader(fajl)) {

                    olvaso.ReadLine();

                    while(!olvaso.EndOfStream) {

                        string[] darabok = olvaso.ReadLine().Split(";");

                        Szerzodes sz = new Szerzodes(
                            darabok[0],
                            darabok[1],
                            Convert.ToBoolean(darabok[2]),
                            darabok[3],
                            Convert.ToBoolean(darabok[4]),
                            Convert.ToInt32(darabok[5])
                        );

                        szerzodesek.Add(sz);
                    }
                } 
            }
            catch (IOException e)
            {
                Console.WriteLine($"Fájl megnyitási hiba!: + {e.Message}");
            }

            //Console.WriteLine($"Lista mérete: {szerzodesek.Count}");
        }


        public static int noTulajdonos() {

            int db = 0;

            for (int i = 0; i < szerzodesek.Count;i++)
            {
                if (szerzodesek[i].getUgyfelNeme() == true)
                {
                    db++;
                }    
            }

            return db;
        }












    }
}


