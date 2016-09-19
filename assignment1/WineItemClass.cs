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
        //string[] WineArray= new string[5000];

        
        //Backing Fields--3: ID, Desc, Pack
        private string _idString;
        private string _descString;
        private decimal _packDec;

        //Constructor--2: Default, 3 parameter.

        //1st Constructor(Default)
        public WineItemClass()
        {

        }

        //2nd Constructor(3 Parameter)
            //Accepts three arguments and assigns backing fields to them if used.
        public WineItemClass(string IdString,string DescString, decimal PackDec)
        {
            this._idString = IdString;
            this._descString = DescString;
            this._packDec = PackDec;
            AddWineItem(_idString,_descString,_packDec);
        }

        //Methods--2: ToString Override, SearchWineCollection
        
        public string AddWineItem(string WineID, string WineDes, decimal WinePack)
        {
            try
            {
                if(WineID.All(char.IsLetter))
                {
                    if (WineDes.All(char.IsLetter))
                    {
                        
                    }
                }
            }
            catch
            {

            }
            return null;
        }
        public override string ToString()
        {   //prints info related to the wine items
            return this._idString+ this._descString + this._descString + this._packDec;
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
        public decimal Pack
        {
            get { return _packDec; }
            set { _packDec = value; }
        }
    }
}
