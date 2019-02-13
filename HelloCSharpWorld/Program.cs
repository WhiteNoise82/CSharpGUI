using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HelloCSharpWorld
{
    class Program
    {
        static void Main(string[] args)
        {
            byte a = 255; // 0 ~ 255
            sbyte b = -128; // -108 ~ 107
            short c = 5; // -32768 ~ 32767
            ushort d = 10; // 0 ~ 65535

            Console.WriteLine("안녕 C# 월드!");
            Console.WriteLine("Hello, world!");
            //Console.WriteLine("{0} {1}", args[0], args.Length);

            Console.WriteLine(a + ", " + b);

        }
    }
}
