using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Net.Http;
using System.Text;
using System.Threading.Tasks;

namespace Homework5_1
{
    class Program
    {

        static async Task Main(string[] args)
        {
            using (var http = new HttpClient())
            {
                Console.WriteLine("'POST' Create");
                User user = new User
                {
                    name = "morpheus",
                    job = "leader"
                };
                string serializedUser = JsonConvert.SerializeObject(user);
                var create = await http.PutAsync("https://reqres.in/api/users/2", new StringContent(serializedUser, Encoding.UTF8, "application/json"));
                Console.WriteLine($"Status: {create.StatusCode}\n");
                string newSingleResource = await create.Content.ReadAsStringAsync();
                Console.WriteLine(newSingleResource);

                //Console.WriteLine("'PUT' Update");
                //var update = await http.PutAsync("https://reqres.in/api/unknown/23");
                //Console.WriteLine($"Status: {singleNotFound.StatusCode}\n");


            }
        }
    }
}
