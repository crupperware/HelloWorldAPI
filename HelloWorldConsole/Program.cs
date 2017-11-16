using HelloWorldConsole.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Net.Http;
using System.Net.Http.Headers;
using System.Text;
using System.Threading.Tasks;
using System.Configuration;

namespace HelloWorldConsole
{
    class Program
    {
        static HttpClient client = new HttpClient();
        static string errorMessage = "";

        static void Main(string[] args)
        {
            setup();
            while (true)
            {
                Console.Write("Please press any key for greetings:");
                Console.ReadLine();

                //Call API
                GreetingsDTO res = GetGreetings().GetAwaiter().GetResult();

                //Print error if one occured
                if (errorMessage != "")
                {
                    Console.WriteLine(errorMessage);
                }

                //Print greeting
                Console.WriteLine(res.greeting);
                Console.WriteLine();
                //Console.ReadLine();
            }

        }

        //Build http client header
        static void setup()
        {
            //Get Base URI from config file
            string baseURI = ConfigurationManager.AppSettings["API_BaseURI"];
            client.BaseAddress = new Uri(baseURI);
            client.DefaultRequestHeaders.Accept.Clear();
            client.DefaultRequestHeaders.Accept.Add(new MediaTypeWithQualityHeaderValue("application/json"));
        }

        //Call Web API for greeting
        static async Task<GreetingsDTO> GetGreetings()
        {
            var results = new GreetingsDTO();

            //Controller/action
            string path = "hello/gethello";

            var response = await client.GetAsync(path);

            if (response.IsSuccessStatusCode)
            {
                //
                results = await response.Content.ReadAsAsync<GreetingsDTO>();
            }
            else
            {
                errorMessage = "Response failed";
            }

            return results;
        }
    }
}
