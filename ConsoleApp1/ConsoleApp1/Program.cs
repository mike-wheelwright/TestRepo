using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Mainline
{
    class Program
    {
        static void Main(string[] args)
        {
            Car myCar = new Car();

            myCar.Ride();

            var friday = Enums.Days.Friday;

            Console.WriteLine(friday);
            Console.WriteLine(friday.GetType());

            int[] table = { 1, 2, 3, 4 };

            var myList = new List<Car>();

            foreach(int el in table)
            {
                myList.Add(new Car("white"));
            }


            foreach(Car obj in myList)
            {
                Console.WriteLine(value: obj.Color);
            }


            // LINQ query returning from myList all Car objects
            // with "white" as color value;
            var whiteCars = from car in myList
                            where car.Color == "white"
                            select car;



            Console.WriteLine(table[1]);

            Console.WriteLine(Array.BinarySearch(table, 2));

            var newList = new List<ISteerable>();
            

            bool IsAnagram(string word)
            {
                char[] invertedWord = word.ToCharArray();
                
                Array.Reverse(invertedWord);

                string invertedString = new string(invertedWord);
             
                if(string.Equals(word, invertedString))
                {
                    return true;
                }
                else
                {
                    return false;
                }
            }


            Console.WriteLine(IsAnagram("aoa"));


            // Exceptions //


            try
            {
                int[] myTab = new int[2];
                myTab[0] = 1;
                myTab[1] = 2;
                int element = myTab[10];
            }
            catch(IndexOutOfRangeException exception)
            {
                Console.WriteLine("Error: " + exception.Message);
            }
            catch(Exception exception)
            {
                Console.WriteLine("Another error: " + exception );
            }



            Console.ReadKey();
        }
    }
}
