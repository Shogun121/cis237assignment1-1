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
    class WineItemCollection
    {   //Used to read,store, and reference a list of wine initially read from a file.

        CSVProcessor csvprocessor = new CSVProcessor();
        public WineItemClass[] wineItemArray = new WineItemClass[5000];
        WineItemClass myItemClass = new WineItemClass();
        UserInterface myUi = new UserInterface();

        //backing field
        bool inputBool=false;   //bool preventing the user from inputing file more than once.

        public void LoadWineList()
        {
            csvprocessor.ReadCsvFile("../../../datafiles",wineItemArray);
            inputBool=true;
        }

        public void PrintWineList()
        {
            //Prints wine items until the index(starting from 0) reaches the end of the array.
            int index = 0;
            while (wineItemArray[index] !=wineItemArray[5000])
            {
                Console.WriteLine();
                index++;
            }
        }
        public void SearchWineCollection()
        {   //method used to search through the WineArray for a match to the search query.


            //call method in UI to acquire search parameters
            myUi.GetInputNoMenu();
            //variable declared to hold the the index place through the loop.
            int i = 0;

            //loop searching WineArray by index for id.
            while (wineItemArray[i] != myUi.UserInput)
            {
                //increments index to search the next item in the array.
                i += 1;

                //loop to determine if the whole array has been searched
                if (wineItemArray[i] == wineItemArray[5000])
                {
                    //Notify program that the wine item was not found.
                    Console.WriteLine("Item not found");
                }
            }
            Console.WriteLine(wineItemArray[i].ToString());
        }
        public void AddItem()
        {   //method used to add an item to the wine item array.

            //call method to get user input for addition to array;
            myUi.GetInputNoMenu();

        }
    }
}
