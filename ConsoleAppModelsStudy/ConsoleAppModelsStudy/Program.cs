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
            //建造者模式
            Builder sb = new Builder();
            sb.setAge(12).setName("xiaoming").setNumber(80).setSchool("youmayizhong").setSex("man");
            Console.WriteLine(Newtonsoft.Json.JsonConvert.SerializeObject(sb));
            Console.ReadLine();
            
        }
    }
}
