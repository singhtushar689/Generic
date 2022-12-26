using System.Xml.Linq;

namespace Generic
{
    public class Program
    {
        public static void FindMaximum(int[] inputArray)
        {
            foreach(int element in inputArray)
            {
                Console.WriteLine(element);
            }

        }
        public static void FindMaximum(double[] inputArray)
        {
            foreach(double element in inputArray)
            {
                Console.WriteLine(element);
            }
        }
        public static void FindMaximum(char[] inputArray)
        {
            foreach(char element in inputArray) 
            { 
                Console.WriteLine(element); 
            }
        }

       public static void Main(string[] args) 
       {
            Console.WriteLine("Hello World!");
            int[] intArray = { 3, 7, 2, 9, 8, 6, 1, 5, 4 };
            char[] charArray = { 'a', 'b', 'd', 'e', 'f' };
            double[] doubleArray = { 8.6, 9.7, 5.8, 2.6, 3.9 };

            FindMaximum(intArray);
            FindMaximum(charArray);
            FindMaximum(doubleArray);
        }
    }
}