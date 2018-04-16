using System;
using System.Linq;

namespace sampleTestProject
{
    class Program
    {
        static void Main(string[] args)
        {
            Program sampleProgram = new Program();

            // Sample Array
            int[] A = { 4,4,5,6,7,1,2,2,4,5 };
            // Remove dplicates
            A = A.Distinct().ToArray();
            // Sort the array
            Array.Sort(A);
                    
           
            int smlVal = sampleProgram.solution(A);
            Console.WriteLine(smlVal);
        }

 
        // write your code in C# 6.0 with .NET 4.5 (Mono)
        public int solution(int[] A)
        {
            int smalllestInteger = 1;
            foreach (int arrayInteger in A)
            {
                if (arrayInteger > 0 && arrayInteger <= smalllestInteger)
                {
                    smalllestInteger = arrayInteger;
                    smalllestInteger++;
                }                
            }

            return smalllestInteger;
        }
    }
}
