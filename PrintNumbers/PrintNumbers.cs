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


        //Print the prime numbers

        public List<string> PrintPrimeNumbers(int sNumber, int eNumber)
        {
            for (int j = sNumber; j <= eNumber; j++)
            {
                if (j == 0)
                {
                    numbers.Add("0");
                }
                else if (j == 1)
                {
                    numbers.Add("1");
                }
                else
                {
                    for (int i = 2; i <= j - 1; i++)
                    {


                        if (j % i == 0)
                        {
                            numbers.Add(j.ToString());
                            break;
                        }
                        else if (i == (j - 1))
                        {
                            numbers.Add("Prime");
                            break;
                        }
                    }

                }
            }

            return numbers;
        }

        //Print the Composit numbers

        public List<string> PrintCompositNumbers(int sNumber, int eNumber)
        {
            for (int j = sNumber; j <= eNumber; j++)
            {
                if (j == 0)
                {
                    numbers.Add("0");
                }
                else if (j == 1)
                {
                    numbers.Add("1");
                }
                else
                {
                    for (int i = 2; i <= j - 1; i++)
                    {


                        if (j % i == 0)
                        {
                            if (j % 2 == 0)
                            {
                                numbers.Add(j.ToString());
                                break;
                            }
                            else
                            {
                                numbers.Add("Composit");
                                break;
                            }

                        }
                        else if (i == (j - 1))
                        {
                            numbers.Add(j.ToString());
                            break;
                        }
                    }

                }
            }

            return numbers;
        }

    }
}
