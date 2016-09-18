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
    class Program
    {
        static void Main(string[] args)
        {
            UserInterface uI = new UserInterface();
            uI.GetInput();

            while(uI.UserInput!="5")
            {
                uI.GetInput();
                uI.MenuChoice();
            }      
            //WineItemClass wiC = new WineItemClass();
            //Console.WriteLine(wiC.ToString());

        }
    }
}
