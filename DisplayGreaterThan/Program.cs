using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DisplayGreaterThan
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Program displays number greater than 50 from the list of given numbers");
            List<int> myList = new List<int> { 15, 20, 45, 18, 125, 258};

            var text = "The numbers on the list are: ";
            var n = 0;

            foreach (var i in myList)
            {
                text += i;
                if (n != myList.Count -1)
                {
                    text += ", ";
                }
            }
            Console.WriteLine(text);

            var myNumbers = from no in myList
                            where no > 50
                            select no;

            List<int> newList = myList.FindAll(p => p > 50);

            Console.WriteLine("First check by LINQ query");
            foreach (var i in myNumbers)
            {
                Console.WriteLine(i);
            }
            Console.WriteLine("Second check by LINQ method");
            foreach (var i in newList)
            {
                Console.WriteLine(i);
            }
            Console.ReadKey();
        }
    }
}
