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
            //简单工厂模式
            while (true)
            {
                Console.WriteLine("请输入你的选项：sms 或者 mail");
                string s = Console.ReadLine();
                if ("exit".Equals(s) || "quit".Equals(s))
                {
                    break;
                }
                else
                {
                    Common.SingleFactoryUtil(s);
                }
            }
        }
    }
}
