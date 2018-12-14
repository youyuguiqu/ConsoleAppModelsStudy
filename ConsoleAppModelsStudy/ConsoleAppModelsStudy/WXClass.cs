using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleAppModelsStudy
{
    class WXClass : IMessageInfo
    {
        #region IMessageInfo 成员

        public void SendMsg()
        {
            Console.WriteLine("wx message");
        }

        #endregion
    }
}
