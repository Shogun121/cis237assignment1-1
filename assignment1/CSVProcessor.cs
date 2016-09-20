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
    { 
        //Instantiate a version of WineItemClass. 
        WineItemClass WineItem = new WineItemClass();

        

        public bool ReadCsvFile(string pathToCsvFile,WineItemClass[] WineItemArray)
        {   //reads the csv file
            
            //Handles the processing of the file.
            StreamReader inputFile=null;
            
            //Reads through the CSV file and switches a bool variable, to prevent a 2nd read.
            try
            {
                //declare a variable to hold each read line
                string inputString;

                //Instantiate Stream reader, if path is incorrect an exception will be thrown.
                inputFile = new StreamReader(pathToCsvFile);

                //Setup a counter we aren't using yet.
                int counter = 0;

                //while a line can be read, put it in the string var.
                while((inputString=inputFile.ReadLine())!=null)
                {
                    /*Call the inputLine method and pass in the WineItem Array(passed by ref auto)
                     * and the counter, that wil be used as index. Increment with ++
                     */
                    InputLine(inputString, WineItemArray,counter++);
                }
                //All the reads performed worked and return true.
                return true;
            }
            catch (Exception ex)
            {
                //Output exception string and the stack trace to aid in debugging.
                Console.WriteLine(ex.ToString());
                Console.WriteLine();
                Console.WriteLine(ex.StackTrace);

                //return false because the readings failed.
                return false;
            }
            //Used to ensure specific code is run regardless of try-catch execution.
            finally
            {
              //Check to see if the streamReader object is actually open before bothering.
                if(inputFile!=null)
                {
                    //Close the file to ensure data is secure, and to free memory.
                    inputFile.Close();
                }
            }
        }
        static void InputLine(string line,WineItemClass[] wineItemArray, int index)
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
        
        
    }
}
