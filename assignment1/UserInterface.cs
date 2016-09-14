/**Robert Cooley
 * CIS 237 Tu, Thu
 * 9/13/16
 * */
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace assignment1
{
    class UserInterface
    {//class designed to handle all UI related functions 

        //Backing fields
        private int _userInput;
        string input;
        //Constructor

        //Methods
        public int GetInput()
        {   //Obtains user input.
            this.PrintMenu();

            input = Console.ReadLine();

            while (input != "1" & input != "2" && input != "3" && input != "4" && input != "5")
            {
                PrintError();                   //Prints error message, prints menu, and reads input.
            }
            return Int32.Parse(input);
             
        }
        private void PrintMenu()
        {   //prints the terminal's options for the user to decide what to do.
            Console.WriteLine("1-Read wine List");
            Console.WriteLine("2-Print wine List");
            Console.WriteLine("3-Search list by Index");
            Console.WriteLine("4-Add Wine Items");
            Console.WriteLine("5-Exit UI");
        }
        private void LoadWineList()
        {   //--OPTION 1--Load the wine list into an array.

        }
        private void PrintWineList()
        {    //--OPTION 2--Print the wine list to the terminal.

        }
        private void SearchWineItem()
        {    //--OPTION 3--Search the WineItem Array for an item by index.
             //Return item if found, if not return an error.
        }
        private void AddWineItem()
        {    //--OPTION 4--Add the WineItem to the WineListArray.

        }
        private void ExitUI()
        {    //--OPTION 5--Exit the WineArray program.
            
        }
        private void PrintError()
        {   //print message for incorrect input
            Console.WriteLine("That option is not available.");
            Console.WriteLine("Please pick another.");
            Console.WriteLine("");

            this.PrintMenu();

            input = Console.ReadLine();
        }

        //Properties
        private int  UserInput
        {
            get { return _userInput; }
            set { _userInput = UserInput; }
        }
    }
}
