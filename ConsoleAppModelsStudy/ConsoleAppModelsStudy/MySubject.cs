using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleAppModelsStudy
{
    class MySubject : ISubject
    {

        List<IObserver> observers = new List<IObserver>();

        public void Add(IObserver observer)
        {
            observers.Add(observer);
        }

        public void Delete(IObserver observer)
        {
            observers.Remove(observer);//observer必须存在list里面的，不能是新添加的
        }

        public void NotifyOberver()
        {
            foreach (var item in observers)
            {
                item.Update();
            }
        }

        public void Operation()
        {
            Console.WriteLine("发送通知！");
            NotifyOberver();
        }
    }
}
