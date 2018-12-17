using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleAppModelsStudy
{
    interface IObserver
    {
        void Update();

    }

    class ObserverOne : IObserver
    {
        public void Update()
        {
            Console.WriteLine("第一个观察者收到通知!");
        }
    }

    class ObserverTwo : IObserver
    {
        public void Update()
        {
            Console.WriteLine("第二个观察者收到通知！");
        }
    }
}
