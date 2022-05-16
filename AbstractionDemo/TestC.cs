using System;
using System.Collections.Generic;
using System.Text;

namespace AbstractionDemo
{
    public abstract class TestC
    {
        private string name;

        public TestC()
        {

        }
        public TestC(string name)
        {
            this.name = name;
        }
        public string Name
        {
            get { return name; }
            set { value = name; }
        }
        public void PrintInfor()
        {
            Console.WriteLine("\nName : " + Name);
        }
        public abstract void ShowInfor();
    }
}
