using System;
using System.Collections.Generic;
using System.Linq;
using System.IO;
using System.Threading.Tasks;
using System.Text.RegularExpressions;

namespace Mod03Task1
{
    class PhoneNumbers 
    {
        public async static Task<List<string>> GetPhoneNumbersAsync(string path, string output)
        {
            if (path.Length == 0 || path == null)
            {
                throw new ArgumentException($"Error: {nameof(path)} to file is not provided!");
            }
            string textIn = null;
            List<string> listout = new List<string>();
            Regex rx = new Regex(@"(.\d\s.\d{3}.\s\d{3}.\d{2}.\d{2}) | (.\d{3}\s.\d{2}.\s\d{3}.\d{4}) | (\d\s\d{3}\s\d{3}.\d{2}.\d{2})");
            using FileStream reader = File.Open(path, FileMode.Open, FileAccess.Read);
            using (StreamReader streamreader = new StreamReader(reader)) {
                string line;
                line = streamreader.ReadToEnd();
                textIn = line;
            };


            MatchCollection match = Regex.Matches(textIn, rx.ToString());
            foreach (var x in match)
            {
                listout.Add(x.ToString());
            }

            using FileStream writer = File.Open(output, FileMode.Create, FileAccess.Write);
            using (StreamWriter streamwriter = new StreamWriter(writer))
            {
                foreach (var x in listout)
                {
                    await streamwriter.WriteLineAsync($"{x}");
                }
                await streamwriter.FlushAsync();
            }
           
            return listout;
        }
    
    }
}
