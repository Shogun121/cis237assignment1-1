/**Robert Cooley
 * CIS 237 Tu, Thu
 * 9/13/16
 * */
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;                            //required to use StreamReader.

namespace assignment1
{

    class CSVProcessor
    { //Handles the processing of the file.
        StreamReader inputFile;

        //Instantiate a version of WineItemClass. 
        WineItemClass WineItem = new WineItemClass();

        WineItemClass[] wineItemArray = new WineItemClass[5000]; 



        //Backing Field--2: processedBool, wineItemString
        private bool processedBool = false;
        private string wineItemString = "";

        public void ReadCsvFile()
        {   //Reads through the CSV file and switches a bool variable, to prevent a 2nd read.
            try
            {
                inputFile = File.OpenText("WineList.txt");
                while (!inputFile.EndOfStream)
                {
                    wineItemString = inputFile.ReadLine();
                }
                //change bool value to prevent the program from reading the list a second time.         

            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.ToString());
                Console.WriteLine();
                Console.WriteLine(ex.StackTrace);
            }
            finally
            {
                processedBool = true;
                inputFile.Close();
            }
        }
        public void InputLine(string line,WineItemClass[] wineItemArray, int index)
        {   //Method to split the readline into segments.

            //declare a string array.
            string[] parts= line.Split(',');

            //assign the parts to local variables.
            string iD=parts[0];
            string description=parts[1];
            decimal pack=decimal.Parse(parts[2]);

            //use local variables to create an instance of the wine array to hold the incoming records.
            wineItemArray[index] = new WineItemClass(iD, description, pack);

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
