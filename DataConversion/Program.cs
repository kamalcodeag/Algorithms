using Newtonsoft.Json;
using System;

namespace DataConversion
{
    class Program
    {
        public static void Main()
        {
            string jsonOutput = @"
            {
                ""firstName"" : ""Kamal"",
                ""lastName"" : ""Pasha"",
                ""services"" : 
                [
                    {
                        ""serviceName"" : ""Domain"",
                        ""packages"" : 
                        [
                            {
                                ""packageName"" : ""Standart""
                            },
                            {
                                ""packageName"" : ""Medium""
                            },
                            {
                                ""packageName"" : ""Premium""
                            }
                        ]
                    },
                    {
                        ""serviceName"" : ""Hosting"",
                        ""packages"" : 
                        [
                            {
                                ""packageName"" : ""Standart""
                            },
                            {
                                ""packageName"" : ""Medium""
                            },
                            {
                                ""packageName"" : ""Premium""
                            },
                            {
                                ""packageName"" : ""Ultra""
                            },
                        ]
                    },
                    {
                        ""serviceName"" : ""Hosting"",
                        ""packages"" : 
                        [
                            {
                                ""packageName"" : ""Standart""
                            },
                            {
                                ""packageName"" : ""Medium""
                            },
                            {
                                ""packageName"" : ""Premium""
                            },
                            {
                                ""packageName"" : ""Ultra""
                            },
                            {
                                ""packageName"" : ""Extra""
                            },
                            {
                                ""packageName"" : ""VIP""
                            },
                        ]
                    }
                ]
            
            }";

            Customer customer = JsonConvert.DeserializeObject<Customer>(jsonOutput);

            Console.WriteLine(customer.Services[0].Packages[1].PackageName);
        }
    }
}
