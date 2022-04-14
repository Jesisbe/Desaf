using System;
using Desaf.src.Entities;

namespace dotnet_pooo
{
    class Program
    {
        static void Main(string[] args)
        {     
            Knight arus = new Knight("Arus", 23, "Knight"); Wizard wizard = new Wizard("Jessica", 23, "White Wizard"); 
            Ninja ninja = new Ninja("Wedge", 23, "Ninja"); Blackwizard blackwisar = new Blackwizard("Topara", 23, "Blackwizard");
           
            
            Console.WriteLine(wizard.Attack(1));
            Console.WriteLine(wizard.Attack(7));
            Console.WriteLine(ninja.Attack(1));
            Console.WriteLine(ninja.Attack(7));
            Console.WriteLine(arus.Attack(1));
            Console.WriteLine(arus.Attack(7));
            Console.WriteLine(blackwisar.Attack(1));
            Console.WriteLine(blackwisar.Attack(7));
            

        }
    
    }

}
