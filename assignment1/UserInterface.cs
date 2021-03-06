﻿/**Robert Cooley
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
        WineItemCollection myCollection=new WineItemCollection();
        WineItemClass myItemClass = new WineItemClass();
        

        //Backing fields--2: userInput. input.
        private string _userInput;
        string input;


        //Methods--13: 6 public, 7 private.
        public int GetInput()
        {   //Obtains user input.
            this.PrintMenu();

            input = Console.ReadLine();

            while (input != "1" && input != "2" && input != "3" && input != "4" && input != "5")
            {
                PrintError();                   //Prints error message, prints menu, and reads input.
            }

            UserInput = input;
            return Int32.Parse(input);
        }        
        public void GetInputNoMenu()
        {   //Obtains user input.
            input = Console.ReadLine();

            while (input != "1" && input != "2" && input != "3" && input != "4" && input != "5")
            {
                PrintError();                   //Prints error message, prints menu, and reads input.
            }
            UserInput = input;
        }
        //methods used to acquire input(other method is written too specifically to use for this).
        public void GetAddItemID()
        {   //method used for the ID component of acquring add data.
            string iDInput = "";

            Console.WriteLine("Type the desired ID first.");
            iDInput = (Console.ReadLine());
        }
        public void GetAddItemDesc()
        {   //method used for the Desc component of acquring add data.
            string descInput = "";

            Console.WriteLine("Type the desired Description next");
            descInput = (Console.ReadLine());
        }
        public void GetAddItemPack()
        {   //method used for the pack component of acquring add data.
            decimal packInput = 0m;

            Console.WriteLine("Type the desired pack last.");
            packInput = decimal.Parse(Console.ReadLine());
        }
        public string MenuChoice()
        {   //Utilizes a switch statement to determine which menu choice was selected.
            switch (input)
            {
                case "1":
                    Load();
                    Console.WriteLine();
                    break;
                case "2":
                    PrintWineList();
                    Console.WriteLine();
                    break;
                case "3":
                    SearchWineItem();
                    Console.WriteLine();
                    break;
                case "4":
                    AddWineItem();
                    Console.WriteLine();
                    break;
                default:
                    ExitUi();
                    break;
            }
            return input;
        }
        private void PrintMenu()
        {   //prints the terminal's options for the user to decide what to do.
            Console.WriteLine("1-Read wine List");
            Console.WriteLine("2-Print wine List");
            Console.WriteLine("3-Search list by Index");
            Console.WriteLine("4-Add Wine Items");
            Console.WriteLine("5-Exit UI");
            Console.WriteLine();
        }
        private void Load()
        {   //--OPTION 1--Load the wine list into an array.
            myCollection.LoadWineList();
        }
        private void PrintWineList()
        {    //--OPTION 2--Print the wine list to the terminal.
            myCollection.PrintWineList();
        }
        private void SearchWineItem()
        {    //--OPTION 3--Search the WineItem Array for an item by index.
             //Return item if found, if not return an error.
            myCollection.SearchWineCollection();
        }
        private void AddWineItem()
        {    //--OPTION 4--Add the WineItem to the WineListArray.
            myItemClass.AddWineItem();
        }
        private void ExitUi()
        {    //--OPTION 5--Exit the WineArray program.
            Console.WriteLine("Goodbye");
        }
        private void PrintError()
        {   //print message for incorrect input
            Console.WriteLine("That option is not available.");
            Console.WriteLine("Please pick another.");
            Console.WriteLine("");

            this.PrintMenu();

            input = Console.ReadLine();
        }
        //Properties--1: UserInput
        public string  UserInput
        {
            get { return _userInput; }
            set { _userInput = UserInput; }
        }
    }
}
