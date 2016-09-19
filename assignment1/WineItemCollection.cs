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


        //backing field
        bool inputBool=false;   //bool preventing the user from inputing file more than once.

        public bool LoadWineList()
        {
            csvprocessor.ReadCsvFile("../../../datafiles", wineItemArray[5000]);
            inputBool=true;
        }

        public void PrintWineList()
        {
            //Prints wine items until the index(starting from 0) reaches the end of the array.
            int index = 0;
            while (csvprocessor.wineItemArray[index] != csvprocessor.wineItemArray[5000])
            {
                Console.WriteLine();
                index++;
            }
        }
        //public string SearchWineCollection()
        //{   //method used to search through the WineArray for a match to the search query.

        //    //variable declared to hold the the index place through the loop.
        //    int i = 0;

        //    //loop searching WineArray by index for id.
        //    while (WineArray[i] != _idString)
        //    {
        //        //increments index to search the next item in the array.
        //        i += 1;

        //        //loop to determine if the whole array has been searched
        //        if (WineArray[i] == WineArray[5000])
        //        {
        //            //return null to notify program that the wine item was not found.
        //            return null;
        //        }
        //    }
        //    return WineArray[i];
        //}
    }
}
