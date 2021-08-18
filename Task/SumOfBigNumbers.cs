using System;


namespace Mod03Task1
{
    public class SumOfBigNumbers
    {
        public static string TooBig(string num1, string num2) {
            if (num1 == null || num2 == null)
            {
				throw new ArgumentNullException($"Error: no {nameof(num1)} or {nameof(num2)} was passed!");
            }
			if (num1.Length == 0 || num2.Length == 0)
			{
				throw new ArgumentException("Error: nothing to add!");
			}
            
            string str = null;                        
            int diff = num2.Length - num1.Length;
            int carry = 0;

            for (int i = num1.Length - 1; i >= 0; i--)
            {
                int sum = ((num1[i] - '0') +
                        (num2[i + diff] - '0') + carry);
                str += (char)(sum % 10 + '0');
                carry = sum / 10;
            }

            for (int i = num2.Length - num1.Length - 1; i >= 0; i--)
            {
                int sum = ((num2[i] - '0') + carry);
                str += (char)(sum % 10 + '0');
                carry = sum / 10;
            }

            if (carry > 0)
                str += (char)(carry + '0');

            char[] ch2 = str.ToCharArray();
            Array.Reverse(ch2);
            return new string(ch2);
        } 
	}
}
