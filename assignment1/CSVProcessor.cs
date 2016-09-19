///**Robert Cooley
// * CIS 237 Tu, Thu
// * 9/13/16
// * */
//using System;
//using System.Collections.Generic;
//using System.Linq;
//using System.Text;
//using System.Threading.Tasks;
//using System.IO;                            //required to use StreamReader.

//namespace assignment1
//{

//    class CSVProcessor
//    { //Handles the processing of the file.
//        StreamReader inputFile;



//        //Backing Field--2: processedBool, wineItemString
//        private bool processedBool = false;
//        private string wineItemString = "";

//        public void ReadCsvFile()
//        {   //Reads through the CSV file and switches a bool variable, to prevent a 2nd read.
//            try
//            {
//                inputFile = File.OpenText("WineList.txt");
//                while (!inputFile.EndOfStream)
//                {
//                    wineItemString = inputFile.ReadLine();
//                    foreach (Array index in WineItemClass.WineArray)
//                    {

//                    }
//                }
//                //change bool value to prevent the program from reading the list a second time.         

//            }
//            catch (Exception ex)
//            {
//                Console.WriteLine(ex.ToString());
//                Console.WriteLine();
//                Console.WriteLine(ex.StackTrace);
//            }
//            finally
//            {
//                processedBool = true;
//                inputFile.Close();
//            }
//        }
//    }
//}
