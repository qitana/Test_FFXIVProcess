using System;
using System.Diagnostics;
using System.Runtime.InteropServices;

namespace ConsoleApp_Success
{
    class Program
    {
        [DllImport("kernel32.dll")]
        public static extern IntPtr OpenProcess(int dwDesiredAccess, bool bInheritHandle, int dwProcessId);

        [DllImport("kernel32.dll")]
        static extern int CloseHandle(IntPtr hObject);

        static void Main(string[] args)
        {
            Process[] processesByName = Process.GetProcessesByName("ffxiv_dx11");
            foreach (Process process in processesByName)

            {
                IntPtr processHandle = OpenProcess(0x0010, false, process.Id);
                Console.WriteLine(processHandle.ToInt64());
                CloseHandle(processHandle);
            }

            Console.ReadLine();

        }
    }
}
