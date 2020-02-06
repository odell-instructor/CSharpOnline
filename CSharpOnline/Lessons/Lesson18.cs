using System;
using System.Collections.Generic;
using System.Text;

namespace CSharpOnline.Lessons
{
    /* This class goes over lesson 18 content
     Exceptions */
    public class Lesson18
    {
        public void MyThrowExample(House house)
        {
            if (house == null)
            {
                throw new NullReferenceException("house object was null");
            }
            Console.WriteLine(house.DoorColor);
        }

        public void MyException(House house)
        {
            try
            {
                Console.WriteLine(house.Foundation);
            }
            catch(NullReferenceException ex)
            {
                Console.WriteLine("Null exception thrown " + ex.Message);
            }
        }

        public void MyArrayException()
        {
            string[] names = { "Dave", "Matt", "Jody" };
            string[] values = { "24", "42", "38" };
            try
            {
                byte b = byte.Parse(values[1]);
                Console.WriteLine(b);
            }
            catch (IndexOutOfRangeException ex)
            {
                Console.WriteLine("Please provide at least 1 argument - " + ex.Message);
            }
            catch (FormatException e)
            {
                Console.WriteLine("That is not a number - " + e.Message);
            }
            catch (OverflowException oe)
            {
                Console.WriteLine("You have given me more than a byte - " + oe.Message);
            }
            finally
            {
                Console.WriteLine("Finally block called");
            }
        }

    } // end class
} // end namespace
