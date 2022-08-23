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

            Console.WriteLine("숫자 입력");
            int output;
            bool result = int.TryParse(Console.ReadLine(), out output);
            if (result)
            {
                Console.WriteLine("숫자를 입력해주세요");

            }
            int x = 0; int y = 0;
            int vx = 1; int vy=1;
            Console.WriteLine("현재 좌표" + x + y);
            NextPos(x, y, vx, vy, out x, out y);
            Console.WriteLine("다음 좌표" + x + y);

        }

        static void NextPos(int x, int y, int vx, int vy, out int rx, out int ry)
        {
            rx = x + vx;
            ry = y + vy;
        }


    }
}
