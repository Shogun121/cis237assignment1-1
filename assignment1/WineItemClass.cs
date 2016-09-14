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
            //Takes three parameters......-FINISH-
        public WineItemClass(string idString,string descString, int packInt)
        {

        }

        //Methods: NONE

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
