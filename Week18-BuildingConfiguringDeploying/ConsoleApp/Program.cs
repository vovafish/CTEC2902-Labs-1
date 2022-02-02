using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Drawing;
using Console = Colorful.Console;
using System.Configuration;

namespace ConsoleApp
{
    class Program
    {
        static void Main(string[] args)
        {
          
            string greeting = Properties.Settings.Default.GreetingMessage;
            Console.WriteLine(greeting);
            string tiredMessage = ConfigurationManager.AppSettings["tiredMessage"];
            Console.WriteLine(tiredMessage);
            Console.WriteLine("Program has finished. Press enter to quit.", Color.Aquamarine);
            Console.ReadKey();



        }
    }
}
