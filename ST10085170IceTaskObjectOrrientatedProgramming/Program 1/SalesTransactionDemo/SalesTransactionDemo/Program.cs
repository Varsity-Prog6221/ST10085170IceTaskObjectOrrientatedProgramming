using System;

namespace SalesTransactionDemo
{
    class Program
    {
        static void Main(string[] args)
        {


            Console.WriteLine("Get Ready to enter your details");



            Console.WriteLine("Please enter your name");
            String sName = Console.ReadLine();


            Console.WriteLine("Please enter your Sales Amount");
            float SalesAmount = float.Parse(Console.ReadLine());

            Console.WriteLine("Please enter your Commision Rate");
            float CommissionRate = float.Parse(Console.ReadLine());


            SalesTransactionDemo1 myObj = new SalesTransactionDemo1(sName, SalesAmount,CommissionRate);
            myObj.Display(); 




        }
    }
}
