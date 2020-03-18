using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;

namespace LogReader
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("LogReader starts now.");
            Console.WriteLine("Press ENTER to quit.");
            Console.WriteLine("-----------------------------------------------------------");
            Console.WriteLine("");

            using (FileStream stream = File.Open(@"C:\Users\fboid\Documents\ScopeTest\Log.csv", FileMode.Open, FileAccess.Read, FileShare.ReadWrite))
            {
                using (StreamReader reader = new StreamReader(stream))
                {
                    while (true) 
                    {
                        if (Console.KeyAvailable)
                        {
                            if (Console.ReadKey().Key == ConsoleKey.Enter)
                                break;
                        }
                        
                        if (!reader.EndOfStream)
                            Console.Write(Convert.ToChar(reader.Read()));
                        
                    } 
                }
            }
            Console.WriteLine("");
            Console.WriteLine("");
            Console.WriteLine("-----------------------------------------------------------");
            Console.WriteLine("LogReader exits now.");
            Thread.Sleep(1000);
        }
    }
}
