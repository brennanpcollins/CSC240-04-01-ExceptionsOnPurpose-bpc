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
            catch(Exception e)
            {
                WriteLine(e.Message);
            }

            WriteLine("The answer is " + answer);

            //OUTPUT
        }
    }
}
