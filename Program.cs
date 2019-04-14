using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Longest_Word
{
    class Program
    {
        static void Main(string[] args)
        {
            Program a = new Program();
            Console.WriteLine("the longest word is :");
            Console.WriteLine(a.MyFunctionA("Ada Lovelace wrote the first algorithm designed for processing by an Analytical Engine."));
        }
        public MyFunctionA(string input)
        { //WRITE A c# Program to find the longest word in a string.
            string[] words = input.Split('');

            int wordArrayLength = words.Length;
            int[] wordsLength = new int[wordArrayLength];

            foreach (var word in words)
            {
                //TODO
            }
            //loop post condition: we now have array wordsLength which 
            //contains the lengths of each word

            string currentWord = words[0];
            string nextWord;

            for (int y = 0; y {
                currentWord = words[y];
                nextWord = words[y + 1];
                //TODO: use an IF statement to maker sure that variablelongestWord
                // is always set to the longest word in the input string
            }


        }
    }
}