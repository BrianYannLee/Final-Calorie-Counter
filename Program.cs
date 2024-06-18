namespace Final_Calorie_Counter
{
    internal class Program
    {
      
        public CaloriesCounterApp caloriesCounter = new CaloriesCounterApp();
        public InputChecker inputChecker = new InputChecker();
        public FoodItem foodItem = new FoodItem();
        public MenuClass menuClass = new MenuClass();
        
        public static void Main(string[] args)
        {
            Program program = new Program();
            program.caloriesCounter.InitializeFoodItem(); //PROBLEM: NOT BEING INITIALIZING THE LIST

            bool exit = false;
            int userMenuInput;
            do //Loops the menu selection for repeated use.
            {
                program.menuClass.DisplayMenu();
                userMenuInput = program.inputChecker.MenuInputChecker();
                exit = program.menuClass.MenuSelection(userMenuInput);
            } while (exit == false);

        }
    }
}
//---------ASSIGNMENT----------------------
/*Menu system:
 * Display all Calories you have Eaten
 * Add New Items
 * Calculate your Total Calories Eaten
 * Calculate the Average Calories of an item you've eaten
 * Display all food eaten of a certain category
 * Search for a food item by name
 * Exit
 * 
 * Include these Topics:
 * Input | Output | Loops | Condition | Variables
 * Operation | Method | Arrays | Linear Search | Classes
 */
// ------------PSEUDOCODE-----------------
/*
 * DEFINE A CLASS FOR FOODITEM
 * Class FoodItem
 *    Property: Name(string)
 *    Property: Category (string)
 *    Property: Calories(Integer)
 *    Property: Quantity (Integer)
 *    Property: TotalCalories (Integer)
 *    
 *    Method: CalculateTotalCalories()
 *      TotalCalories = Calories * Quantity
 *    
 *
 *DEFINE A CLASS FOR CALORIESCOUNTER
 *
 *CREATE A FOODITEMLIST
 *  Property:foodItems(List<FoodItem>)
 *  
 *  Consturcor: CaloriesCounterApp()
 *      Call InitilizeFoodItem()
 *  
 *  Method: InilitializeFood Item
 *      initialize foodItems as an empty list
 *      // Prepopulate with initial data
 *      Add "Apple, Fruit, 95, 1" to foodItems
 *      Add "Banana, Fruit, 105, 2" to foodItems
 *      Add "Carrot, Vegetable, 25, 3" to foodItems
 *      Add "Broccoli, Vegetable, 55, 2" to foodItems
 *      Add "Chicken, Protein, 165, 1" to foodItems
 *      Add "Beef, Protein, 250, 1" to foodItems
 *      Add "Rice, Grain, 205, 1" to foodItems
 *      Add "Bread, Grain, 80, 2" to foodItems
 *      Add "Milk, Dairy, 150, 1" to foodItems
 *      Add "Cheese, Dairy, 110, 2" to foodItems
 * 
 *DISPLAY MENU
 *  Method: DisplayMenu()
 *      Print "1. Display all the calories you have eaten"
 *              -Display Full foodItemList
 *              -Calculate and Display Total Calories Eaten
 *              -Calculate the Average Calroies Eaten
 *      Print "2. Display all food eaten of a certain Category"
 *      Print "3. Add New Items"
 *      Print "4. Search for a food item by name"
 *      Print "5. Exit"
 *INPUT CHECKER METHODs
 *  Method: IntInputChecker()
 *      Input userIntInput
 *      While Tryparse int == false
 *          Print "Invalid Input Try Again"
 *          Input userIntInput
 *      return userIntInput
 *      
 *  Method: StringInputChecker()
 *      Input userStringInput
 *      While Regex string == false
 *          Print "Invalid Input Try Again"
 *          Input userStringInput
 *      return userStringInput
 *   
 *   Method: MenuInputChecker()
 *      Input userMenuInput
 *      While Tryparse int == false && userMenuInput < 1 || userMenuInput > 5
 *          Print "Invalid Input Try Again"
 *      return userMenuInput
 *      
 *MENU SELECTION
 *  Method: MenuSelection(userMenuInput)
 *      swith userMenuInput
 *          case 1: 
 *              AddNewItem()
 *              return 0
 *          case 2: 
 *              DisplayAllCaloires()
 *              return 0
 *          case 3: 
 *              DisplayFoodByCategory()
 *              return 0
 *          case 4: 
 *              SearchFoodByName()
 *              return 0
 *          case 5: return -1
 *          
 *UTILITY METHODS      
 *  Method: CheckFoodByName(name)
 *      For variable i from 0 to length of FoodItem list
 *          If FoodItem.Name = name
 *              return i
 *      return -1
 *      
 *  Method: CalculateTotalCaloriesEaten()
 *      totalCalories = 0
 *      For each FoodItem in foodItems
 *          totalCalories += Food.TotalCalories
 *      Print"Total Calories Eaten:" + totalCalories
 *      
 *      return totalCalories
 *          
 *  Method: CalculateAverageCaloriesEaten(totalCalories)
 *      averageCalories = totalCalories/lenght of list of foodItem
 *      return averageCalories
 *      
 *CALORIESCOUNTER APP METHODS      
 * Method: AddNewItem()
 *      Input name
 *      StringInputChecker()
 *      index = CheckFoodByName(name)
 *      if index != -1
 *          Print "Food already listed"
 *      else
 *          Input categoy
 *          StringInputChecker()
 *          Input caloreis
 *          IntInputChecker()
 *          INput Quantitity
 *          IntInputChecker()
 *          
 *          Call CalculateTotalCalories() on the new FoodItem
 *          Add the new foodItem with the inputs
 *          Call CalculateTotalCalories() on the new FoodItem
 *          Add the new FoodItem to foodItemlist
 *      
 *  Method: DisplayAllCaloires
 *      For each Fooditem in foodItems
 *          Print name, category, calories, quanitity, totalCaloires
 *      CalculateTotalCaloiresEaten()
 *      CalculateAverageCaloiresEaten()
 *  
 *  Method: DisplayFoodByCategory()
 *      Input category
 *      StringInputChecker()
 *      For each FoodItem in foodItems
 *          if FoodItem.Category == category
 *              Print name, caloires, quanitity,totalCaloires
 *  
 *  Method: SearchFoodByName(name)
 *      index = CheckFoodByName(name)
 *      if index != -1
 *          print name, Category, calories, quantitiy, totalCalories of index
 *      else 
 *          print "Food not listed"
 *          
 *MAIN PROGRAM METHOD   
 *  Main Method: Main
 *  Create instance of CallorieCouter()
 *  exit = 0
 *  Do  
 *      DisplayMenu()
 *      MenuInputChecker()
 *      exit = MenuSelection()
 *  while exit != -1
 *      
 */