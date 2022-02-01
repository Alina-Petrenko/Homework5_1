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
                //'GET' List Users

                Console.WriteLine("'GET' List Users");
                var listUsers = await http.GetAsync("https://reqres.in/api/users?page=2");
                Console.WriteLine($"Status: {listUsers.StatusCode}");
                string newlistUsers = await listUsers.Content.ReadAsStringAsync();
                var newlistUsersResult = JsonConvert.DeserializeObject<PageList>(newlistUsers);
                foreach (var item in newlistUsersResult.data)
                {
                    Console.WriteLine($"Id: {item.id}, Full Name: { item.first_name} { item.last_name}, Email: {item.email}, Avatar: {item.avatar} ");
                }
                Console.WriteLine($"Page: { newlistUsersResult.page}, Total: {newlistUsersResult.total}, Per Page: {newlistUsersResult.per_page}, " +
                    $"Total Pages: {newlistUsersResult.total_pages}\nSupport Text: {newlistUsersResult.support.text}\nSupport Url: {newlistUsersResult.support.url}\n");



                //'GET' Single User
                Console.WriteLine($"'GET' Single User");
                var singleUser = await http.GetAsync("https://reqres.in/api/users/2");
                Console.WriteLine($"Status: {singleUser.StatusCode}");
                string newSingleUser = await singleUser.Content.ReadAsStringAsync();
                var singleUserResult = JsonConvert.DeserializeObject<SingleUser>(newSingleUser);
                Console.WriteLine($"Id: {singleUserResult.data.id}, Full Name: {singleUserResult.data.first_name} {singleUserResult.data.last_name}, " +
                    $"Email: {singleUserResult.data.email}, Avatar: {singleUserResult.data.avatar}" +
                    $"\nSupport Text: {singleUserResult.support.text}" +
                    $"\nSupport Url: {singleUserResult.support.url}\n");

                //'GET' Single User Not Found
                Console.WriteLine("'GET' Single User Not Found");
                var singleUserNotFound = await http.GetAsync("https://reqres.in/api/users/23");
                Console.WriteLine($"Status: {singleUserNotFound.StatusCode}");
                string newSingleUserNotFound = await singleUserNotFound.Content.ReadAsStringAsync();
                Console.WriteLine($"{newSingleUserNotFound}\n");

                //'GET' List <Resource>
                Console.WriteLine("'GET' List <Resource>");
                var listResource = await http.GetAsync("https://reqres.in/api/unknown");
                Console.WriteLine($"Status: {listResource.StatusCode}");
                string newlistResource = await listResource.Content.ReadAsStringAsync();
                var newlistResourceResult = JsonConvert.DeserializeObject<PageSingle>(newlistResource);
                foreach (var item in newlistResourceResult.data)
                {
                    Console.WriteLine($"Id: {item.id}, Name: {item.name}, Year: {item.year}, Color: {item.color}, Pantone value {item.pantone_value}");
                }
                Console.WriteLine($"Page: {newlistResourceResult.page}, Total: {newlistResourceResult.total}, Per Page: {newlistResourceResult.per_page}, " +
                $"Total Pages: {newlistResourceResult.total_pages}\nSupport Text: {newlistResourceResult.support.text}\nSupport Url: {newlistResourceResult.support.url}\n");

                //'GET' Single <Resource>
                Console.WriteLine("'GET' Single <Resource>");
                var singleResource = await http.GetAsync("https://reqres.in/api/unknown/2");
                Console.WriteLine($"Status: {singleResource.StatusCode}");
                string newSingleResource = await singleResource.Content.ReadAsStringAsync();
                var newSingleResourceResult = JsonConvert.DeserializeObject<SingleResource>(newSingleResource);
                Console.WriteLine($"Id: {newSingleResourceResult.data.id}, Name: {newSingleResourceResult.data.name}, " +
                    $"Color: {newSingleResourceResult.data.color}, " +
                    $"Year: {newSingleResourceResult.data.year}, Pantone value: {newSingleResourceResult.data.pantone_value}" +
                    $"\nSupport Text: {newSingleResourceResult.support.text}" +
                    $"\nSupport Url: {newSingleResourceResult.support.url}\n");

                //'GET' Single <Resource> Not Found
                Console.WriteLine("'GET' Single <Resource> Not Found");
                var singleNotFound = await http.GetAsync("https://reqres.in/api/unknown/23");
                Console.WriteLine($"Status: {singleNotFound.StatusCode}");
                string newSingleNotFound = await singleNotFound.Content.ReadAsStringAsync();
                Console.WriteLine($"{newSingleNotFound}\n");

                //'POST' Create
                Console.WriteLine("'POST' Create");
                User userFirst = new User
                {
                    name = "morpheus",
                    job = "leader"
                };
                string serializedCreate = JsonConvert.SerializeObject(userFirst);
                var create = await http.PostAsync("https://reqres.in/api/users", new StringContent(serializedCreate, Encoding.UTF8, "application/json"));
                Console.WriteLine($"Status: {create.StatusCode}");
                string newCreate = await create.Content.ReadAsStringAsync();
                Console.WriteLine($"{newCreate}\n");

                //'PUT' Update
                Console.WriteLine("'PUT' Update");
                User userSecond = new User
                {
                    name = "morpheus",
                    job = "leader"
                };
                string serializedUpdate = JsonConvert.SerializeObject(userSecond);
                var update = await http.PutAsync("https://reqres.in/api/users/2", new StringContent(serializedUpdate, Encoding.UTF8, "application/json"));
                Console.WriteLine($"Status: {update.StatusCode}");
                string newUpdate = await update.Content.ReadAsStringAsync();
                Console.WriteLine($"{newUpdate}\n");

                //'PATCH' Update
                Console.WriteLine("'PATCH' Update");
                string serializedUpdatePatch = JsonConvert.SerializeObject(userSecond);
                var updatePatch = await http.PatchAsync("https://reqres.in/api/users/2", new StringContent(serializedUpdatePatch, Encoding.UTF8, "application/json"));
                Console.WriteLine($"Status: {updatePatch.StatusCode}");
                string newUpdatePatch = await updatePatch.Content.ReadAsStringAsync();
                Console.WriteLine($"{newUpdatePatch}\n");

                //'DELETE'
                Console.WriteLine("'DELETE'");
                var delete = await http.DeleteAsync("https://reqres.in/api/unknown/2");
                Console.WriteLine($"Status: {delete.StatusCode}");

                //'POST' REGISTER - SUCCESSFUL
                Console.WriteLine("'POST' REGISTER - SUCCESSFUL");
                Register registerSucc = new Register()
                {
                    email = "eve.holt@reqres.in",
                    password = "pistol"
                };
                string serializedRegisterSucc = JsonConvert.SerializeObject(registerSucc);
                var registerPostSucc = await http.PostAsync("https://reqres.in/api/register", new StringContent(serializedRegisterSucc, Encoding.UTF8, "application/json"));
                Console.WriteLine($"Status: {registerPostSucc.StatusCode}");
                string newRegisterPostSucc = await registerPostSucc.Content.ReadAsStringAsync();
                Console.WriteLine($"{newRegisterPostSucc}\n");

                //'POST' REGISTER - UNSUCCESSFUL
                Console.WriteLine("'POST' REGISTER - UNSUCCESSFUL");
                Register registerUnsucc = new Register()
                {
                    email = "sydney@fife",
                };

                string serializedRegisterUnsucc = JsonConvert.SerializeObject(registerUnsucc);
                var registerPostUnsucc = await http.PostAsync("https://reqres.in/api/register", new StringContent(serializedRegisterUnsucc, Encoding.UTF8, "application/json"));
                Console.WriteLine($"Status: {registerPostUnsucc.StatusCode}");
                string newRegisterPostUnsucc = await registerPostUnsucc.Content.ReadAsStringAsync();
                Console.WriteLine($"{newRegisterPostUnsucc}\n");

                //'POST' LOGIN - SUCCESSFUL
                Console.WriteLine("'POST' LOGIN - SUCCESSFUL");
                Register loginSucc = new Register()
                {
                    email = "eve.holt@reqres.in",
                    password = "cityslicka"
                };
                string serializedLoginSucc = JsonConvert.SerializeObject(loginSucc);
                var loginPostSucc = await http.PostAsync("https://reqres.in/api/login", new StringContent(serializedLoginSucc, Encoding.UTF8, "application/json"));
                Console.WriteLine($"Status: {loginPostSucc.StatusCode}");
                string newLoginPostSucc = await loginPostSucc.Content.ReadAsStringAsync();
                Console.WriteLine($"{newLoginPostSucc}\n");


                //'POST' LOGIN - UNSUCCESSFUL
                Console.WriteLine("'POST' LOGIN - UNSUCCESSFUL");
                Register loginUnsucc = new Register()
                {
                    email = "peter@klaven",
                };
                string serializedLoginUnsucc = JsonConvert.SerializeObject(loginUnsucc);
                var loginPostUnsucc = await http.PostAsync("https://reqres.in/api/login", new StringContent(serializedLoginUnsucc, Encoding.UTF8, "application/json"));
                Console.WriteLine($"Status: {loginPostUnsucc.StatusCode}");
                string newLoginPostUnsucc = await loginPostUnsucc.Content.ReadAsStringAsync();
                Console.WriteLine($"{newLoginPostUnsucc}\n");

                //'GET' Delayed Response
                Console.WriteLine("'GET' Delayed Response");
                var delayed = await http.GetAsync("https://reqres.in/api/users?delay=3");
                Console.WriteLine($"Status: {delayed.StatusCode}");
                string newDelayed = await delayed.Content.ReadAsStringAsync();
                var newDelayedResult = JsonConvert.DeserializeObject<PageList>(newDelayed);
                Console.WriteLine($"Page: { newDelayedResult.page}, Total: {newDelayedResult.total}, Per Page: {newDelayedResult.per_page}," +
                    $" Total Pages: {newDelayedResult.total_pages}\nSupport Text: {newDelayedResult.support.text}\nSupport Url: {newDelayedResult.support.url}");
                foreach (var item in newDelayedResult.data)
                {
                    Console.WriteLine($"Id: {item.id}, Full Name: { item.first_name} { item.last_name}, Email: {item.email}, Avatar: {item.avatar} ");
                }
            }
        }
    }
}
