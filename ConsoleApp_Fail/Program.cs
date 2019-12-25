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
                try
                {
                    IntPtr handle = process.Handle; // Win32Exception (0x80004005) here.
                    Console.WriteLine(handle.ToInt64());
                }
                catch (Exception ex)
                {
                    Console.WriteLine(ex.ToString());
                }
            }

            Console.ReadLine();
        }
    }
}
