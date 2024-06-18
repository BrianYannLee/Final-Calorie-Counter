using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Linq;

namespace Final_Calorie_Counter
{
    public class CaloriesCounterApp
    {
        //----------------------------Initilalizeation-------------------------------
        #region
        public List<FoodItem>  foodItems { get; set; } //Define the property of foodItem

        public CaloriesCounterApp()
        {
            foodItems = new List<FoodItem>();
        }
        public void InitializeFoodItem()
        {
            foodItems = new List<FoodItem>(); //Creating a new Object called foodItems

            //Intiliazing the foodItem list
            foodItems.Add(new FoodItem { Name = "Apple", Category = "Fruit", Calories = 95, Quantity = 1 });
            foodItems.Add(new FoodItem { Name = "Banana", Category = "Fruit", Calories = 105, Quantity = 2 });
            foodItems.Add(new FoodItem { Name = "Carrot", Category = "Vegetable", Calories = 25, Quantity = 3 });
            foodItems.Add(new FoodItem { Name = "Broccoli", Category = "Vegetable", Calories = 55, Quantity = 2 });
            foodItems.Add(new FoodItem { Name = "Chicken", Category = "Protein", Calories = 165, Quantity = 1 });
            foodItems.Add(new FoodItem { Name = "Beef", Category = "Protein", Calories = 250, Quantity = 1 });
            foodItems.Add(new FoodItem { Name = "Rice", Category = "Grain", Calories = 205, Quantity = 1 });
            foodItems.Add(new FoodItem { Name = "Bread", Category = "Grain", Calories = 80, Quantity = 2 });
            foodItems.Add(new FoodItem { Name = "Milk", Category = "Dairy", Calories = 150, Quantity = 1 });
            foodItems.Add(new FoodItem { Name = "Cheese", Category = "Dairy", Calories = 110, Quantity = 2 });

            foreach (var item in foodItems) //calculating and adding total calories on the list. 
            {
                item.TotalCalories = item.CalculateTotalCalories();
            }
        }//end of InitilizeFoodItem(method)
        #endregion
        //------------------------Utility Methods ------------------------------------
        #region
        public int CheckFoodByName(string name) //Linear Search for name in list. 
        {
            for (int i = 0; i < foodItems.Count; i++)
            {
                if (foodItems[i].Name.Equals(name,StringComparison.OrdinalIgnoreCase))
                {
                    return i;
                }
            }
            return -1;
        }//end of CheckFoodByName(method)

        public void CalculateTotalCaloriesEaten() //Calculate TotalCalories Eaten in the whole list
        {
            int totalCalories = 0;
            foreach (var item in foodItems)
            {
                totalCalories += item.TotalCalories;
            }
            Console.WriteLine($"Total Calories Eatne: {totalCalories}" );
        }//end of CaclulateTotalCaloriesEaten(method)

        public void CalculateAverageCaloriesEaten(int totalCalories) //Calculate Average Calories Eaten in the whole list
        {
            int averageCalories = totalCalories / foodItems.Count;
            Console.WriteLine($"Average Calories Eaten: {averageCalories}");
        }//end of CalculateAverageCaloriesEaten(method)

        #endregion
        //--------------------Main App Method ----------------------
        #region
        public void AddNewItem() // Add new item in foodItem list. 
        {
            Console.WriteLine("Enter the food Name:"); 
            string userName = InputChecker.StringInputChecker(); //Check whether user Input is a string
            if(CheckFoodByName(userName) != -1) //Check if the food is already on the list or not
            {
                Console.WriteLine("Food Already Listed.");
            }
            else //If it isn't listed add new item in the foodItem list.
            {
                Console.WriteLine("Food not Listed");
                Console.WriteLine("Enter the Category:");
                string userCategory = InputChecker.StringInputChecker();
                Console.WriteLine("Enter the Caloires");
                int userCalories = InputChecker.IntInputChecker();
                Console.WriteLine("Enter the Quantity");
                int userQuantity = InputChecker.IntInputChecker();

                int userTotalCalories = userQuantity * userCalories; //Calculate total Calories of the new item

                foodItems.Add(new FoodItem { Name = userName, Category = userCategory, Calories = userCalories, Quantity = userQuantity, TotalCalories = userTotalCalories}); //add it to the list.
            }
        }//end of AddNewItem(method)

        public void DisplayFoodList() //Dsplay the whole list of foodItem
        {
            Console.WriteLine($"{"Name",-10} | {"Category",-10} | {"Calories",-8} | {"Quantity",-8} | {"Total Calories",-14}");
            Console.WriteLine("--------------------------------------------------------------------");
            if (foodItems == null)
            {
                Console.WriteLine("No food items available.");
                return;
            }
            foreach (var item in foodItems)
            {
                Console.WriteLine($"{item.Name,-10} | {item.Category,-10} | {item.Calories,-8} | {item.Quantity,-8} | {item.TotalCalories,-14}");
            }
        }//end of DisplayFoodList(method)
        public void DisplayCategoryFoodList() //Display the list of foodItem of a user inputed Category
        {
            Console.WriteLine("Enter the Category:");
            string userCategory = InputChecker.StringInputChecker();

            Console.WriteLine($"{"Name",-10} | {"Category",-10} | {"Calories",-8} | {"Quantity",-8} | {"Total Calories",-14}");
            Console.WriteLine("--------------------------------------------------------------------");
            foreach (var item in foodItems)
            {
                if(item.Category.Equals(userCategory, StringComparison.OrdinalIgnoreCase))
                {
                    Console.WriteLine($"{item.Name,-10} | {item.Category,-10} | {item.Calories,-8} | {item.Quantity,-8} | {item.TotalCalories,-14}");
                }
            }
        }//end of DisplayCategoryFoodList(method)

        public void SearchFoodByName() //Look for a food name and prints its list.
        {
            Console.WriteLine("Enter the food name: ");
            string userName = InputChecker.StringInputChecker();
            int index = CheckFoodByName(userName);
            if (index !=-1)
            {
                var item = foodItems[index];
                Console.WriteLine($"{"Name",-10} | {"Category",-10} | {"Calories",-8} | {"Quantity",-8} | {"Total Calories",-14}");
                Console.WriteLine("--------------------------------------------------------------------");
                Console.WriteLine($"{item.Name,-10} | {item.Category,-10} | {item.Calories,-8} | {item.Quantity,-8} | {item.TotalCalories,-14}");
            }
            else
            {
                Console.WriteLine("Food Not Listed");
            }
        }//end of SearchFodoByName(method)
        #endregion

    }//end of CaloriesCounterApp(class)
}
