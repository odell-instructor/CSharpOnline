using System;
using CSharpOnline.Lessons;

namespace CSharpOnline
{
    class Program
    {
        static void Main(string[] args)
        {
            MyLesson5Examples();
           // Console.WriteLine("Hello World!");
           // House myHouse = new House();
        }

        static void MyLesson5Examples()
        {
            Lesson5 myFive = new Lesson5();
            myFive.ConvertFloatToInt();
            myFive.LongFromInt();
        }
    }
}
