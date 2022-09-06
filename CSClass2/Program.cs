using CSClass2;
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
            int vx = 1; int vy = 1;
            Console.WriteLine("현재 좌표" + x + y);
            NextPos(x, y, vx, vy, out x, out y);
            Console.WriteLine("다음 좌표" + x + y);

            Point point; d
            point.x = 10;
            point.y = 10;
            point = new Point(3, 5);
            Console.WriteLine(point.x + "/" + point.y);
        }

        List<Product> list = new List<Product>()
        {
            new Product() {Name = "고구마", Price=5000},
            new Product() {Name = "사과", Price=3000},
            new Product() {Name = "바나나", Price=2000},
            new Product() {Name = "배", Price=9000},
        };

        list.Sort();
        foreach(var item in list){
            Console.WriteLint(item);
         }
     }

IBasic basic = new TestClass();
(basic as TestClass).someting();

class TestClass : IBasic
{
    public vodi someting() { }

}

        static void NextPos(int x, int y, int vx, int vy, out int rx, out int ry)
        {
            rx = x + vx;
            ry = y + vy;
        }

        struct Point
        {
            public int x;
            public int y;
            public String testA;
            public String testB;
            public Point(int x,int y, String testA, String testB)
            {
                this.x = x;
                this.y = y;
                this.testA = "초기화";
                this.testB = "초기화";

            }

            struct PointClass
            {
                public int x;
                public int y;

               /* public PointStruct(int x, int y)
                {
                    this.x = x;
                    this.y = y;
                }*/
            }
        }



Child c = new Child();
Parent childAsParent = c;
IDisposable childAsDispoable = c;
IComparable<Child> childAsComparable = c;

FileStyleUriParser.WriteAllText(@"C:\Temp\test.txt","문자열 메시지를 씁니다");
Console.WriteLine(FileStyleUriParser.ReadAllText(@"C:\Temp\test.txt"));


    }
}
