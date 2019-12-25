using System;
using System.Diagnostics;

namespace ConsoleApp_Fail
{
    class Program
    {
        static void Main(string[] args)
        {
            Process[] processesByName = Process.GetProcessesByName("ffxiv_dx11");
            foreach (Process process in processesByName)
            {
                IntPtr intPtr = process.Handle; // Exception here.
                Console.WriteLine(intPtr.ToInt64());
            }

            Console.ReadLine();
        }
    }
}
