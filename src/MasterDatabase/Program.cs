using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace MasterDatabase
{
    public class Program
    {
        public static void Main(string[] args)
        {
            if (args.Length == 0 || args[0] == "--help")
            {
                Console.WriteLine(@"Usage: MasterDatabase [OPTION]
  -d                   download data
  -e                   extract openings
");
                return;
            }
            switch (args[0])
            {
                case "-d":
                    Downloader d = new Downloader();
                    d.Execute();
                    Console.WriteLine(@"...done");
                    break;
                case " - e":
                    Extractor e = new Extractor();
                    e.Execute();
                    Console.WriteLine(@"...done");
                    break;
            }
        }
    }
}
