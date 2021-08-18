using System;
using System.Linq;


namespace Mod03Task1
{
    public class ReverseAllWords
    {
        public static string ReverseSentence(string sentence)
        {
            if (sentence.Length == 0 || sentence == null)
            {
                throw new ArgumentException($"Error: nothing to reverse from{nameof(sentence)}!");
            }
            string[] words = sentence.Split(new[] { ',', '.', ' ', ';', ':', '?', '!' }, StringSplitOptions.RemoveEmptyEntries);
            return string.Join(" ", words.Reverse());
        }
    }
}
