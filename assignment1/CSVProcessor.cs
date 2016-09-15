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

        //Array for wine items
        Array WineArray = new Array[5000];

        //Backing Field--2: processedBool, wineItemString
        private bool processedBool = false;
        private string wineItemString = "";

        //Constructor : NONE

        //Methods--1: ReadCsvFile
        public void ReadCsvFile()
        {   //Reads through the CSV file and switches a bool variable, to prevent a 2nd read.


            inputFile=File.OpenText("WineList.txt");
            while(!inputFile.EndOfStream)
            {
                wineItemString = inputFile.ReadLine();

                
            }
            processedBool = true;           //change bool value to prevent the program from reading the list a second time.

        }
        //Properties : NONE
    }
}
