using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace C_Sharp_Fundamentals
{
    class Find3SmallestNumbers
    {
        public static void Main(string[] args)
        {
            var numbers = new List<int> {1,2,3,4,5,6};//declare the List
            var smallests = GetSmallests(numbers, 3);
            foreach (var number in smallests) //Iterate over the List & display the numbers
                Console.WriteLine(number);
        }
        public static List<int> GetSmallests(List<int> list, int count)
        {
            var buffer = new List<int>(list);
            var smallests = new List<int>();
            while (smallests.Count < count)
            {
                var min = GetSmallest(buffer);
                smallests.Add(min);
                buffer.Remove(min);
            }
            return smallests;
        }
        public static int GetSmallest(List<int> list)
        {
            //Assume the first number is the smallest
            var min = list[0];
            for (var i = 1; i < list.Count; i++)
            {
                if (list[i] < min)
                    min = list[i];
            }
            return min;
        }
    }
}
