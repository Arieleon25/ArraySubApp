using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ArraySubApp
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Arrays Submission Assignment - ONLY INPUT NUMBERS ");
            Console.WriteLine("Select an index of the following string Array: ");
            Console.WriteLine("{Arie, Dana, Rafa, Eliel, Rigi} ");

            string[] strArray = { "Arie", "Dana", "Rafa", "Eliel", "Rigi" };

            //Array.ForEach(strArray, Console.WriteLine);

            string strInput = Console.ReadLine();

            if (strInput == "0")
            {
                Console.WriteLine(strArray[0]);
            }
            else if (strInput == "1")
            {
                Console.WriteLine(strArray[1]);
            }
            else if (strInput == "2")
            {
                Console.WriteLine(strArray[2]);
            }
            else if (strInput == "3")
            {
                Console.WriteLine(strArray[3]);
            }
            else if (strInput == "4")
            {
                Console.WriteLine(strArray[4]);
            }
            else
            {
                Console.WriteLine("Try a number between 0 and 4");
            }

            Console.WriteLine("Select an index of the following integer Array: ");
            Console.WriteLine("{ 10, 20, 30, 40, 50, 60, 70 }");

            int[] intArray = { 10, 20, 30, 40, 50, 60, 70 };

            int intInput = Convert.ToInt32(Console.ReadLine());

            if (intInput == 0)
            {
                Console.WriteLine(intArray[0]);
            }
            else if (intInput == 1)
            {
                Console.WriteLine(intArray[1]);
            }
            else if (intInput == 2)
            {
                Console.WriteLine(intArray[2]);
            }
            else if (intInput == 3)
            {
                Console.WriteLine(intArray[3]);
            }
            else if (intInput == 4)
            {
                Console.WriteLine(intArray[4]);
            }
            else if (intInput == 5)
            {
                Console.WriteLine(intArray[5]);
            }
            else if (intInput == 6)
            {
                Console.WriteLine(intArray[6]);
            }
            else
            {
                Console.WriteLine("Try a number between 0 and 6");
            }

            Console.WriteLine("Select an index from the list: ");
            Console.WriteLine("item 1, item 2, item 3");

            List<string> stringList = new List<string>();
            stringList.Add("item 1");
            stringList.Add("item 2");
            stringList.Add("item 3");

            string listInput = Console.ReadLine();

            if (listInput == "0")
            {
                Console.WriteLine(stringList[0]);
            }
            else if (listInput == "1")
            {
                Console.WriteLine(stringList[1]);
            }
            else if (listInput == "2")
            {
                Console.WriteLine(stringList[2]);
            }
            else
            {
                Console.WriteLine("Try a number between 0 and 2");
            }

            Console.ReadLine();
        }
    }
}
