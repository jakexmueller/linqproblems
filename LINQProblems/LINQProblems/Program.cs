using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LINQProblems
{
    class Program
    {
        delegate bool StringToBoolFunction(string word);
        static void Main(string[] args)
        {
            List<string> words = new List<string>() { "the", "bike", "this", "it", "tenth", "mathematics" };
            var comparison = "th";
            //bool result = words[i].Contains(comparison);
            var wordsth = words.Where(w => w.Contains(comparison)).ToList();
            foreach (var word in wordsth)
            {
                Console.WriteLine(word);

            }
            Console.ReadLine();
        }
    }
}
