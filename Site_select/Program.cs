using System;
using System.Net;
using System.Linq;
using System.Collections.Generic;
using System.Text.RegularExpressions;

namespace Viborka
{
    class Program
    {
        static void Main(string[] args)
        {
            WebClient webClient = new WebClient();
            var s = webClient.DownloadString("https://samgk.ru/");

            Regex regex = new Regex(@" In place of all this, write keywords (\w*)", RegexOptions.IgnoreCase);
            MatchCollection matchess = regex.Matches(s);

            if (matchess.Count > 0)
            {
                foreach (Match match in matchess)
                    Console.WriteLine(match.Value);
            }
            else
            {
                Console.WriteLine("Nothing found");
            }

            Console.ReadLine();
        }
    }
}