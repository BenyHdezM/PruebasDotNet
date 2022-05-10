using System;
using System.Collections.Generic;
using System.Globalization;
using System.Linq;
using System.Text;

namespace Test1
{
    class Program
    {
        static void Main(string[] args)
        {
            //SumOfDigits(168);
            // isPalindrome("Anita laVa lA tina");
            // FizzBuzz();
            //FirstCharToUpper("hola marmota");
            //IsAnagram("aabbacc","bbccaaA");
            //VowelsCounter("Anita laVa lA tina");
            //LambdaFunction();
            // ReverseString("HolA");
            // Console.WriteLine(fibonacci(5));
            //PlusMinOrder("+--+-++");
            // ReverseWordOrder("My Name is Benito");
            // ReverseWordsOnly("My Name Is Benito");
             List<String> myCollection = new List<String>();
            myCollection.Add("One");
            myCollection.Add("Two");
            myCollection.Add("Three");
            myCollection.Sort();
            myCollection.Insert(1, "Four");
            myCollection.RemoveAt(2);
            foreach (String nextItem in myCollection)
            {
                Console.WriteLine(nextItem);
            }
        }

        static void ReverseWordsOnly(string str)
        {
            List<string> lstOutPut = new List<string>();

            foreach (string val in str.Split(' '))
            {
                lstOutPut.Add(string.Join("", val.ToCharArray().Reverse()));
            }

            Console.WriteLine(string.Join(" ", lstOutPut));
        }

        static void PlusMinOrder(string str)
        {
            var input = str.ToCharArray();

            List<int> listInt = new List<int>();
            List<int> listSorted = new List<int>();
            int counter = input.Count();

            for (int i = 0; i < counter + 1; i++)
            {
                listInt.Add(i);
            }
            for (int i = 0; i <= counter; i++)
            {
                if (i < counter && input[i] == '+')
                {
                    listSorted.Add(listInt.Max());
                    listInt.Remove(listInt.Max());
                }
                else if (i < counter && input[i] == '-')
                {
                    listSorted.Add(listInt.Min());
                    listInt.Remove(listInt.Min());
                }
                else
                {
                    listSorted.Add(listInt.Min());
                    listInt.Remove(listInt.Min());
                }
            }
            Console.WriteLine(String.Join(", ", listSorted.Select(x => x.ToString())));
        }

        static int fibonacci(int n)
        {
            if(n<2) return n;
            else return fibonacci(n-1) + fibonacci(n-2);
        }
        static void ReverseString(string str)
        {

            char[] charArray = str.ToCharArray();
            for (int i = 0, j = str.Length - 1; i < j; i++, j--)
            {
                charArray[i] = str[j];
                charArray[j] = str[i];
            }
            string reversedstring = new string(charArray);
            Console.WriteLine(reversedstring);
        }
        //Generics
        static void Generics()
        {
            int[] array = { 0, 1, 2, 3 };
            MakeAtLeast<int>(array, 2); // Change array to { 2, 2, 2, 3 }
            foreach (int i in array)
                Console.WriteLine(i); // Print results.
            Console.ReadKey(true);
        }
        static void MakeAtLeast<T>(T[] list, T lowest) where T : IComparable<T>
        {
            for (int i = 0; i < list.Length; i++)
                if (list[i].CompareTo(lowest) < 0)
                    list[i] = lowest;
        }
        //Anonymous Function
        static void LambdaFunction()
        {
            Func<int, int> foo = x => x * x;
            Console.WriteLine(foo(7));
            Action<int> act = x => { Console.WriteLine(x * x); };
            act(6);
        }
        static void isPalindrome(string myString)
        {
            string[] temp = myString.Split(" ");
            var firt = string.Join("", temp);
            temp = firt.ToLower().Split("");
            Array.Reverse(temp);

            string second = string.Join("", temp);
            firt = firt.ToLower();

            if (firt == second)
            {
                Console.WriteLine("Palindrome");
            }
            else
            {
                Console.WriteLine("No isn't");
            }
        }
        static void FizzBuzz()
        {
            int count = 0;
            while (count <= 100)
            {
                if (count % 3 == 0 && count % 5 == 0)
                {
                    Console.WriteLine("FizzBuzz");
                }
                else if (count % 3 == 0)
                {
                    Console.WriteLine("Fizz");
                }
                else if (count % 5 == 0)
                {
                    Console.WriteLine("Buzz");
                }
                else
                {
                    Console.WriteLine(count);
                }
                count++;
            }
        }
        static void FirstCharToUpper(string str)
        {

            if (str.Split(" ").Length > 1)
            {
                str = CultureInfo.CurrentCulture.TextInfo.ToTitleCase(str.ToLower());
                Console.WriteLine(str);
            }
            else if (str.Split(" ").Length == 1)
            {
                Console.WriteLine(char.ToUpper(str[0]) + str.Substring(1));
            }
            else
            {
                Console.WriteLine("Empty String");
            }
        }
        static void IsAnagram(string s1, string s2)
        {
            if (s1.Length != s2.Length)
            {
                Console.WriteLine("is not an Anagram");
                return;
            }
            else
            {
                var s1Array = s1.ToLower().ToCharArray();
                var s2Array = s2.ToLower().ToCharArray();

                Array.Sort(s1Array);
                Array.Sort(s2Array);

                s1 = new string(s1Array);
                s2 = new string(s2Array);

                if (s1 == s2)
                {
                    Console.WriteLine("Correct Anagram!!");
                }
                else
                {
                    Console.WriteLine("is not an Anagram");
                }
            }
        }
        static void VowelsCounter(string str)
        {
            str = str.ToLower();
            int total = 0;
            for (int i = 0; i < str.Length; i++)
            {
                if (str[i] == 'a' || str[i] == 'e' || str[i] == 'i' || str[i] == 'o' || str[i] == 'u')
                {
                    total++;
                }
            }
            Console.WriteLine("#Vowels: " + total);
        }
        static void chkPalindrome(string str)
        {
            bool flag = false;
            for (int i = 0, j = str.Length - 1; i < str.Length / 2; i++, j--)
            {
                if (str[i] != str[j])
                {
                    flag = false;
                    break;
                }
                else
                    flag = true;
            }
            if (flag)
            {
                Console.WriteLine("Palindrome");
            }
            else
                Console.WriteLine("Not Palindrome");
        }
        internal static void ReverseWordOrder(string str)
        {
            int i;
            StringBuilder reverseSentence = new StringBuilder();

            int Start = str.Length - 1;
            int End = str.Length - 1;

            while (Start > 0)
            {
                if (str[Start] == ' ')
                {
                    i = Start + 1;
                    while (i <= End)
                    {
                        reverseSentence.Append(str[i]);
                        i++;
                    }
                    reverseSentence.Append(' ');
                    End = Start - 1;
                }
                Start--;
            }

            for (i = 0; i <= End; i++)
            {
                reverseSentence.Append(str[i]);
            }
            Console.WriteLine(reverseSentence.ToString());
        }
        internal static void Countcharacter(string str)
        {
            Dictionary<char, int> characterCount = new Dictionary<char, int>();

            foreach (var character in str)
            {
                if (character != ' ')
                {
                    if (!characterCount.ContainsKey(character))
                    {
                        characterCount.Add(character, 1);
                    }
                    else
                    {
                        characterCount[character]++;
                    }
                }

            }
            foreach (var character in characterCount)
            {
                Console.WriteLine("{0} - {1}", character.Key, character.Value);
            }
        }
        internal static void removeduplicate(string str)
        {
            string result = string.Empty;

            for (int i = 0; i < str.Length; i++)
            {
                if (!result.Contains(str[i]))
                {
                    result += str[i];
                }
            }
            Console.WriteLine(result);
        }
        internal static void findallsubstring(string str)
        {
            for (int i = 0; i < str.Length; ++i)
            {
                StringBuilder subString = new StringBuilder(str.Length - i);
                for (int j = i; j < str.Length; ++j)
                {
                    subString.Append(str[j]);
                    Console.Write(subString + " ");
                }
            }
        }
        internal static void SumOfDigits(int num)
        {
            int sum = 0;
            while (num > 0)
            {
                sum += num % 10;
                num /= 10;
            }
            Console.WriteLine(sum);
        }
    }

}
