using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Inheritence
{
    class Methodhiding
    {
     
    }
    class Parent
    {
        public void Show()
        {
            Console.WriteLine("This is the method of Parent Class");
        }
    }
    class Child : Parent
    {
        public new void  Show()
        {
            base.Show();
            Console.WriteLine("This is the method of Child Class");
        }
    }
}
