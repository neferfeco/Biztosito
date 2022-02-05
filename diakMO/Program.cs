using System;
using System.IO;
using System.Collections.Generic;

namespace Jarmubiztosito
{
    class Program
    {
        //1. feladat
        static List<Szerzodes> szerzodes;

        static void Main(string[] args)
        {

            //2. feladat

            szerzodes = new List<Szerzodes>();

            string fajlnev = "@szerzodesek.txt";

        }
        //2. feladat
        public static void beolvas(string fajl)
        {
            try
            {
                using (StreamReader olv = new StreamReader(fajl))
                {
                    olv.ReadLine();

                    while (!olv.EndOfStream)
                    {
                        string[] t = olv.ReadLine().Split(";");

                        Szerzodes sz = new Szerzodes(t[0], t[1], t[2], t[3], t[4], t[5], t[6]);
                    }
                }
            }
            catch (IOException e)
            {
                Console.WriteLine($"Fájl olvasási hiba: {e.Message}");
            }
        }

     //3. feladat
     public static void noi(string fajl)
     {
            for (int i = 0; i< szerzodes.Count; i++)
            {
                
            }
        }
    }
}
