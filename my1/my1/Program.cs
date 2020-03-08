using System;
using System.Net.Http;
using System.Threading.Tasks;

namespace my1
{
    public class Program
    {
        public static async Task Main(string[] args)
        {

            var httpClient = new HttpClient();
            var response = await httpClient.GetAsync(args[0]);

            // ...



        }
    }
}
