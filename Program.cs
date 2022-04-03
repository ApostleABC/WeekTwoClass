using System;

namespace WeekTwoClass
{
    class Program
    {
        static void Main(string[] args)
        {
            string myName = "Blessing Arowele";
            int myAge = 26;
            double GBPtoUSD = 1.32;
            int GBPtoUSDint = (int) GBPtoUSD;
            int myAgeint = myAge;
            double myAgedouble = (double) myAge;
            float a = myAge;
            long b = myAge;
           

        

            Console.WriteLine("Hello Backend, WellaHealth Schools!");
            Console.WriteLine(myName);
            Console.WriteLine(myAge);
            Console.WriteLine(GBPtoUSD);
            Console.WriteLine(GBPtoUSDint);
            Console.WriteLine(myAgeint);
            Console.WriteLine(myAgedouble);
            Console.WriteLine(a);
            Console.WriteLine(b);


        }
    }
}
