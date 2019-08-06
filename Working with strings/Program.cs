using System;

namespace Working_with_strings
{
    class Program
    {
        static void Main(string[] args)
        {
         
            string phrase = "Giraffe Academy";
            Console.WriteLine( phrase.Substring(8, 3) );  //start at 8 and use three characters altogether eg. Aca

            Console.ReadLine();
            
        }
    }
}
