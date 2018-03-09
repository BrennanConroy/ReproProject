using System;
using System.Net.Http;
using System.Threading.Tasks;

namespace tcp
{
    class Program
    {
        static void Main(string[] args)
        {
            var client = new HttpClient();
            var request = new HttpRequestMessage(HttpMethod.Post, "http://localhost:5000");
            request.Content = new StringContent("test");
            var response = client.SendAsync(request).Result;
            response.EnsureSuccessStatusCode();
        }
    }
}
