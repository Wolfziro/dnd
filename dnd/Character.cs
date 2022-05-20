using System;
using static System.Console;
namespace dnd
{
    class Character
    {
        static void Main(string[] args)
        {
            Class Class = new Class();
            Class.clases();
            
        }
    }

    class Race
    {
        public string races()
        {
            // Array with 4 different races
            string[] Races = {"Gnome", "Human", "Orc", "Elf"};

            // Ask user for race
            WriteLine("Enter a race: ");
            string race = ReadLine();

            // Check if the race is valid
            if(race != Races[0] || race != Races[1] || race != Races[2] || race != Races[3])
            {
                WriteLine("Race is not valid. Valid races are Gnome, Human, Orc, and Elf");
                WriteLine("Enter a race: ");
                race = ReadLine();
            }

            // Return race
            return race;
        }
    }
    class Class
    {
        public string clases()
        {
            // Array with four different classes
            string[] cS = {"Paladin", "Rogue", "Wizard", "Barbarian"};

            // Ask user for their class
            WriteLine("Enter a class: ");
            string c = ReadLine();

            // Check if inputed class is valid
            while(c != cS[0] || c != cS[1] || c != cS[2] || c != cS[3])
            {
                // If class does not equal class in array ask for user input again
                WriteLine("Class is not valid. Valid classes are Paladin, Rogue, Wizard, and Barbarian");
                WriteLine("Enter a Class: ");
                c = ReadLine();
            }

            // return the class
            return c;
        }
    }
    class Stats
    {

    }
}
