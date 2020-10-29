using System;
using static System.Console;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SubScriptExceptionTest
{
    class Program
    {
        static void Main(string[] args)
        {
            double[] arr = new double[] { 
                123, 
                234, 
                345,
                456,
                567,
                678,
                789,
                8910,
                91011,
                101112 
            };
            while (true)
            {
                try
                {
                    for (int i = 0; i < arr.Length; i++)
                    {
                        Write("\nEnter a subscript possition between 0 & 9 to see the value stored there: ");
                        int user = Convert.ToInt32(ReadLine());

                        Write("The value stored in that posistion is: " + arr[user] + "\n");
                    }
                }
                catch (IndexOutOfRangeException e)
                {
                    WriteLine("*ERROR " + e.Message + " Please try again.");

                }
            }
            
        }
    }
}
