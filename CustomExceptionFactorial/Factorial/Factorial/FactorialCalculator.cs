using Factorial.Exceptions;
using Factorial.Exceptions.Messages;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Text;
using System.Threading.Tasks;

namespace Factorial
{
    public class FactorialCalculator
    {
        public static int? GetFactorial(int num)
        {

            int result = 1;

            if (num < 0) throw new NegativeNumberException(ExceptionMessages.NegativeNumber);

            else
            {
                for (int i = 1; i <= num; i++)
                {
                    result *= i;

                }
                return result;
            }
        }
        // public static int? GetFactorial(this int num)
        //{

        //        int result = 1;

        //        if (num < 0) throw new NegativeNumberException(ExceptionMessages.NegativeNumber);

        //        else
        //        {
        //            for (int i = 1; i <= num; i++)
        //            {
        //                result *= i;

        //            }
        //            return result;
        //        }
        //}

    }
}
