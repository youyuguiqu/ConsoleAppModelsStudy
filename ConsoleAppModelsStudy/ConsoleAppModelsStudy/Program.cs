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
            //抽象工厂模式
            while (true)
            {
                Console.WriteLine("请输入以下选项：wx、sms、mail");
                string s = Console.ReadLine();
                if ("exit".Equals(s) || "quit".Equals(s))
                {
                    break;
                }
                else
                {
                    switch (s)
                    {
                        case "sms":
                            Common.SendMessage(new SMSFactoryClass());
                            break;
                        case "mail":
                            Common.SendMessage(new MailfactoryClass());
                            break;
                        case "wx":
                            Common.SendMessage(new WXFactoryClass());
                            break;
                        default:
                            Console.WriteLine("无该选项，请你重新选择。");
                            break;
                    }
                }
            }
        }
    }
}
