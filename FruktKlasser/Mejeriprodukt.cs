using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Security.Cryptography;
using System.Security.Cryptography.X509Certificates;
using System.Text;
using System.Threading.Tasks;

namespace Frukt_Klasser_Uppgift
{
    class Mejeriprodukt
    {
        //definition av variablerna
        string namn, form, utgång, procentenFett, laktozfriVarde;

        readonly string[] MejeriproduktFrogor = { "Mejeriprodukt namn:  ", "I vilken form? (fast eller flytande)  ", "Antal användbara dagar:   ", "FettProcent:  ", "Laktozfri:  (Ja eller nej)  " };
        readonly string[] MejeriproduktSvarar = new string[5];

        ////// konstruktor 
        public Mejeriprodukt(string mejeriproduktsNamn, string mejeriproduktsForm, string fruktsAntalAnvändbaraDagar,
             string mejeriproduktsProcentFett, string mejeriproduktsLaktozfri)
        {
            namn = mejeriproduktsNamn;
            form = mejeriproduktsForm;
            utgång = fruktsAntalAnvändbaraDagar;
            procentenFett = mejeriproduktsProcentFett;
            laktozfriVarde = mejeriproduktsLaktozfri;

        }

        public void SkapaMejeriproduktTavlan()
        {
            string path = "Mejeriprodukter.txt";

            using (StreamWriter streamWriter = File.CreateText(path)) { }


            using (StreamWriter streamWriter = File.AppendText(path))
            {
                string minText = "\t__________________________| Välkommen till mejeriprodukt fabriken! |__________________________________";

                streamWriter.WriteLine(minText);

                Mejeriprodukt smor = new Mejeriprodukt(" smör ", "fast", "12", "2.5", "ja");

                streamWriter.WriteLine("-" + smor.MejeriproduktText());

                Mejeriprodukt grädde = new Mejeriprodukt("grädde", "fast", "16", " 5.5", "ja");

                streamWriter.WriteLine("-" + grädde.MejeriproduktText());

                Console.WriteLine();

            }
        }

        public void VissaMejeriproduktTavlan()
        {
            string path = "Mejeriprodukter.txt";

            using (StreamReader streamReader = File.OpenText(path))
            {
                string fileText = "";
                while ((fileText = streamReader.ReadLine()) != null)
                {
                    Console.WriteLine(fileText);
                }
            }
        }

        public void MejeriprodukAddera()
        {
            string pathRut = "Mejeriprodukter.txt";


            using (StreamWriter streamWriter = File.AppendText(pathRut))
            {

                for (int i = 0; i < 5; i++)
                {
                    Console.Write(MejeriproduktFrogor[i] + "  ");

                    MejeriproduktSvarar[i] = Console.ReadLine();

                }


                Mejeriprodukt ob101 = new Mejeriprodukt(MejeriproduktSvarar[0], MejeriproduktSvarar[1], MejeriproduktSvarar[2], MejeriproduktSvarar[3], MejeriproduktSvarar[4]);

                streamWriter.WriteLine("-" + ob101.MejeriproduktText());

            }

            Program obj90 = new Program();
            obj90.ObjektHarLagtsTill();
        }

        private string MejeriproduktInfo()
        {
            string mejeriproduktInfo;

            mejeriproduktInfo = "Mejeriprodukt namn: " + namn + " | i form: " + form + " | Antal användbara dagar: " + utgång + " | FettProcent: " + procentenFett + "%  | Laktozfri: " + laktozfriVarde;
            return mejeriproduktInfo;
        }
        public string MejeriproduktText()
        {
            string publicmejeriproduktInfo;
            publicmejeriproduktInfo = MejeriproduktInfo();
            return publicmejeriproduktInfo;
        }
    }
}

