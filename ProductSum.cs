using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TheChallenge
{
    public class ProductSum
    {
        public static int CalculateProductSum(List<object> listOfObjects, int multiplier)
        {
            int sum = 0;

            foreach (object item in listOfObjects)
            {
                if (item is List<object> lists)
                {
                    sum += CalculateProductSum(lists, multiplier + 1);
                }

                else
                {
                    sum += (int)item;
                }
            }

            return sum * multiplier;
        }
        
        public static int CalculateProductSum(List<object> listOfObjects)
        {
            return CalculateProductSum(listOfObjects, 1);
        }

        public static void CalculateProductSum()
        {
            List<object> lists = new()
            {
                4,
                7,
                new List<object> { 9, -4 },
                4,
                new List<object> { 5, new List<object> { -11, 7 }, 3 }
            };

            Console.WriteLine(ProductSum.CalculateProductSum(lists));
        }
    }
}


//[3, 7, [9, -4], 4, [5, [-11, 7], 3]]
 
// [14 + 10 - 8] * 1 = 16

// Tech Training Bootcamp UK
