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
            //using (var http = new HttpClient())
            //{
            //Console.WriteLine("'GET' List Users");
            //var listUsers = await http.GetAsync("https://reqres.in/api/users?page=2");
            //Console.WriteLine($"Status: {listUsers.StatusCode}");
            //string newlistUsers = await listUsers.Content.ReadAsStringAsync();
            //var newlistUsersResult = JsonConvert.DeserializeObject<PageList>(newlistUsers);
            //Console.WriteLine($"Page: { newlistUsersResult.page}, Total: {newlistUsersResult.total}, Per Page: {newlistUsersResult.per_page}, Total Pages: {newlistUsersResult.total_pages}\nSupport Text: {newlistUsersResult.support.text}\nSupport Url: {newlistUsersResult.support.url}");
            //foreach (var item in newlistUsersResult.data)
            //{
            //    Console.WriteLine($"Id: {item.id}, Full Name: { item.first_name} { item.last_name}, Email: {item.email}, Avatar: {item.avatar} ");
            //}


            //Console.WriteLine($"'GET' Single User");
            //var singleUser = await http.GetAsync("https://reqres.in/api/users/2");
            //Console.WriteLine($"Status: {singleUser.StatusCode}\n");
            //string newSingleUser = await singleUser.Content.ReadAsStringAsync();
            //var singleUserResult = JsonConvert.DeserializeObject<SingleUser>(newSingleUser);
            //Console.WriteLine($"Id: {singleUserResult.data.id}, Full Name: {singleUserResult.data.first_name} {singleUserResult.data.last_name}, " +
            //    $"Email: {singleUserResult.data.email}, Avatar: {singleUserResult.data.avatar}" +
            //    $"\nSupport Text: {singleUserResult.support.text}" +
            //    $"\nSupport Url: {singleUserResult.support.url}");

            //    Console.WriteLine("'GET' Single User Not Found");
            //    var singleUserNotFound = await http.GetAsync("https://reqres.in/api/users/23");
            //    Console.WriteLine($"Status: {singleUserNotFound.StatusCode}\n");
            //string newSingleUserNotFound = await singleUserNotFound.Content.ReadAsStringAsync();
            //Console.WriteLine(newSingleUserNotFound);

            //Console.WriteLine("'GET' List <Resource>");
            //var listResource = await http.GetAsync("https://reqres.in/api/unknown");
            //Console.WriteLine($"Status: {listResource.StatusCode}\n");
            //string newlistResource = await listResource.Content.ReadAsStringAsync();
            //var newlistResourceResult = JsonConvert.DeserializeObject<PageSingle>(newlistResource);
            //Console.WriteLine($"Page: {newlistResourceResult.page}, Total: {newlistResourceResult.total}, Per Page: {newlistResourceResult.per_page}, " +
            //    $"Total Pages: {newlistResourceResult.total_pages}\nSupport Text: {newlistResourceResult.support.text}\nSupport Url: {newlistResourceResult.support.url}");
            //foreach (var item in newlistResourceResult.data)
            //{
            //    Console.WriteLine($"Id: {item.id}, Name: {item.name}, Year: {item.year}, Color: {item.color}, Pantone value {item.pantone_value}");
            //}

            //Console.WriteLine("'GET' Single <Resource>");
            //var singleResource = await http.GetAsync("https://reqres.in/api/unknown/2");
            //Console.WriteLine($"Status: {singleResource.StatusCode}\n");
            //string newSingleResource = await singleResource.Content.ReadAsStringAsync();
            //var newSingleResourceResult = JsonConvert.DeserializeObject<SingleResource>(newSingleResource);
            //Console.WriteLine($"Id: {newSingleResourceResult.data.id}, Name: {newSingleResourceResult.data.name}, " +
            //    $"Color: {newSingleResourceResult.data.color}, " +
            //    $"Year: {newSingleResourceResult.data.year}, Pantone value: {newSingleResourceResult.data.pantone_value}" +
            //    $"\nSupport Text: {newSingleResourceResult.support.text}" +
            //    $"\nSupport Url: {newSingleResourceResult.support.url}");

            //Console.WriteLine("'GET' Single <Resource> Not Found");
            //var singleNotFound = await http.GetAsync("https://reqres.in/api/unknown/23");
            //Console.WriteLine($"Status: {singleNotFound.StatusCode}\n");
            //string newSingleNotFound = await singleNotFound.Content.ReadAsStringAsync();
            //Console.WriteLine(newSingleNotFound);

            //Console.WriteLine("'POST' Create");
            //User user = new User
            //{
            //    name = "morpheus",
            //    job = "leader"
            //};
            //string serializedUser = JsonConvert.SerializeObject(user);
            //var create = await http.PostAsync("https://reqres.in/api/users", new StringContent(serializedUser, Encoding.UTF8, "application/json"));
            //Console.WriteLine($"Status: {create.StatusCode}\n");
            //string newSingleResource = await create.Content.ReadAsStringAsync();
            //Console.WriteLine(newSingleResource);
        }
    }
}
