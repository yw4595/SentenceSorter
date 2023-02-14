using System;

namespace WordSorter
{
    /// <summary>
    /// Author: Yanzhi Wang
    /// Purpose: Sorts words in a sentence in ascending or descending alphabetical order.
    /// Restrictions: None
    /// </summary>
    class Program
    {
        /// <summary>
        /// Main method - asks user for sentence and sorts the words in the sentence in the specified order.
        /// </summary>
        /// <param name="args">command line arguments</param>
        static void Main(string[] args)
        {
            Console.WriteLine("Please enter a sentence:");
            string sentence = Console.ReadLine();

            Console.WriteLine("Do you want the words sorted in ascending (A) or descending (D) order?");
            string sortType = Console.ReadLine();

            // split the sentence into an array of words
            string[] words = sentence.Split(new[] { ' ' }, StringSplitOptions.RemoveEmptyEntries);

            // sort the words in the specified order
            if (sortType.ToUpper() == "A")
            {
                Array.Sort(words, StringComparer.InvariantCulture);
            }
            else if (sortType.ToUpper() == "D")
            {
                Array.Sort(words, StringComparer.InvariantCulture);
                Array.Reverse(words);
            }
            else
            {
                Console.WriteLine("Invalid sort type specified. Please enter 'A' for ascending or 'D' for descending.");
                return;
            }

            // print the sorted words
            Console.WriteLine("Sorted words:");
            foreach (string word in words)
            {
                Console.WriteLine(word);
            }
        }
    }
}
