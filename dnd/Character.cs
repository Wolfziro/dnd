using System;
using static System.Console;
namespace dnd
{
    class Character
    {
        static void Main(string[] args)
        {
            // Class objects
            Name N = new Name();
            Class C = new Class();
            Race R = new Race();
            Stats S = new Stats();

            // set name, race, and class
            string n = N.name();
            string r = R.races();
            string c = C.clases();

            // roll stats
            S.sRolls();

            // set each stat to a var
            int hitpoints = S.hitpoints;
            int strength = S.strength;
            int dexterity = S.dexterity;
            int constitution = S.constitution;
            int wisdom = S.wisdom;
            int intelligence = S.intelligence;
            int charisma = S.charisma;
        }
    }

    class Name
    {
        public string name()
        {
            // Ask for name of character
            WriteLine("Enter the name of your character: ");
            string n = ReadLine();

            // check for certain names for an easter egg
            if(n.Contains("Vin"))
            {
                WriteLine("Mommy");
            }
            else if(n.Contains("Carson"))
            {
                WriteLine("Nice cat pants");
            }
            else if(n.Contains("Bert"))
            {
                WriteLine("Flex for me bb<3");
            }
            else if(n.Contains("Dalton"))
            {
                WriteLine("You're trash at apex");
            }
            else if(n.Contains("Colin"))
            {
                WriteLine("Get mental help");
            }
            else if(n.Contains("Ricky"))
            {
                WriteLine("Hi dad");
            }
            else if(n.Contains("Aj"))
            {
                WriteLine("Cutie<3");
            }
            else if(n.Contains("Kade"))
            {
                WriteLine("Ask me out please please please please please please please please please please please please please please please");
            }
            else
            {
                WriteLine("Hello {0}", n);
            }
            return n;
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
            while(!race.Equals(Races[0]) && !race.Equals(Races[1]) && !race.Equals(Races[2]) && !race.Equals(Races[3]))
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
            while(!c.Contains(cS[0]) && !c.Contains(cS[1]) && !c.Contains(cS[2]) && !c.Contains(cS[3]))
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
        public void sRolls()
        {
            // class object for berts dice class
            Dice roll = new Dice();

            // roll for each of the six stats
            public int hitpoints = 20;
            public int strength = roll.D20();
            public int dexterity = roll.D20();
            public int constitution = roll.D20();
            public int wisdom = roll.D20();
            public int intelligence = roll.D20();
            public int charisma = roll.D20(); 
        }
    }
}
