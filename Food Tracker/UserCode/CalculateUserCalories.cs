using System;
using System.Collections.Generic;
using System.Text;

namespace Food_Tracker
{
    public static class CalculateUserCalories
    {
        private static int GetBMR(string gender, int weight, int height, int age)
        {
            int bmr = 0;
            if (gender.ToLower() == "male")
            {
                bmr = (int)(88.36 + (13.4 * weight) + (4.8 * height) - (5.7 * age));
            }
            else if (gender.ToLower() == "female")
            {
                bmr = (int)(447.6 + (9.2 * weight) + (3.1 * height) - (4.3 * age));
            }

            return bmr;
        }

        public static int GetCalorieGoal(string gender, int weight, int height, int age, string goal)
        {
            int bmr = GetBMR(gender, weight, height, age);
            int calorieGoal = 0;
            switch (goal)
            {
                case "lose":
                    calorieGoal = (int)(bmr * 0.8);
                    break;
                case "maintain":
                    calorieGoal = bmr;
                    break;
                case "gain":
                    calorieGoal = (int)(bmr * 1.2);
                    break;
            }

            return calorieGoal;
        }
        public static double CalculateDailyWaterIntake(int weight)
        {
            return weight * 0.033;
        }
        public static void PrintResult(FoodTracker tracker, string gender, int weight, int height, int age, string goal)
        {
            Console.WriteLine("\t\t\t-----------------------------------------------------");
            Console.WriteLine("\t\t\tTotal calories consumed: " + tracker.GetCalories());
            int calorieGoal = CalculateUserCalories.GetCalorieGoal(gender, weight, height, age, goal);
            int calorieDifference = calorieGoal - tracker.GetCalories();
            Console.WriteLine("\t\t\tCalorie goal: " + calorieGoal);
            Console.WriteLine("\t\t\tCalories remaining: " + calorieDifference);
            if (calorieDifference > 0)
            {
                Console.WriteLine("\t\t\tYou have " + calorieDifference + " calories remaining to reach your goal.");
            }
            else if (calorieDifference < 0)
            {
                Console.WriteLine("\t\t\tYou have exceeded your calorie goal by " + (-1 * calorieDifference) + " calories.");
            }
            else
            {
                Console.WriteLine("\t\t\tYou have reached your calorie goal for today.");
            }
            Console.WriteLine("\t\t\t-----------------------------------------------------");
        }
    }
}
