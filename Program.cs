using System;
using System.Reflection;

namespace Reflection_Exercises_0
{
    class Program
    {
        static void Main(string[] args)
        {
            string assemblyName = typeof(Program).Assembly.GetName().Name;

            while (true)
            {
                Console.Write("Enter enemy type (Goon, Warrior, Mage): ");
                string input = $"CSharpReflection."+Console.ReadLine();
                object obj = null;

                try
                {
                    // Dynamically creating an instance based on user input
                    obj = Activator.CreateInstance(assemblyName, input)?.Unwrap();

                    if (obj != null)
                    {
                        Console.WriteLine($"Created Successfully: {obj}");

                        switch (obj)
                        {
                            case Goon goon:
                                Console.WriteLine("Action: Goon is attacking with basic melee!");
                                break;

                            case Warrior warrior:
                                Console.WriteLine("Action: Warrior is using heavy sword slash!");
                                break;

                            case Mage mage:
                                Console.WriteLine("Action: Mage is casting a fire spell!");
                                break;

                            default:
                                Console.WriteLine("Action: Unknown enemy action.");
                                break;
                        }
                    }
                }
                catch
                {
                    Console.WriteLine($"Error: Class '{input}' not found or could not be created.");
                }

                Console.WriteLine(new string('-', 40));
            }
        }
    }

    public class Goon
    {
        public override string ToString()
        {
            return "( Goon -> Speed: 20, HitPower: 13, Strength: 7 )\n";
        }
    }

    public class Warrior
    {
        public override string ToString()
        {
            return "( Warrior -> Speed: 15, HitPower: 25, Strength: 30 \n)";
        }
    }

    public class Mage
    {
        public override string ToString()
        {
            return "( Mage -> Speed: 18, HitPower: 35, Strength: 10 \n)";
        }
    }
}