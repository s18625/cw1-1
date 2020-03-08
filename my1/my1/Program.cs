using System;
using System.Net.Http;
using System.Text.RegularExpressions;
using System.Threading.Tasks;

namespace my1
{
    public class Program
    {
       
        public static async Task Main(string[] args)
        {
            var pattern = @"^([\w\.\-]+)@([\w\-]+)((\.(\w){2,3})+)$";
            var webPage = args[0];

            var httpClient = new HttpClient();
            var response = await httpClient.GetAsync(webPage);
            var content = response.Content;
            var result = await content.ReadAsStringAsync();

            var regex = new Regex(pattern);
            foreach (var word in result.Split(' '))
            {
                var match = regex.Match(word);
                if (match.Success)
                {
                    Console.WriteLine(word);
                }
            }
        }
    }
}


