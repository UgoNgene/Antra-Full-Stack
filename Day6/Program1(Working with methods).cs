using System;
namespace WorkingWithMethods
{
    class Program
    {
        
        public static int[] GenerateNumbers()
        {
          
            int[] numbers = new int[10];
       

            for(int i=0; i<numbers.Length; i++)
            {
                numbers[i] = i + 1;
            }
      
            return numbers;
        }
        public static int[] GenerateNumbers(int arrayLength)
        {
         
            int[] numbers = new int[arrayLength];


            for (int i = 0; i < numbers.Length; i++)
            {
                numbers[i] = i + 1;
            }
            

            return numbers; 
        }

        public static void Reverse(int[] numbers)
        {
            int i = 0;
            int j = numbers.Length - 1;

            while (i < j)
            {
                int temp = numbers[i];
                
                numbers[i] = numbers[j];
                numbers[j] = temp;
                i++;
                j--;
            }
        }

        public static void PrintNumbers(int[] numbers)
        {
            for (int i = 0; i < numbers.Length; i++)
            {
                if (i == numbers.Length - 1)
                {
                    Console.Write(numbers[i] + ".");
                    break;
                }
                Console.Write(numbers[i] + ", ");
            }
            Console.WriteLine("\n");
        }
        static void Main(string[] args)
        {

            int[] numbers = GenerateNumbers(20);

            Reverse(numbers);

            PrintNumbers(numbers);

        }
    }
}
