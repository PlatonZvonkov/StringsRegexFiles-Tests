using System;
using System.Collections.Generic;
using System.IO;
using System.Threading.Tasks;


namespace Mod03Task1
{
    class Program
    {
        async static Task Main(string[] args)
        {
            //method that doubles chars in string by the target string
            Console.WriteLine(DoubleStringCharacters.Doble("omg i love shrek", "o kek"));

            //method that reverse whole sentence
            Console.WriteLine(ReverseAllWords.ReverseSentence("The greatest victory is that which requires no battle"));

            //method that count avarage length in sentence
            Console.WriteLine(AverageWordLength.AverageLength("The greatest victory is that, which requires no battle!?"));

            //method that counts sum of very big numbers from strings
            Console.WriteLine(SumOfBigNumbers.TooBig("9876543210000000000", "9876543210000000000"));

            //method that reads telephone numbers from file and writes them into new file
            List<string> phonenumbers = await PhoneNumbers.GetPhoneNumbersAsync(@"C:\Code\platon-zvonkov\zvonkovp\Mod03\Mod03Task1\text.txt", @"C:\Code\platon-zvonkov\zvonkovp\Mod03\Mod03Task1\Numbers.txt");
            foreach (var number in phonenumbers)
            {
                Console.WriteLine(number);
            }
            
        }
    }
}
