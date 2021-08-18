using System;

namespace Mod03Task1
{
    public class DoubleStringCharacters
    {
        public static string Doble(string input, string dobleThisChars)
        {
            if (input == null||dobleThisChars == null )
            {
                throw new ArgumentNullException($"Error: {nameof(input)} or {nameof(dobleThisChars)} was not passed properly!");
            }
            else if ( input.Length == 0|| dobleThisChars.Length == 0 )
            {
                throw new ArgumentException($"Error: {nameof(dobleThisChars)} or {nameof(input)} contains nothing!");
            }
            var removeSpace = dobleThisChars.Replace(" ", "");
            string result = "";
            foreach (char i in input)
            {
                if (removeSpace.Contains(i.ToString()))
                {
                    result += $"{i}{i}";
                }
                else { result += i; }
            }
            
            return result;
        }
    }
}
