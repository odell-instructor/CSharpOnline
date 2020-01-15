﻿using System;
using CSharpOnline.Lessons;

namespace CSharpOnline
{
    class Program
    {
        static void Main(string[] args)
        {
            MyLesson9Examples();
            // BottlesOfBeerSong();
            //MyLesson8Examples();
            //MyLesson7Examples();
            //MyLesson6Examples();
            //MyLesson5Examples();
           // Console.WriteLine("Hello World!");
           // House myHouse = new House();
        }

        static void MyLesson9Examples()
        {
            Lesson9 myNine = new Lesson9();
            myNine.BasicArray();
            myNine.MultiArray2D();
            myNine.My3DArray();
            myNine.MyJaggedArray();
        }

        static void BottlesOfBeerSong()
        {
            BottlesOfBeer beer = new BottlesOfBeer();
            Console.WriteLine(beer.LetsSing());
        }

        static void MyLesson8Examples()
        {
            Lesson8 myEight = new Lesson8();
            myEight.BasicIfStatement();
            myEight.BasicIfElseStatement(23);
            Console.WriteLine(myEight.BasicIfElseChainExample(22));
            Console.WriteLine(myEight.BasicAndConditionExample());
            Console.WriteLine(myEight.BasicOrCondition(25));
            myEight.BasicTernaryExample(42);
            myEight.BasicSwitchExample(3);
            myEight.BasicWhileLoop();
            myEight.BasicDoWhileExample();
            myEight.BasicForLoopExample(4);
            myEight.BasicForEachExample();
            myEight.BasicJumpStatements();
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
