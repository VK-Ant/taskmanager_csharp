using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Diagnostics;
using System.Management;
using System.IO;
using System.Security.Cryptography.X509Certificates;

namespace ConsoleAppvk
{
    class Program
    {
        private static List<string> process;

        static void Main(string[] args)
        {



            var path = @"C:\Users\VK\Desktop\vk.txt";

            string[] lines = { "old falcon", "deep forest", "golden ring" };
            File.WriteAllLines(path, lines);

            Console.WriteLine("lines written to file");
            // Create an array to store the processes
            //Process[] processList = Process.GetProcesses();

            // Loop through the array to show information of every process in your console
            
                //Console.WriteLine(@"
        //{0} | ID: {1} | Status {2} | Memory (private working set in Bytes) {3}",
                    //process.ProcessName, process.Id, process.Responding, process.PrivateMemorySize64);
                
            
            
            

        }
    }
}
