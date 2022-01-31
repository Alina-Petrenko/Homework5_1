using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Net.Http;
using System.Text;
using System.Threading.Tasks;

namespace Homework5_1
{
    class Starter
    {
        public async Task GetMethodsAsync()
        {
            using (var http = new HttpClient())
            {
                Console.WriteLine("'GET' List Users");
                var listUsers = await http.GetAsync("https://reqres.in/api/users?page=2");
                Console.WriteLine($"Status: {listUsers.StatusCode}");
                string newlistUsers = await listUsers.Content.ReadAsStringAsync();
                var newlistUsersResult = JsonConvert.DeserializeObject<Page>(newlistUsers);
                Console.WriteLine($"Page: { newlistUsersResult.page}, Total: {newlistUsersResult.total}, Per Page: {newlistUsersResult.per_page}, Total Pages: {newlistUsersResult.total_pages}\nSupport Text: {newlistUsersResult.support.text}\nSupport Url: {newlistUsersResult.support.url}");
                foreach (var item in newlistUsersResult.data)
                {
                    Console.WriteLine($"Id: {item.id}, Full Name: { item.first_name} { item.last_name}, Email: {item.email}, Avatar: {item.avatar} ");
                }

                Console.WriteLine($"'GET' Single User");
                var singleUser = await http.GetAsync("https://reqres.in/api/users/2");
                Console.WriteLine($"Status: {singleUser.StatusCode}\n");
                string newSingleUser = await singleUser.Content.ReadAsStringAsync();
                var singleUserResult = JsonConvert.DeserializeObject<SingleUser>(newSingleUser);
                Console.WriteLine($"Id: {singleUserResult.data.id}, Full Name: {singleUserResult.data.first_name} {singleUserResult.data.last_name}, " +
                    $"Email: {singleUserResult.data.email}, Avatar: {singleUserResult.data.avatar}" +
                    $"\nSupport Text: {singleUserResult.support.text}" +
                    $"\nSupport Url: {singleUserResult.support.url}");

                Console.WriteLine("'GET' Single User Not Found");
                var singleUserNotFound = await http.GetAsync("https://reqres.in/api/users/23");
                Console.WriteLine($"Status: {singleUserNotFound.StatusCode}\n");
            }
        }
    }
}
