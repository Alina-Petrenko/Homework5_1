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
            Starter starter = new Starter();
            await starter.GetMethodsAsync();
        }
    }
}
