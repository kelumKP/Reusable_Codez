using System;
using System.Collections.Generic;
using System.Text;

namespace SampleApp
{
    class Program
    {
        static void Main(string[] args)
        {

            Solution sol = new Solution();

            //int[] intArrsolutionArrListLen = new int[] { 1, 5, -1, 3, 2 , 4 , 6};
            // Console.WriteLine("Hello World! " + sol.solutionArrListLen3(intArrsolutionArrListLen));

            //int[] intsolutionLargestSequenceGap = new int[] { 10, 0, 8, 2, -1, 12, 11, 3 };   
            //Console.WriteLine("Hello World! " + sol.solutionLargestSequenceGap(intsolutionLargestSequenceGap));

            //bool[] intsolutionBugfixingMaxOnesSpan = new bool[] { false, true, true, true, false, true, true, true, false, true };
            //Console.WriteLine("Hello World! " + sol.solutionBugfixingMaxOnesSpan(intsolutionBugfixingMaxOnesSpan));

            //String unFormattedPhoneNo = "00-44   48    5555 8361";
            //Console.WriteLine("Hello World! " + sol.solutionFormatPhoneNumber(unFormattedPhoneNo));

            //int intVal = 955;
            //Console.WriteLine("Hello World! " + sol.solutionbugFixingBinaryPeriod(intVal));

            //int intVal = 123;
            //Console.WriteLine("Hello World! " + sol.solutionsDecReprSeniorCoding(intVal));

            //int[] intArrsolutionLightbulbs = new int[] { 2, 1, 3, 5, 4};
            //Console.WriteLine("Hello World! " + sol.solutionLightbulbs(intArrsolutionLightbulbs));

            //int intVal = 9;
            //Console.WriteLine("Hello World! " + sol.solutionBinaryGap(intVal));

            //string A = "A586QK";
            //string B = "JJ653K";
            //Console.WriteLine("Hello World! " + sol.solutionCards(A,B));

            //int[] intsolutionBugfixingCoins = new int[] { 1, 1, 0, 1, 0 , 0};
            //Console.WriteLine("Hello World! " + sol.solutionBugfixingCoins(intsolutionBugfixingCoins));

            //int[] intsolutionMinDist = new int[] { 8, 24, 3, 20, 1 , 17};
            //Console.WriteLine("Hello World! " + sol.solutionMinDist(intsolutionMinDist));

            //int[] intsolutionRemoveHalf = new int[] { 3, 4, 7, 7, 6, 6 };
            //Console.WriteLine("Hello World! " + sol.solutionRemoveHalf(intsolutionRemoveHalf));


            //int[] A = new int[] { 1, 3, 2, 1};
            //int[] B = new int[] { 4, 2, 5, 3, 2};
            //Console.WriteLine("Hello World! " + sol.solutionBugfixingFindCommonMin(A,B));

            //int[] intsolutionPrefixPermutations = new int[] { 2, 1, 3, 5, 4 };
            //Console.WriteLine("Hello World! " + sol.solutionPrefixPermutations(intsolutionPrefixPermutations));

            string intsolutionLongestSentence1 = "We test coders. Give us a try?";
            Console.WriteLine("Hello World! " + sol.solutionLongestSentence1(intsolutionLongestSentence1));
        }

    }

    class Solution
    {

        // ArrListLen score: 100 of 100
        // Compute length of a single-link list encoded in an array.
        public int solutionArrListLen(int[] A)
        {
             // write your code in Java SE 8
 
         int count = 0;
         bool end = false;
         int num = A[0];
            
         while (!end)
         {
          if (num >= 0)
          {
           num = A[num];
           count++;
          }
          else
          {
           count++;
           end = true;
          }
        }

          return count;
        }

        // ArrListLen2 score: 100 of 100
        // Compute length of a single-link list encoded in an array.
        public int solutionArrListLen2(int[] A)
        {
            int length = 1;
            int next = A[0];
            while (next != -1)
            {
                next = A[next];
                length += 1;
            }
            return length;
        }

        // ArrListLen2 score: 100 of 100
        // Compute length of a single-link list encoded in an array.
        public int solutionArrListLen3(int[] A)
        {
            List<int> resultList = new List<int>();
            int value = 0;
            for (int i = 0; i < A.Length; i++)
            {
                value = (i == 0) ? A[0] : A[value];
                resultList.Add(value);
                if (value == -1)
                {
                    break;
                } 
            }

            return resultList.Count; 
        }


        // LargestSequenceGap score: 100 of 100
        // Find the largest gap between given values.
        public int solutionLargestSequenceGap(int[] A)
         {
                //  write your code in Java SE 8
                int max = 0;
                int dist = 0;
                Array.Sort(A);
                for (int i = 0; (i
                            < (A.Length - 1)); i++)
                {
                    dist = (A[i] - A[(i + 1)]);
                    if ((Math.Abs(dist) > max))
                    {
                        max = Math.Abs(dist);
                    }

                }

                return (max / 2);
         }

        // BugfixingMaxOnesSpan 
        // Find and correct bugs in a procedure that finds the longest sequence of consecutive bits set to 1.
        public int solutionBugfixingMaxOnesSpan(bool[] A)
        {
             int n = A.Length;
             int i = n - 1;
             int result = -1;
             int k = 0, maximal = 0;
             while (i > 0)
             {
                 if (A[i] == true)
                 {
                     k = k + 1;
                     if (k >= maximal)
                     {
                         maximal = k;
                         result = i;
                     }
                 }
                 else
                 {
                    k = 0;
                 }
                    
                    i = i - 1;
             }
                 if (A[i] == true && k + 1 >= maximal)
                 {
                    result = 0;
                 }
                 
             return result;
        }

        //  FormatPhoneNumber
        //  Given a phone number(possibly containing spaces or dashes). format it by splitting the digits into groups of three(or two if necessary)
        public String solutionFormatPhoneNumber(String S)
        {
            string sRetVal = "";
            string sInput = S.Replace(" ", "");
            sInput = sInput.Replace("-", "");
            int nLength = sInput.Length;
            if (nLength < 2)
                return "Invalid Mobile Number";

            int nCount = 0;
            for (int idx = 0; idx < nLength; idx++)
            {
                nCount++;
                sRetVal = sRetVal + sInput.Substring(idx, 1);
                if (nLength - idx == 3 && (nCount > 1))
                {
                    sRetVal = sRetVal + "-";
                    nCount = 0;
                }
                else if (nCount == 3 && idx != (nLength))
                {

                    sRetVal = sRetVal + "-";
                    nCount = 0;
                }
            }

            return sRetVal;

        }

        // bugFixingBinaryPeriod
        // Find and correct bugs in a function that finds the period of a binary reprentation of a number.
        public int solutionbugFixingBinaryPeriod(int n)
        {
            int[] d = new int[30];
            int l = 0;
            int p;
            while (n > 0)
            {
                d[l] = n % 2;
                n /= 2;
                l++;
            }
            for (p = 0; p < l; p++)
            {
                if (p <= l / 2)
                {
                    int i;
                    bool ok = true;
                    for (i = 0; i < l - p; i++)
                    {
                        if (d[i] != d[i + p])
                        {
                            ok = false;
                            break;
                        }
                    }
                    if (ok)
                    {
                        return p;
                    }
                }
            }
            return -1;
        }

        // BinaryGap
        // Find the longest sequence of zero in binary reprentation of an integer 
        public int solutionBinaryGap(int number)
        {
            String binary = Convert.ToString(number, 2);
            String[] gaps = binary.Split("1");

            String biggestGap = "";
            for (int i = 0; i < (binary.EndsWith("1") ? gaps.Length : gaps.Length - 1); i++)
            {

                if (gaps[i].Contains("0") && gaps[i].Length > biggestGap.Length)
                    biggestGap = gaps[i];
            }
            return biggestGap.Length;
        }

        // DecReprSeniorCoding
        // Find the largest value obtained by permutations of digits. 
        public int solutionsDecReprSeniorCoding(int A)
        {
            char[] chars = (A).ToString().ToCharArray();
            Array.Sort(chars);
            String s = new String(chars);
            StringBuilder builder = new StringBuilder(s);

            for (int i = builder.Length - 1; i >= 0; i--)
            {
                builder.Append(builder[i]);
            }
            string newName = builder.ToString();
            return Convert.ToInt32(newName.ToString());
        }

        // Lightbulbs
        // Calculate the number of prefixes that are a permutation.
        public int solutionLightbulbs(int[] A)
        {
            int turn = 0;
            int max = 0;
            for (int i = 0; i < A.Length; i++)
            {
                if (max < A[i])
                {
                    max = A[i];
                }
                if (max == i + 1)
                    turn += 1;
            }
            return turn;
        }

        //  Alic and Bob WAR
        // 

        public int solutionCards(String A, String B)
        {
            int solution = 0;
            char[] aChars = A.ToCharArray();
            char[] bChars = B.ToCharArray();
            for (int i = 0; i < aChars.Length; i++)
            {

                int aChar = getValue(aChars[i]);
                int bChar = getValue(bChars[i]);

                if (aChar > bChar)
                    solution += 1;
            }

            return solution;
        }

        public int getValue(char charcter)
        {
            switch (charcter)
            {
                case 'A':
                    return 13;
                case 'K':
                    return 12;
                case 'Q':
                    return 11;
                case 'J':
                    return 10;
                case 'T':
                    return 9;
                case '9':
                    return 8;
                case '8':
                    return 7;
                case '7':
                    return 6;
                case '6':
                    return 5;
                case '5':
                    return 4;
                case '4':
                    return 3;
                case '3':
                    return 2;
                case '2':
                    return 1;
            }

            return 0;
        }

        // BugfixingCoins
        // Find the correct bugs in a function that maximizes the number of adjacent coins lying in the same side by reversing exaclty one coin
        public int solutionBugfixingCoins(int[] A)
        {
            int n = A.Length;
            int result = 0;
            for (int i = 0; i < n - 1; i++)
            {
                if (A[i] == A[i + 1])
                {
                    result = result + 1;
                }
            }

            int reverce = 0;
            for (int i = 0; i < n; i++)
            {
                int count = 0;

                if (i > 0)
                {
                    if (A[i - 1] != A[i])
                    {
                        count = count + 1;
                    }
                    else
                    {
                        count = count - 1;
                    }
                }
                if (i < n - 1)
                {
                    if (A[i] != A[i + 1])
                    {
                        count = count + 1;
                    }
                    else
                    {
                        count = count - 1;
                    }
                }
                reverce = Math.Max(reverce, count);
            }
            return result + reverce;
        }

        // MinDist
        // Compute the minimal distance between elements of array

        public int solutionMinDist(int[] A)
        {
            Array.Sort(A);
            int distance = A[1] - A[0];
            for (int i = 0; i < A.Length - 1; i++)
            {

                int i1 = A[i + 1] - A[i];
                if (i1 < distance)
                {
                    distance = i1;
                }
            }
            return distance;
        }
        // RemoveHalf
        // You must remove exaclty half the elements in an array Maximize the number of distinct values after the removal
        public int solutionRemoveHalf(int[] T)
        {

            int allCandy = T.Length;

            HashSet<int> types = new HashSet<int>();

            for (int i = 0; i < allCandy; i++)
            {
                types.Add(T[i]);
            }

            if (types.Count < allCandy / 2)
                return types.Count;
            else return allCandy / 2;

        }
        // BugfixingFindCommonMin
        // Find and correct bugs in the function finding the minimal elements occurs in both arrays
        public int solutionBugfixingFindCommonMin(int[] A, int[] B)
        {
            int n = A.Length;
            int m = B.Length;

            Array.Sort(A);
            Array.Sort(B);

            int i = 0;
            for (int k = 0; k < A.Length; k++)
            {
                if (i < m - 1 && B[i] < A[k])
                {
                    while (i < m - 1 && B[i] < A[k])
                    {
                        i += 1;
                    }
                }
                if (A[k] == B[i])
                {
                    return A[k];
                }
            }

            return -1;
        }

        // PrefixPermutations
        // Calculate the number of prefixes that are permutations
        public int solutionPrefixPermutations(int[] A)
        {

            int realCount = 0;
            int tempTotal = 0;

            int prefix = 0;

            for (int i = 0; i < A.Length; i++)
            {
                realCount += i + 1;
                tempTotal += A[i];
                if (realCount == tempTotal)
                {
                    prefix++;
                }
            }
            return prefix;
        }

        // LongestSentence
        // Find the longest sentence in the given text.

        public int solutionLongestSentence1(String S)
        {

            String[] sentencesplits = S.Trim().Split("[.?!]");

            int maxwords = 0;
            for (int i = 0; i < sentencesplits.Length; i++)
            {

                String[] wordssplits = sentencesplits[i].Trim().Replace(" +", ".").Split("[.]");
                if (maxwords < wordssplits.Length)
                {
                    maxwords = wordssplits.Length;
                }
            }
            return maxwords;
        }

        /*
        public static int solutionLongestSentence2(String S)
        {
            int maxNoOfWords = 0;
            //for (String sentence : Arra(S.split("\\.|\\?|\\!")))
            {
                int wordCount = 0;
                List<String> words = Arrays.asList(sentence.split("\\s+"));
                for (int i = 0; i < words.size(); i++)
                {
                    final String word = words.get(i);
                    if (!word.isEmpty())
                        wordCount++;
                }
                if (maxNoOfWords < wordCount)
                    maxNoOfWords = wordCount;


            }


            return maxNoOfWords;
        }
        */
    }


}

