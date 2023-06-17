using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Practices
{
    class Program
    {
        static void Main(string[] args)
        {
            //FizzBuzz(50);
            // int[] temp = { 1, 2, 3, 4, 5, 6, 7, 8, 9, 10 };
            // chunk(temp, 10);
            //Console.WriteLine(anagrams("abcde","dcbea"));
            //steps(2);
            // piramid(4);
            //vowels("Why do you ask");
             int[] data = { 1, 2, 3 };
            int i = 1;
            data[i++] = data[i] + 10;
            Console.WriteLine(String.Join(",", data));
            
        }
        static void matrix(int n){
            int max = n*n;
            List<Array> result = new List<Array>();
            for(int col=0; col < n ; col++){
                
            }
        }
        static void vowels(String str)
        {
            List<char> vowels = new List<char> { 'a', 'e', 'i', 'o', 'u' };
            int count = 0;
            foreach (char Char in str)
            {
                if (vowels.Contains(Char))
                {
                    count++;
                }
            }
            Console.WriteLine(count);
        }
        static void piramid(double n)
        {
            int center = (int)(2 * n - 1) / 2;
            for (int row = 0; row < n; row++)
            {
                String salida = "";
                for (int col = 0; col < 2 * n - 1; col++)
                {
                    if (center - row <= col && center + row >= col)
                    {
                        salida += "#";
                    }
                    else
                    {
                        salida += " ";
                    }
                }
                Console.WriteLine(salida);
            }
        }
        static void steps(int n)
        {
            for (int i = 0; i < n; i++)
            {
                for (int j = 0; j <= i; j++)
                {
                    Console.Write("#");
                }
                Console.WriteLine("");
            }
        }
        static bool anagrams(string str, string str2)
        {
            if (str.Length != str2.Length) return false;
            var l1 = str.ToCharArray();
            Array.Sort(l1);
            str = String.Join("", l1);
            var l2 = str2.ToCharArray();
            Array.Sort(l2);
            str2 = String.Join("", l2);
            if (str == str2) return true;
            return false;
        }

        static List<Array> chunk(int[] arr, int size)
        {
            List<Array> ouput = new List<Array>();

            for (int i = 0; i < arr.Length; i += size)
            {
                var subset = arr.Skip(i).Take(size);
                ouput.Add(subset.ToArray());
            }

            // for (int j = 0; j < arr.Length; j = j + size)
            // {
            //     int?[] temp = new int?[size];
            //     for (int i = 0; i < size; i++)
            //     {
            //         if (j + i < arr.Length)
            //         {
            //             temp[i] = arr[j + i];
            //         }
            //         else
            //         {
            //             static bool isEmpty(int? n)
            //             {
            //                 return n != null;
            //             }
            //             temp = Array.FindAll(temp, isEmpty).ToArray();
            //         }

            //     }
            //     ouput.Add(temp);
            // }


            return ouput;
        }

        static void FizzBuzz(int n)
        {
            for (int ivalor = 0; ivalor < n; ivalor++)
            {
                Console.WriteLine(((ivalor % 3 == 0) && (ivalor % 5 == 0)) ? "Fizz Buzz" :
                                ivalor % 3 == 0 ? "Fizz" :
                                (ivalor % 5 == 0) ? "Buzz" : ivalor.ToString());
            }

        }

        static void maxChar(string str)
        {
            var Words = str.ToLower().Replace(" ", string.Empty);
            // foreach(char Char in Words){
            //     Console.WriteLine(Char +": " + Words.Count(x => x == Char));
            // }
            // // var groupPalabra = (from Char in str
            //                     group str by Char into grupito
            //                     select new
            //                     {
            //                         cValor = grupito.Key,
            //                         iContador = grupito.Count(),


            //                     });
            // groupPalabra.ToList().ForEach(

            //     x =>
            //   {
            //       Console.WriteLine(x);
            //   });
            //Console.WriteLine(String.Join(", ", groupPalabra));

            Dictionary<char, int> charMap = new Dictionary<char, int>();
            foreach (char Char in Words)
            {
                if (charMap.ContainsKey(Char))
                {
                    charMap[Char]++;
                }
                else
                {
                    charMap[Char] = 1;
                }

            }
            foreach (KeyValuePair<char, int> key in charMap)
            {
                Console.WriteLine(key.Key + ": " + key.Value);
            }
        }

        static void reverseInt(int n)
        {
            var input = n.ToString().ToCharArray();
            Array.Reverse(input);
            int output = int.Parse(input);
            Console.WriteLine(output);
        }

        static void palindrome(String str)
        {
            for (int i = 0; i < str.Length; i++)
            {
                if (str[i] != str[str.Length - i - 1])
                {
                    Console.WriteLine("false");
                    return;
                }
            }
            Console.WriteLine("true");
        }


        static string reverseString(String str)
        {
            string reversed = "";
            foreach (char element in str)
            {
                reversed = element + reversed;
            }
            return reversed;
        }

        static int fibo(int n)
        {
            if (n < 2)
            {
                return n;
            }
            return fibo(n - 1) + fibo(n - 2);
        }
    }

}
