using System;
using System.Collections.Generic;
using System.Globalization;
using System.IO;
using System.Linq;
using System.Runtime.InteropServices;
using System.Text;
using System.Threading.Tasks;

namespace Frukt_Klasser_Uppgift
{
    //klassdefinition av frukt
    public class Frukt
    {
        //definition av variablerna
         string namn, farg, kcal, pris, atbarVarde, skalVarde;

        readonly string[] svarar = new string[6];

        readonly string[] frogor = { "Fruktnamn   :", "Färg:   ", "Hur mycket energi den har(Kcal)?  ", "Frukt pris:  ", "Har ätbar? (Ja eller nej)   ", "Har Skal?  (Ja eller nej)  " };

        // konstruktor       
        public Frukt(string fruktsNamn, string fruktsFarg, string fruktKcal, string fruktPris, string frukAtbarVarde, string fruktSkalVarde)
        {
            namn = fruktsNamn;
            farg = fruktsFarg;
            kcal = fruktKcal;
            pris = fruktPris;
            atbarVarde = frukAtbarVarde;
            skalVarde = fruktSkalVarde;

        }

        public void SkapaFruktTavlan()
        {
            string path = "Frukter.txt";

            using (StreamWriter streamWriter = File.CreateText(path)) { }

            using (StreamWriter streamWriter = File.AppendText(path))
            {

                string minText = "\t_________________________________| Välkommen till frukt fabriken! |__________________________________";

                streamWriter.WriteLine(minText);

                Frukt päron = new Frukt("  päron  ", "gul", "12.5", "150.50", "nej", "ja");
                streamWriter.WriteLine("-" + päron.FruktTextExempel());


                Frukt jordgubbe = new Frukt("jordgubbe", "röd", "15.5", "120.50", "ja", "nej");
                streamWriter.WriteLine("-" + jordgubbe.FruktTextExempel());

                Console.WriteLine();

            }

        }
        public void VissaFruktTavlan()
        {
            Console.WriteLine();

            string path = "Frukter.txt";

            using (StreamReader streamReader = File.OpenText(path))
            {
                string fileText = "";
                while ((fileText = streamReader.ReadLine()) != null)
                {
                    Console.WriteLine(fileText);
                }
            }
            Console.WriteLine();
        }
        public void FruktAddera()
        {
            string pathRut = "Frukter.txt";

            using (StreamWriter streamWriter = File.AppendText(pathRut))
            {

                for (int i = 0; i < 6; i++)
                {
                    Console.Write(frogor[i] + "  ");

                    svarar[i] = Console.ReadLine();
                }

                Frukt ob100 = new Frukt(svarar[0], svarar[1], svarar[2], svarar[3], svarar[4], svarar[5]);

                streamWriter.WriteLine("-" + ob100.FruktTextExempel());

            }

            Program obj90 = new Program();
            obj90.ObjektHarLagtsTill();

        }
        private string FruktInfoExempelTavlan()
        {
            string fruitInfo;
            fruitInfo = "Fruktnamn: " + namn + " | färg: " + farg + " | Kcal: " + kcal + " kilo kalorier. | Frukt pris " + pris + " kr. | har ätbar " + atbarVarde + " | har Skal: " + skalVarde;
            return fruitInfo;
        }

        public string FruktTextExempel()
        {
            string publicFruitInfo;

            publicFruitInfo = FruktInfoExempelTavlan();
            return publicFruitInfo;
        }

    }
}




