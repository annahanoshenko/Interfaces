

using System;
using System.Threading;

namespace Action
{
    internal class Program
    {
        static void Main(string[] args)
        {
            FirstAction firstAction = new FirstAction();
            Foo(firstAction);
            Barr(firstAction);

            MyOtherClass myOtherClass = new MyOtherClass(); 
            Foo(myOtherClass);
            Barr(myOtherClass);

            Console.WriteLine();

            ((IFirstInterface) myOtherClass).Action();
           

            void Foo(IFirstInterface firstInterface)
             {
                firstInterface.Action();
             }

             void Barr(ISecondInterface secondInterface)
             {
                secondInterface.Action();
             }
        }
    }
}
