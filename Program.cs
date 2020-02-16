using System;

namespace basic_lesson1
{
    class Program
    {
        static void Main(string[] args)
        {

            //Console.Write("Enter number fo digit check: ");
            //int x = Convert.ToInt32(Console.ReadLine());
            //if (x >= 0 && x <= 9)
            //{
            //    // YES
            //    Console.WriteLine("1 digit");
            //}
            //else if (x >= 10 && x <= 99)
            //{
            //    // YES
            //    Console.WriteLine("2 digits");
            //}
            //else
            //{
            //    // Everything before was not true
            //    Console.WriteLine("3 or more digits...");
            //}
            Console.Write("please enter  any number:");
            int num = int.Parse(Console.ReadLine());

            if (num != 0)
            {
                int digit1 = num % 10; 
                Console.WriteLine("1", digit1);
              
            }
            else if (num>10&& num<=99)
            {
            
            Console.WriteLine("2" );
            }
            else
            {
                Console.WriteLine("number  bigger than 99 " );    
            }
           
            
        }
    }
}
