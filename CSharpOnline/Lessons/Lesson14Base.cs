using System;
using System.Collections.Generic;
using System.Text;

namespace CSharpOnline.Lessons
{
    /* This class goes over Lesson 14 content, Abstractr */
    public abstract class Lesson14Base : ILesson14
    {
        protected double inches = 12, feet = 3, yard = 1760;
        protected int num;

        public abstract void ShowResultFeet();
        public abstract void ShowResultMiles();

        public abstract double FeetToInches { get; }
        public abstract double YardsToFeet { get; }
        public abstract double MilesToYards { get; }

        public Lesson14Base(int num)
        {
            this.num = num;
        }

    } // end class
} // end namespace
