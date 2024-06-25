using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace JustTest
{
    internal class Program
    {
        class PaParent
        {
            public int counter = 0;
            public void CountPaParent()
            {
                PaParent pa = new PaParent();
                pa.counter++;
            }
        }
        class Parent : PaParent
        {
            
            public void CountParent()
            {
                Parent pa = new Parent();
                pa.counter++;
            }
        }
        class Child : Parent
        {
            public void CountChild()
            {
                Child child = new Child();
                child.counter++;
            }
        }
        class Child2 : Parent
        {
            public void CountChild()
            {
                Child2 child2 = new Child2();
                child2.counter++;
            }
        }


        static void Main(string[] args)
        {
            Parent parent = new Parent();
            Child child = new Child();
            Child2 child2 = new Child2();
            PaParent pa = new PaParent();
            pa.CountPaParent();
            parent.CountParent();
            child.CountChild();
            Console.WriteLine(parent.counter);
            Console.WriteLine(child.counter);
            Console.WriteLine(child2.counter);
            Console.WriteLine(pa.counter);
        }
    }
}
