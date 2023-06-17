using System;
using System.Collections.Generic;
using System.Linq;

namespace Pruebas
{
    class Program
    {
        static void Main(string[] args)
        {
            string palabra = "Hello123";
            sumString(palabra);
            // palabra  += "  a";
            //var output = palabra.ToCharArray();
            //palabra = palabra.PadRight(16, '.');
            //Console.WriteLine(palabra);
            
            // String word = "the sky is blue";
            // var output = word.Split(' ').Reverse();
            // Console.WriteLine(String.Join(' ' , output));
            //int[] arr = new int[] { 4, 1, 8, 2, 6, 7, 5, 9, 3 };
            //quickSortArray(arr);
            // foreach(int i in arr){
            //     Console.WriteLine(i);
            // }
            // arr = arr.OrderBy(x => x).ToArray();
            // arr = arraySortLoop(arr, arr.Length);
            // Array.Sort(arr);
            // Sort the arr in decreasing order 
            // and return a array 
            //arr = arr.OrderByDescending(c => c).ToArray();

            //Console.WriteLine(String.Join(",", arr));
            // Console.WriteLine(fibonacci(8));
            // Console.WriteLine(reverseWordsGeneric("The Sky is blue"));
            // TestStatic obj1 = new TestStatic();
            // obj1.Graba();
            
        }

        static void sumString(string str){
            int resultado = 0; 
            foreach(char c in str){
                if(Char.GetNumericValue(c) < 0){
                    resultado += Convert.ToInt32((int)char.ToLower(c) - 96);
                }else{
                    resultado += Convert.ToInt32(Char.GetNumericValue(c));
                }
            }
            Console.WriteLine(resultado);
        }

        static int fibonacci(int n)
        {
            if (n < 2) return n;
            return fibonacci(n - 1) + fibonacci(n - 2);
        }

        static void quickSortArray(int[] arr){
            quickSort(arr,0,arr.Length-1);
        } 
        
        static void quickSort(int[] arr, int left,int right){
            int i = left;
            int j = right;
            var pivot = arr[(left+right) / 2];

            while( i<=j){
                while(arr[i] < pivot)
                    i++;
                while(arr[j] > pivot)
                    j--;
                if(i<=j){
                    var temp = arr[i];
                    arr[i] = arr[j];
                    arr[j] = temp;
                    i++;
                    j--;
                }
            }
            if (left < j)
                quickSort(arr, left, j);
            if (i < right)
                quickSort(arr, i, right);
        }

        static int[] arraySortLoop(int[] arr, int Length)
        {
            Array.Sort(arr);
            //arr = arr.OrderBy(x=>x).ToArray();
            // for(int i=0; i<Length-1; i++){
            //     if(arr[i] > arr[i+1]){
            //         int temp = arr[i];
            //         arr[i] = arr[i+1];
            //         arr[i+1] = temp;
            //         i= -1;
            //     }
            // }
            return arr;
        }
        static string reverseWordsLinq(string str)
        {
            return String.Join(" ", str.Split(" ").Reverse());
        }
        static string reverseWordsGeneric(string str)
        {
            
            // return String.Join("",str.Reverse());
            List<string> output = new List<string>(str.Split(" "));
            output.Reverse();
            return String.Join(" ", output);
        }
        static string reverseWords(string str)
        {
            string word = "";
            string output = "";
            foreach (char Char in str)
            {
                if (Char != ' ') word += Char;
                if (Char == ' ' && output.Length < 1)
                {
                    output += word;
                    word = "";
                }
                else if (Char == ' ' || output.Length + 1 + word.Length == str.Length)
                {
                    output = word + " " + output;
                    word = "";
                }
            }
            return output;
        }
        static string reverseWords2(string str)
        {
            String[] input = str.Split(' ');
            int i = input.Length;
            String[] output = new String[i];
            i--;
            foreach (string Word in input)
            {
                output[i] = Word;
                i--;
            }

            return String.Join(" ", output);
        }
    }

}


interface TestInterfaces
{
    void escribe();
}

public abstract class SobreEscribe
{
    public virtual void Graba()
    {
        Console.WriteLine("Abstracta");
    }
}
public abstract class SobreEscribe2
{
    public virtual void Graba()
    {
        Console.WriteLine("Abstracta");
    }
}
public class TestStatic : SobreEscribe, TestInterfaces
{
    public static void probando()
    {
        Console.WriteLine("this is a test from static method.");
    }
    public override void Graba()
    {
        Console.WriteLine("Sobre Escrito");
    }
    public void escribe()
    {
        Console.WriteLine("interface implemented");
    }
}