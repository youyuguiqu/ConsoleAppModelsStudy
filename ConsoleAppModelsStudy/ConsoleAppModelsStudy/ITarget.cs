using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleAppModelsStudy
{
    /// <summary>
    /// 目标，客户端需要调用的
    /// </summary>
    interface ITarget
    {
        void Request();
    }
    /// <summary>
    /// 
    /// </summary>
    class Adaptee
    {
        public void SpecificRequest()
        {
            Console.WriteLine("适配者中的业务代码被调用！");
        }
    }

    /// <summary>
    /// 适配器
    /// </summary>
    class AdapterClass : Adaptee,ITarget
    {
        public void Request()
        {
            SpecificRequest();
        }
    }
}
