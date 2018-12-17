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
            IObserver one = new ObserverOne();
            IObserver two = new ObserverTwo();
            MySubject subject = new MySubject();
            subject.Add(one);
            subject.Add(two);
            subject.Operation();
            Console.ReadLine();
            
        }
    }
}
