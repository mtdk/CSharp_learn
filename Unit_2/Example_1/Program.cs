using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
//两种空间引用模式
//这是第一种
using MyNamespace;

namespace Example_1
{
    class Program
    {
        static void Main(string[] args)
        {
            //这是第二种
            //MyNamespace.MyClass obj = new MyNamespace.MyClass();
            MyClass obj = new MyClass();
        }
    }
}

namespace MyNamespace
{
    public class MyClass { }
}