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
    class WineItemClass
    {//class used to describe individual item in the WineItemList.
        //Array for wine items
        string[] WineArray= new string[5000];

        
        //Backing Fields--3: ID, Desc, Pack
        private string _idString;
        private string _descString;
        private int _packInt;

        //Constructor--2: Default, 3 parameter.

        //1st Constructor(Default)
        public WineItemClass()
        {

        }

        //2nd Constructor(3 Parameter)
            //Accepts three arguments and assigns backing fields to them if used.
        public WineItemClass(string IdString,string DescString, int PackInt)
        {
            this._idString = IdString;
            this._descString = DescString;
            this._packInt = PackInt;
            AddWineItem(_idString,_descString,_packInt);
        }

        //Methods--2: ToString Override, SearchWineCollection
        public string SearchWineCollection()
        {   //method used to search through the WineArray for a match to the search query.

            //variable declared to hold the the index place through the loop.
            int i = 0;

            //loop searching WineArray by index for id.
            while(WineArray[i]!=_idString)
            {
                //increments index to search the next item in the array.
                i += 1;

                //loop to determine if the whole array has been searched
                if(WineArray[i]==WineArray[5000])
                {
                    //return null to notify program that the wine item was not found.
                    return null;
                }
            }
            return WineArray[i];
        }
        public void PrintWineList()
        {
            //Prints wine items until the index(starting from 0) reaches the end of the array.
            int index=0;
            while(WineArray[index]!=WineArray[5000])
            {
                Console.WriteLine();
            }
        }
        public string AddWineItem(string WineID, string WineDes, int WinePack)
        {
            try
            {
                if(WineID.All(char.IsLetter))
                {

                }
            }
            catch
            {

            }
            return null;
        }
        public override string ToString()
        {   //prints info related to the wine items
            return this._idString+ this._descString + this._descString + this._packInt;
        }
        //Properties--3: ID, Description, and Pack
        public string ID
        {
            get {return _idString; }
            set { _idString = value; }
        }
        public string Description
        {
            get { return _descString; }
            set { _descString = value; }
        }
        public int Pack
        {
            get { return _packInt; }
            set { _packInt = value; }
        }
    }
}
