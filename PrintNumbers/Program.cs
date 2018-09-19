using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PrintNumberTypes
{
   public class Program
    {
        static int startingNumber;
        static int endingNumber;
        static List<string> numbers = null;
        static void Main(string[] args)
        {

            Console.WriteLine("Select the number format to Print\n1) Normal\n2) Prime\n3) Composit");
            string numbertype = Console.ReadLine();
            Console.WriteLine("Please enter starting number ");
            startingNumber = Convert.ToInt16(Console.ReadLine());
            Console.WriteLine("Please enter ending number ");
            endingNumber = Convert.ToInt16(Console.ReadLine());

            PrintNumbers objPrintNumbers = new PrintNumbers();

            if (numbertype == "1")
            {
                numbers = objPrintNumbers.Print(startingNumber, endingNumber);
            }
            else if (numbertype == "2")
            {
                numbers = objPrintNumbers.PrintPrimeNumbers(startingNumber, endingNumber);
            }
            else if (numbertype == "3")
            {
                numbers = objPrintNumbers.PrintCompositNumbers(startingNumber, endingNumber);
            }
            foreach (string number in numbers)
            {
                Console.WriteLine(number);
            }
            Console.ReadLine();
        }
    }
}
