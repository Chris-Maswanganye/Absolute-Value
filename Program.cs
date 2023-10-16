using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Absolute_Value
{
    internal class Program
    { 
            static int AbsoluteValue(int num)
            {
                return num < 0 ? -num : num;
            }

            static void Main()
            {
                int number1 = 6832;
                int result1 = AbsoluteValue(number1);
                Console.WriteLine(result1);

                int number2 = -392;
                int result2 = AbsoluteValue(number2);
                Console.WriteLine(result2);
            }
        }

    }
