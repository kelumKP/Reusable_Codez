using System;
using System.Collections.Generic;
using System.Text;

namespace sampleTestProject
{
    class ca1
    {
        static void MainProgram(string[] args)
        {
            Xtremax_FindOccurance sampleProgram = new Xtremax_FindOccurance();

            int[] A = { 10, 2, 4, 5 };
            int X = 10;
            Console.WriteLine(sampleProgram.solution(A, X));
        }
        public int solution(int[] A, int X)
        {
            int N = A.Length;
            if (N == 0)
            {
                return -1;
            }
            int l = 0;
            int r = N - 1;
            while (l < r)
            {
                int m = (l + r) / 2;
                if (A[m] >= X)
                {
                    r = m - 1;
                }
                else
                {
                    l = m;
                }
            }
            if (A[l] == X)
            {
                return l;
            }
            return -1;
        }
    }
}


---------------------------------------------------------------------------
// Cat

using System;
using System.Collections;
using System.Collections.Generic;
using System.Text;

namespace sampleTestProject
{
    class CatProblem
    {
        ArrayList testResultArray = new ArrayList();
        static void MainProgram(string[] args)
        {
            CatProblem sampleProgram = new CatProblem();

            var myInput = Console.ReadLine();
            int numberOfInputs = Convert.ToInt32(myInput.Trim());

            while (numberOfInputs > 0)
            {
                string stringValue = Console.ReadLine();
                string[] stringArray = stringValue.Split(' ');
                int[] intArray = Array.ConvertAll(stringArray, s => int.Parse(s));
                sampleProgram.solution(intArray);
                numberOfInputs--;
            }

            foreach (string arry in sampleProgram.testResultArray)
            {
                Console.WriteLine(arry);
            }
        }

        public void solution(int[] A)
        {
            int firstCatAge = A[0];
            int firstCatPosition = A[1];
            int secondCatAge = A[2];
            int secondCatPosition = A[3];

            if (secondCatPosition > firstCatPosition)
            {

                while ((secondCatPosition - firstCatPosition) > 2)
                {
                    secondCatPosition = secondCatPosition - 2;
                    firstCatPosition = firstCatPosition + 1;
                }

                if ((secondCatPosition - firstCatPosition) == 1)
                {
                    testResultArray.Add("0");
                }
                else
                {
                    testResultArray.Add("1");
                }

            }
            else
            {
                while ((firstCatPosition - secondCatPosition) > 2)
                {
                    firstCatPosition = firstCatPosition - 2;
                    secondCatPosition = secondCatPosition + 1;
                }


                if ((firstCatPosition - secondCatPosition) == 1)
                {
                    testResultArray.Add("0");
                }
                else
                {
                    testResultArray.Add("1");
                }

            }

        }
    }
}

----------------------------------------------------------------------------

// Cat

using System;
using System.Collections;
using System.Collections.Generic;
using System.Text;

namespace sampleTestProject
{
    class CatProblem_1
    {
        ArrayList testResultArray = new ArrayList();
        static void MainProgram(string[] args)
        {
            CatProblem_1 sampleProgram = new CatProblem_1();

            var myInput = Console.ReadLine();
            int numberOfInputs = Convert.ToInt32(myInput.Trim());

            while (numberOfInputs > 0)
            {
                string stringValue = Console.ReadLine();
                string[] stringArray = stringValue.Split(' ');
                int[] intArray = Array.ConvertAll(stringArray, s => int.Parse(s));
                sampleProgram.solution(intArray);
                numberOfInputs--;
            }

            foreach (string arry in sampleProgram.testResultArray)
            {
                Console.WriteLine(arry);
            }
        }

        public void solution(int[] A)
        {
            int firstCatAge = A[0];
            int firstCatPosition = A[1];
            int secondCatAge = A[2];
            int secondCatPosition = A[3];

            string isFirstCatWin = null;

            if (firstCatAge > secondCatAge)
            {
                if ((firstCatPosition - secondCatPosition) >= 1)
                {
                    if ((firstCatPosition - secondCatPosition) == 1)
                    {
                        firstCatPosition = firstCatPosition - 1;
                        isFirstCatWin = "0";
                    }
                    else if ((firstCatPosition - secondCatPosition) == 2)
                    {
                        firstCatPosition = firstCatPosition - 1;
                        isFirstCatWin = "1";
                    }
                    else
                    {
                        while ((firstCatPosition - secondCatPosition) > 2)
                        {
                            firstCatPosition = firstCatPosition - 2;
                            isFirstCatWin = "1";

                            if ((firstCatPosition - secondCatPosition) == 2)
                            {
                                secondCatPosition = secondCatPosition + 1;
                                isFirstCatWin = "0";
                            }
                            if ((firstCatPosition - secondCatPosition) > 2)
                            {
                                secondCatPosition = secondCatPosition + 2;
                                isFirstCatWin = "0";
                            }
                        }
                    }
                }
                else
                {
                    if ((secondCatPosition - firstCatPosition) == 1)
                    {
                        secondCatPosition = secondCatPosition - 1;
                        isFirstCatWin = "0";
                    }
                    else if ((secondCatPosition - firstCatPosition) == 2)
                    {
                        firstCatPosition = firstCatPosition + 1;
                        isFirstCatWin = "1";
                    }
                    else
                    {
                        while ((secondCatPosition - firstCatPosition) > 2)
                        {
                            firstCatPosition = firstCatPosition + 2;
                            isFirstCatWin = "1";

                            if ((secondCatPosition - firstCatPosition) == 2)
                            {
                                secondCatPosition = secondCatPosition - 1;
                                isFirstCatWin = "0";
                            }
                            if ((secondCatPosition - firstCatPosition) > 2)
                            {
                                secondCatPosition = secondCatPosition - 2;
                                isFirstCatWin = "0";
                            }
                        }
                    }

                }
            }
            else
            {
                if ((firstCatPosition - secondCatPosition) >= 1)
                {
                    if ((firstCatPosition - secondCatPosition) == 1)
                    {
                        firstCatPosition = firstCatPosition - 1;
                        isFirstCatWin = "1";
                    }
                    else if ((firstCatPosition - secondCatPosition) == 2)
                    {
                        secondCatPosition = secondCatPosition + 1;
                        isFirstCatWin = "0";
                    }
                    else
                    {
                        while ((firstCatPosition - secondCatPosition) > 2)
                        {
                            secondCatPosition = secondCatPosition + 2;
                            isFirstCatWin = "0";

                            if ((firstCatPosition - secondCatPosition) == 2)
                            {
                                firstCatPosition = firstCatPosition - 1;
                                isFirstCatWin = "1";
                            }
                            if ((firstCatPosition - secondCatPosition) > 2)
                            {
                                firstCatPosition = firstCatPosition - 2;
                                isFirstCatWin = "1";
                            }
                        }
                    }
                }
                else
                {
                    if ((secondCatPosition - firstCatPosition) == 1)
                    {
                        secondCatPosition = secondCatPosition - 1;
                        isFirstCatWin = "1";
                    }
                    else if ((secondCatPosition - firstCatPosition) == 2)
                    {
                        secondCatPosition = secondCatPosition - 1;
                        isFirstCatWin = "0";
                    }
                    else
                    {
                        while ((secondCatPosition - firstCatPosition) > 2)
                        {
                            secondCatPosition = secondCatPosition - 2;
                            isFirstCatWin = "0";

                            if ((secondCatPosition - firstCatPosition) == 2)
                            {
                                firstCatPosition = firstCatPosition + 1;
                                isFirstCatWin = "1";
                            }
                            if ((secondCatPosition - firstCatPosition) > 2)
                            {
                                firstCatPosition = firstCatPosition + 2;
                                isFirstCatWin = "1";
                            }
                        }
                    }

                }
            }

            testResultArray.Add(isFirstCatWin);
        }
    }
}

---------------------------------------------------------------------

// Swapping

using System;
using System.Collections.Generic;
using System.Text;

namespace sampleTestProject
{
    class Cobaltum2018_Swapping
    {
        static void MainProgram(string[] args)
        {
            Cobaltum2018_Swapping sampleProgram = new Cobaltum2018_Swapping();

            //int[] A = { 5, 3, 7, 7, 10 };
            //int[] B = { 1, 6, 6, 9, 9 };

            //int[] A = { 5, -3, 6, 4, 8 };
            //int[] B = { 2, 6, -5, 1, 0 };

            //int[] A = { 1, 5, 6 };
            //int[] B = { -2, 0, 2 };

            int[] A = { 1, 3 };
            int[] B = { 1, 6 };

            Console.WriteLine(sampleProgram.solution(A, B));
        }

        public int solution(int[] A, int[] B)
        {
            int count = 0;
            int sortedArray = 0;

            for (int i = 0; i < A.Length - 1; i++)
            {

                if (A[i] >= A[i + 1])
                {
                    if (B[i] <= A[i + 1] && A[i + 1] <= B[i + 1] && A[i] <= B[i + 1] && B[i + 1] >= A[i + 1])
                    {
                        // swapping
                        int temp = A[i + 1];
                        A[i + 1] = B[i + 1];
                        B[i + 1] = temp;
                        count++;
                    }
                }
                else
                {
                    sortedArray++;
                }

            }

            if (sortedArray == A.Length - 1)
            {
                return 0;
            }
            if (count == 0)
            {
                return -1;
            }
            else
            {
                return count;
            }
        }
    }

    
}

--------------------------------------------------------------------------


using System;
using System.Collections.Generic;
using System.Text;
using System.Linq;

namespace sampleTestProject
{
    class Nickle2018_Tree
    {

        int trueValues = 0;
        static void MainProgram(string[] args)
        {
            Nickle2018_Tree sampleProgram = new Nickle2018_Tree();

            string stringValue = Console.ReadLine();
            string[] stringArray = stringValue.Split(' ');
            bool[] booleanArray = Array.ConvertAll(stringArray, s => bool.Parse(s));
            sampleProgram.solution(booleanArray);

            Console.WriteLine(sampleProgram.trueValues);
        }

        public void solution(bool[] P)
        {
            while (P.Length > 1)
            {
                // Count True in array 
                trueValues = trueValues + P.Where(c => c).Count();

                for (int i = 0; i < P.Length - 1; i++)
                {
                    P[i] = P[i] || P[i + 1];
                }

                var list = new List<bool>(P);
                list.RemoveAt(P.Length - 1);
                P = list.ToArray();
            }

            trueValues = trueValues + P.Where(c => c).Count();

        }
    }
}


---------------------------------------------------------------


// smallest integer

using System;
using System.Collections.Generic;
using System.Text;
using System;
using System.Linq;

namespace sampleTestProject
{
    class SmallestInteger
    {
        static void MainProgram(string[] args)
        {
            SmallestInteger sampleProgram = new SmallestInteger();

            // Sample Array
            int[] A = { 4, 4, 5, 6, 7, 1, 2, 2, 4, 5 };
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

-------------------------------------------------------------------


// Depth of Binary Tree

using System;
using System.Collections.Generic;
using System.Text;

namespace sampleTestProject
{
    class Xtremax_DepthBinaryTree
    {
        static void MainProgram(string[] args)
        {
            Program sampleProgram = new Program();

            int[] A = { 10, 2, 4, 5 };
            int X = 10;
           // Console.WriteLine(sampleProgram.solution(T));
        }

        public int solution(Tree T)
        {
            return 2;
        }
    }

    public class Tree
    {
        public int x;
        public Tree l;
        public Tree r;
    }
}


----------------------------------------------------------------

// Find the occurence

using System;
using System.Collections.Generic;
using System.Text;

namespace sampleTestProject
{
    class Xtremax_FindOccurance
    {
        static void MainProgram(string[] args)
        {
            Xtremax_FindOccurance sampleProgram = new Xtremax_FindOccurance();

            int[] A = { 10, 2, 4, 5 };
            int X = 10;
            Console.WriteLine(sampleProgram.solution(A, X));
        }
        public int solution(int[] A, int X)
        {
            int N = A.Length;
            if (N == 0)
            {
                return -1;
            }
            int l = 0;
            int r = N - 1;
            while (l < r)
            {
                int m = (l + r) / 2;
                if (A[m] >= X)
                {
                    r = m - 1;
                }
                else
                {
                    l = m;
                }
            }
            if (A[l] == X)
            {
                return l;
            }
            return -1;
        }
    }
}


------------------------------------------------------

// Reverse Word

using System;
using System.Collections.Generic;
using System.Text;
using System.Linq;

namespace sampleTestProject
{
    class Xtremax_ReverseWord
    {
        static void MainProgram(string[] args)
        {
            Xtremax_ReverseWord sampleProgram = new Xtremax_ReverseWord();

            string cmdSentence = Console.ReadLine();
            Console.WriteLine(sampleProgram.solution(cmdSentence));
        }

        public String solution(String S)
        {
            var reversedWords = string.Join(" ", S.Split(' ').Select(x => new String(x.Reverse().ToArray())));
            return reversedWords;
        }
    }
}

---------------------------------------------------
