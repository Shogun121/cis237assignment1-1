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
        }

        //Methods--1: ToString Override
        public override string ToString()
        {   //prints info related to the wine items
            return this._idString;
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
