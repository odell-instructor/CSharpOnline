using System;
using System.Collections.Generic;
using System.Text;

namespace CSharpOnline.Lessons
{
    /* This class goes over Lesson 14 content. Derived class*/
    public class Lesson14Derived : Lesson14Base
    {
        public override double FeetToInches 
        { get { return num * inches; } }

        public override double YardsToFeet
        { get { return num * feet; } }

        public override double MilesToYards
        { get { return num * yard; } }

        public Lesson14Derived(int num)
            : base(num) {  }

        public override void ShowResultFeet()
        {
            Console.WriteLine("Your number {0} in feet is {1} inches", num, FeetToInches);
            Console.WriteLine("Your number {0} in yards is {1} feet", num, YardsToFeet);
        }

        public override void ShowResultMiles()
        {
            Console.WriteLine("Your number {0} in miles is {1} yards", num, MilesToYards);
        }


    } // end class
} // end namespace
