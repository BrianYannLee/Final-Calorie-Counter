using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Final_Calorie_Counter
{
    public class MenuClass
    {
        public CaloriesCounterApp caloriesCounter = new CaloriesCounterApp();
        
        public void DisplayMenu()
        {
            Console.WriteLine("1. Display all the calories you have eaten");
            Console.WriteLine("2. Display all food eaten of a certain category");
            Console.WriteLine("3. Add New Items");
            Console.WriteLine("4. Search for a food item by name");
            Console.WriteLine("5. Exit");
        }//end of DispalyMenu(method)
        public bool MenuSelection(int userMenuInput)
        {
            MenuClass menuClass = new MenuClass();
            switch (userMenuInput)
            {
                case 1:
                    Console.WriteLine("-----Display Food List-------");
                    menuClass.caloriesCounter.DisplayFoodList();
                    Console.WriteLine();
                    return false;
                case 2:
                    Console.WriteLine("----Display Category Food List-----");
                    menuClass.caloriesCounter.DisplayCategoryFoodList();
                    Console.WriteLine();
                    return false;
                case 3:
                    Console.WriteLine("-----Add New Item------");
                    menuClass.caloriesCounter.AddNewItem();
                    Console.WriteLine();
                    return false;
                case 4:
                    Console.WriteLine("-------Search Food By Name -------");
                    menuClass.caloriesCounter.SearchFoodByName();
                    Console.WriteLine();
                    return false;
                case 5:
                    Console.WriteLine("-----Exiting the Program-----");
                    return true;
                default:
                    return false;
            }
        }//end of MenuSelection(method)

    }//end of MenuClass(class)
}
