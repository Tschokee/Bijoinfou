using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using FusionGeneDatabase;

namespace FusionConsole
{
    class Program
    {
        static void Main(string[] args)
        {
            try
            {
                algorithm a = new algorithm(args[0], args[1], args[2]);
                a.futtat();
            }
                
            catch (Exception e) {
                System.Console.WriteLine("Bad Args");
            
            }
            

        }
    }
}
