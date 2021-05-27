using System;
using System.Net.Http;
using System.Net.Http.Headers;

namespace HTTPGetRequestDemo
{
    class Program
    {
        static void Main(string[] args)
        {
            GetRequest("https://www.microsoft.com");
            Console.ReadKey();
        }

        async static void GetRequest(string url)
        {
            using (HttpClient client = new HttpClient())
            {
                using (HttpResponseMessage response = await client.GetAsync(url))
                {
                    using (HttpContent content = response.Content)
                    {
                        //string mycontent = await content.ReadAsStringAsync();
                        HttpContentHeaders headers = content.Headers;

                        Console.WriteLine(headers);
                    }
                }
            }
        }
    }
}
