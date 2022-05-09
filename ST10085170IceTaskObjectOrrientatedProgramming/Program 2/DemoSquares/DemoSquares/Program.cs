using System;

namespace DemoSquares
{
    class Program
    {
        static void Main(string[] args)
        {

            Random rnd = new Random(); 
            Squares[] myArray = new Squares[10];


            for (int i = 0; i < myArray.Length; i++)
            {

                myArray[i] = new Squares(rnd.Next(1,10)); 

            }



            for (int i = 0; i < myArray.Length; i++)
            {

                Console.WriteLine(myArray[i].ReturnArea);

            }



        }
    }
}
