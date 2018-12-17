using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleAppModelsStudy
{
    interface ISubject
    {
        void Add(IObserver observer);//增加观察者
        void Delete(IObserver observer);//删除观察者
        void NotifyOberver();//通知观察者
        void Operation();//自身变化的操作

    }
}
