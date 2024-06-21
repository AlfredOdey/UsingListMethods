using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace UsingListMethod
{
    internal class Program
    {
        /*
        Question 8: Using List Methods
        Create a list of strings with the values
        {"apple", "banana", "cherry"}.
        Add "date" to the list.
        Remove "banana" from the list.
        Check if the list contains "cherry".
        Print all elements in the list.
        */
        static void Main(string[] args)
        {
            List<string> fruits = new List<string>
         {
             "apple", "banana", "cherry"
         };

            fruits.Add("date");
            fruits.Remove("banana");

            if (fruits.Contains("cherry"))
            {
                Console.WriteLine(true);
            }
            Console.WriteLine();
            for (int i = 0; i < fruits.Count; i++)
            {
                Console.WriteLine(fruits[i]);
            }
        }
    }
}
