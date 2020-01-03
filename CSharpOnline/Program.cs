using System;
using CSharpOnline.Lessons;

namespace CSharpOnline
{
    class Program
    {
        static void Main(string[] args)
        {
            MyLesson7Examples();
            //MyLesson6Examples();
            //MyLesson5Examples();
           // Console.WriteLine("Hello World!");
           // House myHouse = new House();
        }

        static void MyLesson7Examples()
        {
            Lesson7 mySeven = new Lesson7();
            mySeven.BasicMath();
            mySeven.BasicModulus();
            mySeven.BasicCheckedOperator(46, 85);
            mySeven.BasicCheckedOperator2();
            mySeven.BasicAssignmentExample();
            mySeven.MyLeftShiftOperator();
            mySeven.MyRightShiftOperator();
            mySeven.MyAndAssignmentOperator(10, 2);
            mySeven.MyOrAssignmentOperator();
            mySeven.MyXOrAssignmentOperator();
            mySeven.MyIncrementDecrementExamples();
        }

        static void MyLesson6Examples()
        {
            Lesson6 mySix = new Lesson6();
            mySix.MyTrimExample();
            mySix.MyEqualsExample();
            mySix.MyLowerUpperExample();
            mySix.MyStringLength();
            mySix.MyJoinedStrings("apple", "orange");
            string food = mySix.MyStringBuilder("pizza", 2);
            Console.WriteLine(food);
            mySix.MyExampleChar();
            mySix.MyEscapeExample();
            mySix.MyPlaceHolderExample("Galaga", "shooter");
        }

        static void MyLesson5Examples()
        {
            Lesson5 myFive = new Lesson5();
            myFive.ConvertFloatToInt();
            myFive.LongFromInt();
        }
    }
}
