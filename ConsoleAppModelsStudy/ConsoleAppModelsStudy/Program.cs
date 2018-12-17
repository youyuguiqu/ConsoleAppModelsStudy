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
            //模板模式
            //加法
            AbstractCalculateClass calculate = new Plus();
            int result= calculate.OperCalculater(5,8);
            Console.WriteLine("加法的结果是：{0}",result);

            //减法
            AbstractCalculateClass subtraction = new Subtraction();
            result = calculate.OperCalculater(5, 8);
            Console.WriteLine("减法的结果是：{0}", result);
            Console.ReadLine();
            
        }
    }
}
