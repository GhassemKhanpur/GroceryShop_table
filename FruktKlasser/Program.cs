using Frukt_Klasser_Uppgift;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Frukt_Klasser_Uppgift
{
    class Program
    {
        //Huvudprogrammet
        static void Main()
        {
            StandardTavlan();//kalla på metoden 
        }

        static void StartaIgen() //metoden som vissa alla elementer och fråger för att addera elementer(frukter & mejeriprodukter)
        {
            Console.Clear(); //rensa skärmen

            ////Console.SetCursorPosition(0, 0);

            ////////////////////////////////Frukt/////////////////////////////

            //visa standard textfilen med 2 elementer av frukter
            Frukt objekt10 = new Frukt("", "", "", "", "", "");
            objekt10.VissaFruktTavlan();
            

            //////////////////////////////Mejeriprodukt//////////////////////////

            //visa standard textfilen med 2 elementer av Mejeriprodukter
            Mejeriprodukt objekt20 = new Mejeriprodukt("", "", "", "", "");
            objekt20.VissaMejeriproduktTavlan();
            

            ValAlternativ();//vissa alternativen på välj att addera 1 frukt eller 1 Mejeriprodukt

        }
        static void StandardTavlan()
        {
            Console.Clear(); //Rensa skärmen

            Console.SetCursorPosition(0, 0);

            ////////////////////////////////Frukt/////////////////////////////
            Frukt objekt10 = new Frukt("", "", "", "", "", "");
            string path = "Frukter.txt";
            if (File.Exists(path))//skapa frukt standard texfilen om det finns 
            {
                objekt10.VissaFruktTavlan();//visa standard textfilen med 2 elementer av frukter

            }
            else
            {
                objekt10.SkapaFruktTavlan();
                objekt10.VissaFruktTavlan();//visa standard textfilen med 2 elementer av frukter
            }


            //////////////////////////////Mejeriprodukt//////////////////////////

            Mejeriprodukt objekt20 = new Mejeriprodukt("", "", "", "", "");

            string path1 = "Mejeriprodukter.txt";
            if (File.Exists(path1))//skapa Mejeriprodukt standard texfilen om det finns inte
            {
                objekt20.VissaMejeriproduktTavlan();//vissa standard textfilen om 2 elementer av Mejeriprodukter

            }
            else
            {
                objekt20.SkapaMejeriproduktTavlan();
                objekt20.VissaMejeriproduktTavlan();
            }

            ValAlternativ();//vissa alternativen på välj att addera 1 frukt eller 1 Mejeriprodukt

        }

        ///////////////////////////////////Menyn//////////////////////////////////

        static void ValAlternativ()//visaa alternativ att välja addera en frukt eller en mejeriprodukt
        {

            Console.ForegroundColor = ConsoleColor.White;//Byta färg 
            Console.WriteLine("\t______________________________________________________________________________________________________\t");

            Console.ResetColor();

            bool value = true;
            while (value == true)
            {
                Console.ForegroundColor = ConsoleColor.Blue;//Byta färg
                Console.WriteLine(" F = lägga til en frukt\t  M = lägga til en mjölkprodukt\tA = Avsluta programmet \t R = återställ till standardfilen");

                Console.ResetColor();

                string ValdeTangent = Console.ReadLine();
                if (ValdeTangent == "F")
                {
                    Frukt obj45 = new Frukt("", "", "", "", "", "");
                    obj45.FruktAddera();


                    StartaIgen();

                    value = false;
                }
                else if (ValdeTangent == "f")
                {
                    Frukt obj46 = new Frukt("", "", "", "", "", "");
                    obj46.FruktAddera();


                    StartaIgen();

                    value = false;
                }
                else if (ValdeTangent == "M")
                {
                    Mejeriprodukt obj47 = new Mejeriprodukt("", "", "", "", "");
                    obj47.MejeriprodukAddera();


                    StartaIgen();

                    value = false;
                }
                else if (ValdeTangent == "m")
                {
                    Mejeriprodukt obj48 = new Mejeriprodukt("", "", "", "", "");
                    obj48.MejeriprodukAddera();

                    StartaIgen();

                    value = false;
                }
                else if (ValdeTangent == "A")
                {
                    Console.ForegroundColor = ConsoleColor.Red;//Byta färg
                    Console.WriteLine("Programmet kommaer att avslutas. Tryck Enter!");
                    Environment.Exit(0);
                }
                else if (ValdeTangent == "a")
                {
                    Console.ForegroundColor = ConsoleColor.Red;//Byta färg
                    Console.WriteLine("Programmet kommaer att avslutas. Tryck Enter!");
                    Environment.Exit(0);
                }
                else if (ValdeTangent == "R")
                {
                    File.Delete("Frukter.txt");
                    File.Delete("Mejeriprodukter.txt");
                    StandardTavlan();
                }
                else if (ValdeTangent == "r")
                {
                    File.Delete("Mejeriprodukter.txt");
                    File.Delete("Frukter.txt");
                    StandardTavlan();
                }
                else
                {
                    Console.WriteLine("Skriv rätt bokstaven");
                }
            }
        }
        public void ObjektHarLagtsTill()
        {
            Console.ForegroundColor = ConsoleColor.Red;//Byta färg
            Console.Write("Objekt ");
            System.Threading.Thread.Sleep(500);
            Console.Write("Har ");
            System.Threading.Thread.Sleep(500);
            Console.Write("lagts ");
            System.Threading.Thread.Sleep(500);
            Console.Write("till.\n");
            Console.Write("________________________________");
            System.Threading.Thread.Sleep(500);
            Console.Write("________________________________");
            System.Threading.Thread.Sleep(500);
            Console.Write("________________________________");
            System.Threading.Thread.Sleep(500);
            Console.Write("_______________");
            System.Threading.Thread.Sleep(1000);

            Console.ResetColor();

        }
    }
}
