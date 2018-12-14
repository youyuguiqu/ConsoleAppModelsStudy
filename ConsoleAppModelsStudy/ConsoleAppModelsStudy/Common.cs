using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleAppModelsStudy
{
    class Common
    {      
        public static void SendMessage(AbstractFactory factory)
        {
            IMessageInfo msg = factory.createPru();
            msg.SendMsg();
        }
    }
}
