using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DelegateHomework
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Input word : ");
            string word = Console.ReadLine();
            MyClass myClass = new MyClass();
            Func funcDel = new Func(myClass.Reverse);
            funcDel += myClass.Space;
            Run run = new Run();
            run.RunF(funcDel, word);
        }
    }
}
