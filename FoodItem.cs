using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Final_Calorie_Counter
{
    public  class FoodItem
    {

        //Create a Constructor. (Highlight Field and ctrl + .)
        public FoodItem(string name, string category, int calories, int quantitiy, int totalCalories)
        {
            Name = name;
            Category = category;
            Calories = calories;
            Quantity = quantitiy;
            TotalCalories = totalCalories;
        }

        //Define the Field.(User prop tab for faster input)
        public string Name { get; set; }
        public string Category { get; set; }
        public int Calories { get; set; }
        public int Quantity { get; set; }
        public int TotalCalories { get; set; }

        //Create a default.(ctor tab for faster input)
        public FoodItem() 
        {
            Name = "No Food Item";
            Category = "No Category";
            Calories = -1;
            Quantity = -1;
            TotalCalories = -1;
        }

        public int CalculateTotalCalories()
        {
            return  Calories * Quantity;
        }//end of CalculateTotalCaloires(method)

    }//end of FoodItem(Class)
}
