using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Singleton
{
    class Program
    {
        static void Main(string[] args)
        {
            Singleton one = Singleton.Instans();
            Singleton two = Singleton.Instans();
            Console.WriteLine(ReferenceEquals(one,two));
            two.SingeltonOperation();
            Console.WriteLine(one.GetSingData());
            Console.ReadKey();
        }
    }
}
