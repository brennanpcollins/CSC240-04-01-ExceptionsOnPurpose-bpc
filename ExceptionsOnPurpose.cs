﻿using System;
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
            int answer;
            int result;
            int zero = 0;
            Write("Enter an integer >> ");
            answer = Convert.ToInt32(ReadLine());
            result = answer / zero;
            WriteLine("The answer is " + answer);
        }
    }
}