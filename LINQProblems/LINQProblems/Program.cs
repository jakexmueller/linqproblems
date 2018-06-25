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

            ////////////////////////////////////////

            List<string> names = new List<string>() { "Mike", "Dan", "Scott", "Nick", "Mike" };
            List<string> duplicateNames = new List<string>();
            List<string> singularNames = new List<string>();

            var duplicates = names.GroupBy(i => i).Where(g => g.Count() > 1).Select(g => g.Key);
            foreach (var d in duplicates)

            {
                duplicateNames.Add(d);
            }

            var singulars = names.GroupBy(i => i).Where(g => g.Count() == 1).Select(g => g.Key);
            foreach (var s in singulars)
            {
                singularNames.Add(s);
                
            }
            duplicateNames = duplicateNames.Concat(singularNames).ToList();
            duplicateNames.ForEach(Console.WriteLine);

            Console.ReadLine();
        }
    }
}
