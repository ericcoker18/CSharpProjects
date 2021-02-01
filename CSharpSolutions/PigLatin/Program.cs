using System;
using System.Linq;

namespace PigLatin
{
    class Program
    {
        static void Main(string[] args)
        {
            char[] vowels = { 'a', 'e', 'i', 'o', 'u' };

            Console.WriteLine("Give Word");
            string word = Console.ReadLine();
            int cut = word.IndexOfAny(vowels);
            string cutWord = word.Substring(cut);

            char firstletter = word[0];
            char lastletter = word[word.Length - 1];
            if (vowels.Contains(firstletter) && vowels.Contains(lastletter)) {
                Console.WriteLine(word + "yay");
            }

            else if (vowels.Contains(firstletter) && !vowels.Contains(lastletter) ){
                Console.WriteLine(word+ "ay");
            }

            else {
                string firsthalf = word.Substring(0, cut);
                string secondhalf = word.Substring(cut);
                Console.WriteLine(secondhalf + firsthalf + "ay");
            }
               



    
        }
    }
}
