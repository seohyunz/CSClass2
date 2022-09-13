using CSClass2;
using System;
using System.Collections.Generic;
using System.IO;
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

//StreamWriter writer = new StreamWriter(@"C:\Temp\test.txt")
using (StreamWriter writer = new StreamWriter(@"C:\Temp\test.txt"))
{
    string line;
    while((line = BinaryReader.ReadLine()) != null)
    {
        Console.WriteLine(File.ReadAllText(@"C:\Temp\test.txt"));
    }

    writer.WriteLine("안녕하세요");
    writer.WriteLine("StreamWriter 클래스를 사용해");
    writer.WriteLine("글자를");
    writer.WriteLine("여러줄");
    writer.WriteLine("입력해봅시다");
    for(int i =0; i<10; i++)
    {
        writer.WriteLine("반복문" + i);
    }

}
Console.WriteLine(File.ReadAllText(@"C:\Temp\test.txt"));

string[] arry = { "가", "나" };
Console.WriteLine("숫자를 입력해주세요 (예:1)");
int inpput = int.Parse(Console.ReadLine());
//catch(var exceptjon)-var는 예외 매개변수 부분에서 사용할 수 없다
try
{
    int index = int.Parse(input);
    Console.WriteLine("입력한 위치값" + arry[index]);
}

catch(Exception ex)
{
    Console.WriteLine("예외가 발생했군요");
    Console.WriteLine("GetType +" + ex.GetType());
    Console.WriteLine("Message" + ex.Message());
   
}
if(input <arry.Length)

    }
}
