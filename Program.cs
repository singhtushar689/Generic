using System.Xml.Linq;

namespace Generic
{
    public class Program
    {
       
        public static void Main(string[] args)
        {
            FIndMax max= new FIndMax();
            
            int firstNumber = 56;
            int secondNumber = 77;
            int thirdNumber = 98;
            int result = max.FindMaxInteger(firstNumber, secondNumber, thirdNumber);
            Console.WriteLine(result);
        }
    }
}