using System;

namespace BasicCorePrograms_CS
{/// <summary>
/// Template for power of two
/// </summary>
    class PowerTwo
    {
        public static void PowerCalci()
        {
            //taking input from user
            Console.WriteLine("Enter the power of 2 till you want to display");
            int num = Convert.ToInt32(Console.ReadLine());
            for(int count=1; count<=num; count++)
            {
                //using Math.Pow method() to calulate power
                //Pow method(2,count) means 2 to the power count
                double pow = Math.Pow(2,count);
                Console.WriteLine("power of 2 of {0} is {1}",+count,+pow);
            }
        }
        static void Main(string[] args)
        {
            PowerTwo.PowerCalci();
            Console.ReadLine();
        }
    }
}
