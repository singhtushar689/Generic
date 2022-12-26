using System.Xml.Linq;

namespace Generic
{
    public class Program
    {
        public static void FindMaximum<T>(T[] inputArray)
        {
            foreach(var element in inputArray)
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

            FindMaximum<int>(intArray);
            FindMaximum<char>(charArray);
            FindMaximum<double>(doubleArray);
        }
    }
}