using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleAppModelsStudy
{
    class FactoryModel
    {
        public IMessageInfo CreateObject(string type)
        {
            IMessageInfo msg = null;
            switch (type)
            {
                case "sms":
                    msg = new SMSClass();
                    break;
                case "mail":
                    msg = new MailClass();
                    break;
                case"wx":
                    msg = new WXClass();
                    break;
                default:
                    break;
            }
            return msg;
        }
    }
}
