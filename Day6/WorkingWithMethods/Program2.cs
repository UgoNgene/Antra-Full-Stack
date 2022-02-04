using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WorkingWithMethods
{
    class Program2
    {
        public static int Fibonacci(int n)
        {
            if (n <= 1)
            {
                return n;
            }
            else
            {
                return Fibonacci(n - 1) + Fibonacci(n - 2);
            }
        }
        
        public static void printFibonacci()
        {
            int n =  10;
            int f1 = 1, f2 = 1, i;
            if( n <= 1)
            {
                return;
            }
            Console.Write(f1 +" ");
           
            for(i =1; i < n; i++)
            {
                Console.Write(f2 + " ");
                int next = f1 + f2;
                f1 = f2;
                f2 = next;
            }    
        }
        
        static void Main(string[] args)
        {
       
            printFibonacci();
            int input = 9;
            int numSequence = Fibonacci(input);
            Console.WriteLine("\n" + "Sequence: " +numSequence);

        }
    }
}
