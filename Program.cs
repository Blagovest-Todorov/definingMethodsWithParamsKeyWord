using System;
using System.Linq;

namespace moreTest
{
    class Program
    {
        static void Main()
        {
            decimal[] nums = new decimal[] { 10, 2, 7 };
            PrintTotalAmountBooks(nums);
        }

        // keyword params into () allow us to call a mehtod with variable number of arguments
        static void PrintTotalAmountBooks(params decimal[] prices)
        {
            decimal totalAmount = 0;

            foreach (int singleBookPrice in prices)
            {
                totalAmount += singleBookPrice;
            }

            Console.WriteLine("the Total amount of all books is: " + totalAmount);
        }        
    }    
}
