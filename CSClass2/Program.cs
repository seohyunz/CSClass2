using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CSClass2
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Wansted<string> wanstedString = new Wansted<string>("String");
            Wansted<int> wanstedInt = new Wansted<int>(1234);
            Wansted<double> wanstedDouble = new Wansted<double>(1234.123);

            Console.WriteLine(wanstedString.Value);
            Console.WriteLine(wanstedInt.Value);
            Console.WriteLine(wanstedDouble.Value);

            Products p = new Products();
            Console.WriteLine(p[4]);
            p[4] = 5;


        }
    }
}
