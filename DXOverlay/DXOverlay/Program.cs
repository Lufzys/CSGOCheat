using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;

namespace DXOverlay
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.Title = "DXOverlay - Example Cheat";
            Console.ForegroundColor = ConsoleColor.Cyan;
            Console.WriteLine(" \n  DXOverlay - Example Cheat for CSGO");
            if(System.Diagnostics.Process.GetProcessesByName("csgo").Length != 0)
            {
                Console.WriteLine("  Menu Key - Insert");
                Overlay overlay = new Overlay();
                overlay.Init("csgo");
            }
            else
            {
                Console.ForegroundColor = ConsoleColor.Red;
                Console.WriteLine("  Error : CSGO not found!");
                Thread.Sleep(2500);
            }
        }
    }
}
