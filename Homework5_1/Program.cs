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


                


                //Console.WriteLine("'GET' Single User Not Found");
                //var singleUserNotFound = await http.GetAsync("https://reqres.in/api/users/23");
                //Console.WriteLine($"Status: {singleUserNotFound.StatusCode}\n");

                //Console.WriteLine("'GET' List <Resource>");
                //var listResource = await http.GetAsync("https://reqres.in/api/unknown");
                //Console.WriteLine($"Status: {listResource.StatusCode}\n");

                //Console.WriteLine("'GET' Single <Resource>");
                //var singleResource = await http.GetAsync("https://reqres.in/api/unknown/2");
                //Console.WriteLine($"Status: {singleResource.StatusCode}\n");

                //Console.WriteLine("'GET' Single <Resource> Not Found");
                //var singleNotFound = await http.GetAsync("https://reqres.in/api/unknown/23");
                //Console.WriteLine($"Status: {singleNotFound.StatusCode}\n");

                //Console.WriteLine("'POST' Create");
                //User user = new User
                //{
                //    name = "morpheus",
                //    job = "leader"

                //};
                //string serializedUser = JsonConvert.SerializeObject(user);
                //var create = await http.PostAsync("https://reqres.in/api/users", new StringContent(serializedUser, Encoding.UTF8, "application/json"));
                //Console.WriteLine($"Status: {create.StatusCode}\n");

                //Console.WriteLine("'PUT' Update");
                //var update = await http.PutAsync("https://reqres.in/api/unknown/23");
                //Console.WriteLine($"Status: {singleNotFound.StatusCode}\n");


            }
        }
    }
}
