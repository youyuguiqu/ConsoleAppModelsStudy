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
            Student student = new Builder().setAge(18).setName("小明").setSchool("牛头山学校").build();
            string name = student.name;
            Console.WriteLine(Newtonsoft.Json.JsonConvert.SerializeObject(student));
            Console.ReadLine();
            
        }
    }
}
