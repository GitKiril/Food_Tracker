
using System;
using System.Collections.Generic;
using System.Text;


namespace Food_Tracker
{
    public class UserProfile
    {
        public static void Strart()
        {
           
            // заповнення даних выд користувача
            Console.WriteLine("\t\t\t This is Food Tracker \nWrite your name, age, weight, height, gender (male or female), and your goal (lose, maintain, gain)");



            User user = UserConsole.ConsoleEnter();
           

            FoodTracker tracker = new FoodTracker();


            //Вибір операції
            Console.WriteLine("\t\t\t--------------------------------------------------------");
            Console.WriteLine("\t\t\tEnter the number of the operation you want to select:" +
                " \n\t\t\t1 = Add product to list\n\t\t\t2 = Delete Product from list \n\t\t\t3" +
                " = View product list\n\t\t\t4 = calories that need to be gained during the day\n\t\t\t5 = Water rate per day\n\t\t\t6 = Exit\n");
            Console.WriteLine("\t\t\t--------------------------------------------------------");

            bool exit = true;
            while (exit)
            {
                Console.WriteLine("Choose operation: ");
                int operation = int.Parse(Console.ReadLine());
                switch (operation)
                {
                    case 1:
                        Console.WriteLine("Enter the name of the product to be added to the list: ");
                        string addfoodName = Console.ReadLine();
                        Console.WriteLine("Enter the calorie content of the product: ");
                        int calories = int.Parse(Console.ReadLine());
                        tracker.AddFood(addfoodName, calories);
                        tracker.SaveToFile("food_items.json");
                        break;

                    case 2:
                        Console.WriteLine("Enter  the name of the product to remove from the list: ");
                        string removedfoodName = Console.ReadLine();
                        tracker.RemoveFood(removedfoodName);
                        Console.WriteLine("Product has been deleted from the list");
                        break;
                    case 3:
                        Console.WriteLine("Here is the list of foods you ate during the day\n");

                        tracker.PrintTotalFood();
                        break;

                    case 4:
                        Console.WriteLine("\t\t\t---------------------------------------------\n\t\t\tYou need to gain "
                            + CalculateUserCalories.GetCalorieGoal(user.Gender, user.Weight, user.Height, user.Age, user.Goal)
                            + " calories during the day\n\t\t\t---------------------------------------------\t\t\t");

                        break;
                    case 5:
                        
                        Console.WriteLine("\t\t\t---------------------------------------------\n\t\t\tyou need to drink "
                            + CalculateUserCalories.CalculateDailyWaterIntake(user.Weight) +
                            " liters during the day\n\t\t\t---------------------------------------------\t\t\t");

                        break;
                    default:
                        exit = false;
                        break;

                }
            }

            //tracker.SerializeToJson("path/to/file.json");
            // кінцева інформація про харчування користувача
            CalculateUserCalories.PrintResult(tracker, user.Gender, user.Weight, user.Height, user.Age, user.Goal); 
        }

    }
}