using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;
using System.Text.RegularExpressions;

namespace kontrolle
{
    public class Program

    {
        static void Main(string[] args)

        {
            string zahl = "";
            string _kontrolle = "";

            Console.WriteLine("Gib die nummer ein und die muss 13 stellen haben und beginnen mit 1101 ");
            zahl = Console.ReadLine();
            Console.WriteLine("du hast die nummer "+ (zahl)+ " eingegeben");

            Regex check = new Regex("^(1101)[0-9]{9}$");
            Match match = check.Match(zahl);
            if (match.Success)
            {
                _kontrolle = zahl;
                Console.WriteLine("Die nummer ist richtig " + (_kontrolle) + " und hat 13 stellen");
            }
            else
            {
                Console.WriteLine("Die nummer " + (zahl) + " ist nicht 13 Stellig !!! bitte noch");
            }


            Console.ReadLine();

        }






    }
}