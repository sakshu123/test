using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp4
{
    class Program
    {
        string[] Letters = new string[26] { "a", "b", "c", "d", "e", "f", "g", "h", "i", "j", "k", "l", "m", "n", "o", "p", "q", "r", "s", "t", "u", "v", "w", "x", "y", "z" };
        static void Main(string[] args)
        {
            Program orange = new Program();
            Console.WriteLine(orange.Gematria("universe"));
        }
        public int Gematria(string word)
        {
            int GematriaValue = 1;
            for (int i = 0; i < word.Length; i++)
            {
                GematriaValue += LetterValue(word[i].ToString());
            }
            return GematriaValue;
        }
        public int LetterValue(string letter)
        {
            int x = 0;
            while (Letters[x]!=letter)
            {
                if (Letters[x++].Equals(letter))
                { return x++; }
                
            }
            return x;
        }
    }
}
