// See https://aka.ms/new-console-template for more information
using System;

namespace ReverseString
{
    class Program
    {
        static void Main(string[] args)
        {
            string res = "";

            do
            {
                Console.WriteLine("Enter text:");
                res = Console.ReadLine();
                if (res!=""){
                    //Using Reverse method
                    Console.WriteLine($"Reverse: {Reverse(res)}");

                    // //Without Reverse method
                    Console.WriteLine($"Reverse: {Reverse_2(res)}");
                }
                         
            } while (res!="exit");        
        }

        ///
        //Using Reverse method
        ///
        static string Reverse(string x) {
          
          char[] char_x = x.ToCharArray();
          Array.Reverse(char_x);     
          return new string(char_x);     
        }

        //Without Reverse method
        static string Reverse_2(string x)
        {
            char[] c_x = x.ToCharArray();
            string rev = string.Empty;

            for (int i = c_x.Length-1;i>-1;i--)
            {
                rev = rev + c_x [i];
            }

            return rev;

        }
    }
}
