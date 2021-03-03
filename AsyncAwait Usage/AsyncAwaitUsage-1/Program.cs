﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Threading;

namespace AsyncAwaitUsage_1
{
    class Program
    {
        static void Main(string[] args)
        {
            Method1().Wait();
            Console.Read();
        }
        public static async Task Method1()
        {
            Console.WriteLine("Method 1 Execution Started");
            Console.WriteLine("Waiting for the Message from Method 2");
            Task<string> T = method2();

            string s = await T;
            Console.WriteLine(s);
        }
        public static async Task<string> method2()
        {
            Console.WriteLine("Method 2 Execution Started");
            await Task.Delay(5000);
            return "Hello From Method 2";
        }
    }
}
