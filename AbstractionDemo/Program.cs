using System;
using System.Text;
using System.Threading.Tasks;
using System.Collections;

namespace AbstractionDemo
{
    class Program
    {
        static void Main(string[] args)
        {
            TestA a = new TestA();
            a.Display();
            a.Print();
            a.SayHello();
            Console.WriteLine(a.Sum(3.0f, 5.0f));
            Console.WriteLine(a.Sum(3, 5));

            TestD d = new TestD();
            d.Name = "Ngoc Trinh";
            d.ShowInfor();
            d.PrintInfor();
            Console.ReadLine();
        }
    }
}
