using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.IO;
using System.Text;

namespace Food_Tracker
{
    public class FoodTracker : ITracker
    {
        public List<FoodItem> _foodItems;

        public FoodTracker()
        {
            _foodItems = new List<FoodItem>();
        }

        public void AddFood(string foodName, int calories)
        {
            _foodItems.Add(new FoodItem { Name = foodName, Calories = calories });
        }

        public void RemoveFood(string foodName)
        {
            _foodItems.RemoveAll(item => item.Name == foodName);
        }

        public void SaveToFile(string fileName)
        {

            string json = JsonConvert.SerializeObject(_foodItems, Formatting.Indented);

           
            File.WriteAllText(fileName, json);
        }
        



        public int GetCalories()
        {
            int totalCalories = 0;
            foreach (var item in _foodItems)
            {
                totalCalories += item.Calories;
            }

            return totalCalories;
        }



        public void PrintTotalFood()
        {
            Console.WriteLine("\t\t\t---------------------------------------------------");
            foreach (var item in _foodItems)
            {
                Console.WriteLine($"\t\t\tProduct name  {item.Name}  Сaloric content {item.Calories} calories ");

            }
            Console.WriteLine("\t\t\tTotal calories per day " + GetCalories());
            Console.WriteLine("\t\t\t---------------------------------------------------");
        }


        //public void SerializeToJson(string filePath)
        //{
        //    FoodTrackerSerializer.SerializeToJson(_foodItems, filePath);
        //}
    }
}
