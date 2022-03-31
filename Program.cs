using System;
using PROJETO_JOGO_RPG.CRC.Entities;

namespace PROJETO_JOGO_RPG.CRC.Entities
{
    class Program
    {
        static void Main(string[] args)        
        
        {
            Knight knight = new Knight("Arus", 23, "Knight");
            Wizard wizard = new Wizard("Jennica", 23, "White wizard");
            Wedge wedge = new Wedge("Wedge", 23, "Ninja");
            Topapa topapa = new Topapa("Topapa", 23, "Black wizard");

            Console.WriteLine(knight.Attack());
            Console.WriteLine(wizard.Attack());
            Console.WriteLine(wedge.Attack());
            Console.WriteLine(topapa.Attack());


        }
    }
}

