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

            // set name, race, and class
            string n = N.name();
            string r = R.races();
            string c = C.clases();

            // roll stats
            //S.sRolls();

            // set each stat to a var
            WriteLine("Press Enter to roll for stats: ");
            ReadLine();
            Dice roll = new Dice();
            int hitpoints = 20;
            int strength = roll.D20();
            int dexterity = roll.D20();
            int constitution = roll.D20();
            int wisdom = roll.D20();
            int intelligence = roll.D20();
            int charisma = roll.D20();

            WriteLine("Strength: {0}", strength);
            WriteLine("Dexterity: {0}", dexterity);
            WriteLine("Constitution: {0}", constitution);
            WriteLine("Wisdom: {0}", wisdom);
            WriteLine("Intelligence: {0}", intelligence);
            WriteLine("Charisma: {0}", charisma);

            ReadLine();
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
            if (n.Contains("Vin"))
            {
                WriteLine("Mommy");
            }
            else if (n.Contains("Carson"))
            {
                WriteLine("Nice cat pants");
            }
            else if (n.Contains("Bert"))
            {
                WriteLine("Flex for me bb<3");
            }
            else if (n.Contains("Dalton"))
            {
                WriteLine("You're trash at apex");
            }
            else if (n.Contains("Colin"))
            {
                WriteLine("Get mental help");
            }
            else if (n.Contains("Ricky"))
            {
                WriteLine("Hi dad");
            }
            else if (n.Contains("Aj"))
            {
                WriteLine("Cutie<3");
            }
            else if (n.Contains("Kade"))
            {
                WriteLine("Ask me out please please please please please please please please please please please please please please please");
            }
            else if(n.Contains("Devin"))
            {
                WriteLine("Germany's favorite child");
            }
            else if(n.Contains("Aaron"))
            {
                WriteLine("If you bring up val one more time istg");
            }
            else if(n.Contains("Ava"))
            {
                WriteLine("Amogus");
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
            string[] Races = { "Gnome", "Human", "Orc", "Elf" };

            // Ask user for race
            WriteLine("Enter a race: ");
            string race = ReadLine();

            // Check if the race is valid
            while (!race.Equals(Races[0]) && !race.Equals(Races[1]) && !race.Equals(Races[2]) && !race.Equals(Races[3]))
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
            string[] cS = { "Paladin", "Rogue", "Wizard", "Barbarian" };
            // Ask user for their class
            WriteLine("Enter a class: ");
            string c = ReadLine();

            // Check if inputed class is valid
            while (!c.Contains(cS[0]) && !c.Contains(cS[1]) && !c.Contains(cS[2]) && !c.Contains(cS[3]))
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
}
//creating the class for the dice roll
public class Dice
{

    //creating the method for rolling

    //creating the random object
    Random rand = new Random();
    public int num;
    //the 20 sided dice
    public int D20()
    {
        num = rand.Next(20);
        return num;
    }

    //the 12 sided dice
    public int D12()
    {
        num = rand.Next(12);
        return num;
    }

    //the 10 sided dice
    public int D10()
    {
        num = rand.Next(10);
        return num;
    }

    //8 sided dice
    public int D8()
    {
        num = rand.Next(8);
        return num;
    }

    //the 6 sided dice
    public int D6()
    {
        num = rand.Next(6);
        return num;
    }

    //the 4 sided dice
    public int D4()
    {
        num = rand.Next(4);
        return num;
    }
}

