using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleAppModelsStudy
{
    class Program
    {
        static void Main(string[] args)
        {

            ITarget target = new AdapterClass();
            target.Request();
            Console.ReadLine();
            
        }
    }
}
