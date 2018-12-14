using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleAppModelsStudy
{
    class Common
    {
        public static void SingleFactoryUtil(string s) 
        {
            IMessageInfo msg = null;
            FactoryModel model = new FactoryModel();
            if ("sms".Equals(s))
            {
                msg = model.CreateObject(s);
                msg.SendMsg();
            }
            else if ("mail".Equals(s))
            {
                msg = model.CreateObject(s);
                msg.SendMsg();
            }
            else if ("wx".Equals(s))
            {
                msg = model.CreateObject(s);
                msg.SendMsg();
            }
            else
            {
                Console.WriteLine("没有改选项！");
            }
        }
    }
}
