using System;
using System.Collections.Generic;
using System.Text;

namespace Food_Tracker
{
    public static class UserConsole
    {
        public static User ConsoleEnter()
        {
            try
            {
                Console.Write("Name: ");
                string name = Console.ReadLine();
                Console.Write("Age: ");
                int age = int.Parse(Console.ReadLine());
                Console.Write("Weight: ");
                int weight = int.Parse(Console.ReadLine());
                Console.Write("Height: ");
                int height = int.Parse(Console.ReadLine());
                Console.Write("Gender (Male or Female): ");
                string gender = Console.ReadLine();
                Console.Write("Goal (lose, maintain or gain): ");
                string goal = Console.ReadLine();
                Console.WriteLine("\t\t\t---------------------");
                Console.WriteLine($"\t\t\t Your info \n\t\t\t  Name: {name}, \n\t\t\t  Age: {age} years old\n\t\t\t  Weight: {weight} kg  \n\t\t\t " +
                    $" Height: {height} sm \n\t\t\t  Gender: {gender} \n\t\t\t  Goal: {goal} weight");
                Console.WriteLine("\t\t\t----------------------");


                return new User(name, age, weight, height, gender, goal);

                
            }
            catch (Exception)
            {
                throw;
            }
        }
    }
}
