using System;

namespace Lecture
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("200812 Lecture"); // sanity check

            Console.WriteLine("\nBase Character ---------------------------------");
            // create an instance of the DnDCharacter class and call availble methods
            DnDCharacter baseCharacter = new DnDCharacter("base character", 3, 7, 9);
            baseCharacter.OutputProps();
            baseCharacter.Attack();
            Console.WriteLine("--------------------------------------------------");
            
            Console.WriteLine("\nFighter Character ---------------------------------");
            // create an instance of the Fighter class and call availble methods
            Fighter fighter1 = new Fighter("fighter character", 2, 8, 6);
            fighter1.OutputProps();
            fighter1.Attack();
            // fighter1.Slash();
            fighter1.StockUp();
            fighter1.StockWeapons();
            Console.WriteLine("---------------------------------------------------");
            
            Console.WriteLine("\nWizard Character ---------------------------------");
            // create an instance of the Wizard class and call availble methods
            Wizard wizard1 = new Wizard("wizard character", 1, 10, 3, "casting awesome spells");
            wizard1.OutputProps();
            wizard1.Attack();
            wizard1.OutputMagic();
            // wizard1.Spell();
            wizard1.StockUp();
            wizard1.StockMagicItems();
            wizard1.StockMagicItems();
            wizard1.StockMagicItems();
            wizard1.RemoveFromInventory(2); // passing an integer calls the method that accepts an intger
            wizard1.RemoveFromInventory("cooked meat"); // passing a string calls the method that accepts a string
            Console.WriteLine("---------------------------------------------------");
        }
    }
}
