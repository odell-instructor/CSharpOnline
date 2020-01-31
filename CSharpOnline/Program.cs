using System;
using CSharpOnline.Lessons;

namespace CSharpOnline
{
    class Program
    {
        static void Main(string[] args)
        {
            MyLesson14Examples();
            //MyLesson13Examples();
            //MyLesson12Examples();
            //MyLesson11Examples();
            //MyLesson10Examples();
            //MyLesson9Examples();
            // BottlesOfBeerSong();
            //MyLesson8Examples();
            //MyLesson7Examples();
            //MyLesson6Examples();
            //MyLesson5Examples();
           // Console.WriteLine("Hello World!");
           // House myHouse = new House();
        }

        static void MyLesson14Examples()
        {
            Lesson14Static.CelsiusToFahrenheit("34.5");
            Console.WriteLine(Lesson14Static.FahrenheitToCelsius("64"));

            Lesson14Derived myLesson14 = new Lesson14Derived(8);
            myLesson14.ShowResultFeet();
            myLesson14.ShowResultMiles();

            Lesson14Base myBase = new Lesson14Derived(10);
            myBase.ShowResultFeet();
        }

        static void MyLesson13Examples()
        {
            House myHouse = new House();
            Console.WriteLine("The door color is {0}", myHouse.DoorColor);
            Condo myCondo = new Condo();
            myCondo.DoorOpenClose();
            Console.WriteLine("The foundation type is {0}", myCondo.Foundation);
        }

        static void MyLesson12Examples()
        {
            Lesson12 myTwelve = new Lesson12();
            myTwelve.BasicPublicMethod();
            Lesson12Child myChild = new Lesson12Child();
            myChild.BasicChildMethod();
            myTwelve.BasicProtectedInternalMethod();
        }

        static void MyLesson11Examples()
        {
            Condo myCondo = new Condo();
            myCondo.Maintenance();
            myCondo.DoorOpenClose();
            House myHouse = new House();
            myHouse.DoorOpenClose();
            myHouse.DoorOpenClose("Red");
        }

        static void MyLesson10Examples()
        {
            Lesson10 myTen = new Lesson10(); // default constructor
            Lesson10 myOtherTen = new Lesson10(10);
            Lesson10 lesson10 = new Lesson10(21, "apples");

            Lesson10Struct myStruct = new Lesson10Struct(9.99m, "King", "The Stand");

            int myVal1 = 14, myVal2 = 14;

            myTen.MyBasicRef(ref myVal1, myVal2);
            Console.WriteLine("My Val1 = {0} , My Val2 = {1}", myVal1, myVal2);

            string first, last;
            myTen.MyBasicOut("Foghorn Leghorn", out first, out last);
            Console.WriteLine(first);
            Console.WriteLine(last);
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
