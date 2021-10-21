using System;
using static System.Console;

/* Author:          Brennan Collins
 * Date:            10/21/2021
 * Description:     The YouDoIt exercises from Chapter 11
 * Resources:
*/

namespace CSC240_04_01_ExceptionsOnPurpose_bpc
{
    class ExceptionsOnPurpose
    {
        static void Main()
        {
            //STORAGE
            int answer = 0;
            int result;
            int zero = 0;

            try
            {
                //INPUT
                Write("Enter an integer >> ");
                answer = Convert.ToInt32(ReadLine());

                //PROCESS
                result = answer / zero;
            }
            catch(FormatException e)
            {
                WriteLine("You did not enter an integer.");
            }
            catch(DivideByZeroException e)
            {
                WriteLine("This is not your fault.");
                WriteLine("You entered the integer correctly.");
                WriteLine("The program divides by zero");
            }

            WriteLine("The answer is " + answer);

            //OUTPUT
        }
    }
}
