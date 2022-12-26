using System.Xml.Linq;

namespace Generic
{
    public class Program
    {
       
        public static void Main(string[] args)
        {
            FIndMax max= new FIndMax();

            string first = "Tushar";
            string second = "Sachin";
            string third = "Rohan";
            string result = max.FindMaxString(first, second, third);
            Console.WriteLine("The maximum String among the three strings is {0}",result);
        }
    }
}