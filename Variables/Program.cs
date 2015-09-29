using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Variables
{
    class Program
    {
        static void Main(string[] args)
        {
            //int x;
            //int y;

            //x = 7;
            //y = x + 3;
            //Console.WriteLine(y);

            //string myFirstName;
            //myFirstName = "Heniekk";

            //declare variable with var. Compiler will choose what type it is.
            //var myFirstName = "Heniekk";

            //string myFirstName = "Heniekk";
            //Console.WriteLine(myFirstName);

            //Implicit (without ToString()) data conversion (intigers and strings together)
            int x = 7;
            string yy = "Heniekk";
            string y = "5";
            //Here .Net can convert 7 to "7" - its mathematically correct
            string myFirstTry = x.ToString() + y;
            //Below .Net cant convert "Heniekk" to integer. Its impossible
            //int mySeconfTry = x + y;

            //Explicytly data conversion 
            int mySecondTry = x + int.Parse(y);

            Console.WriteLine(myFirstTry);

            //Console.WriteLine(mySecondTry);

            Console.ReadLine();
        }
    }
}
