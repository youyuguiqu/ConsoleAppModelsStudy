using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleAppModelsStudy
{
    public abstract class AbstractCalculateClass
    {
        public abstract int OperCalculater(int num1, int num2);
    }

    public class Plus : AbstractCalculateClass
    {
        public override int OperCalculater(int num1, int num2)
        {
            int result = num1 + num2;
            return result;
        }

    }

    public class Subtraction : AbstractCalculateClass
    {
        public override int OperCalculater(int num1, int num2)
        {
            int result = num1 - num2;
            return result;
        }
    }
}
