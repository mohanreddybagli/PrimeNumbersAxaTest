using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PrintNumberTypes
{
   public class PrintNumbers
    {
         
        //Printing numbers in given range   
        List<string> numbers = new List<string>();
        public List<string> Print(int sNumber, int eNumber)
        {

            for (int i = sNumber; i <= eNumber; i++)
            {
                numbers.Add(i.ToString());
            }
            return numbers;
        }

    }
}
