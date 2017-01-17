
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
namespace OLIO

{
	class Program
{
    static void Main(string[] args)
    {
        Console.Write("Anna viisi etunimeä ");

        // Luodaan array "nimet"
        string[] nimet = new string[5];

        // Otetaan käyttäjältä nimi viisi kertaa
        for (int i = 0; i < 5; i++)
        {
            nimet[i] = Console.ReadLine();
        }


        // Tulostetaan alkuperäisessä järjestyksessä
        Console.Write("Annoit nimet: ");

        for (int i = 0; i < 5; i++)
        {
            Console.Write(nimet[i] + " ");
        }

        //Enter
        Console.Write("\n");

        // Järjestää arrayn aakkosjärjestykseen:
        Array.Sort(nimet);

        // Tulostetaan array uudessa järjestyksessä:
        Console.Write("Nimet aakkosjärjestyksessä: ");

        for (int i = 0; i < 5; i++)
        {
            Console.Write(nimet[i] + " ");
        }

        //Enter
        Console.Write("\n");
    }
}
}
