using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Channels;
using System.Threading.Tasks;

namespace Final_Calorie_Counter
{
    public class InputChecker
    {
        public static int IntInputChecker() 
        {
            int userIntInput;
            while (!int.TryParse(Console.ReadLine(), out userIntInput))
            {
                Console.WriteLine("Invalid Input. Try Again.");
            }
            return userIntInput;
        } //end of intInputChecker(method)
        public static string StringInputChecker()
        {
            string userStringInput;
            string pattern = @"^[a-zA-z]+$";
            while((userStringInput = Console.ReadLine()) !=null && !Regex.IsMatch(userStringInput, pattern))
            {
                Console.WriteLine("Invalid Input. Try Again.");
            }
            return userStringInput ?? string.Empty;
        }//end of StringInputChecker(method)
        public int MenuInputChecker()
        {
            int userMenuInput;
            while (!int.TryParse(Console.ReadLine(), out userMenuInput) || userMenuInput < 1 ||userMenuInput > 5)
            {
                Console.WriteLine("Invalid Input. Try Again.");
            }
            return userMenuInput;
        }//end of MenuInputChecker(method)
    }
}
