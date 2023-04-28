using System;
using System.Collections.Generic;
using System.Text;

namespace Food_Tracker
{
    interface ITracker
    {
        void AddFood(string foodName, int calories);
        void RemoveFood(string foodName);
        int GetCalories();
    }
}
