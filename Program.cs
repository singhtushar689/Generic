using System.Xml.Linq;

namespace Generic
{
    public class Program
    {
       
        public static void Main(string[] args)
        {
            FIndMax max= new FIndMax();
            
            float firstNumber = 5.6f;
            float secondNumber = 7.7f;
            float thirdNumber = 9.8f;
            float result = max.FindMaxFloat(firstNumber, secondNumber, thirdNumber);
            Console.WriteLine("The maximum float number among the three float number is {0}",result);
        }
    }
}