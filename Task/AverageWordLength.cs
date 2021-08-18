using System;
using System.Linq;


namespace Mod03Task1
{
    public class AverageWordLength
    {
        public static double AverageLength(string term)
        {
            if (term.Length == 0 || term == null)
            {
                throw new ArgumentException($"Error: 0 {nameof(term)}s was given!");
            }
            double result = new string(term.Where(c => !char.IsPunctuation(c))
                .ToArray())
                .ToString()
                .Split(' ')
                .Average(n => n.Length); 
            return result;
        }
    }
}
