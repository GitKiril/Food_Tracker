using System;
using System.Collections.Generic;
using System.Text;

namespace Food_Tracker
{
    public class User
    {
        public string Name { get; set; }
        public int Age { get; set; }
        public int Weight { get; set; }
        public int Height { get; set; }
        public string Gender { get; set; }
        public string Goal { get; set; }

        public User(string name, int age, int weight, int height, string gender, string goal)
        {
            Name = name;
            Age = age;
            Weight = weight;
            Height = height;
            Gender = gender;
            Goal = goal;
        }

       
    }
}
