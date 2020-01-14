using System;
using System.Collections.Generic;
using System.Text;

namespace CSharpOnline.Lessons
{   /*This class goes over content for lesson 8
    Control Flow Statements*/
    public class Lesson8
    {

        // Basic if statement
        public void BasicIfStatement()
        {
            int val = 17;
            Console.WriteLine("Before if Statement");
            if(val > 12)
            {
                Console.WriteLine("Statement was valid");
            }
            Console.WriteLine("After if statement");
        }

        // Basic if/else statement
        public void BasicIfElseStatement(int num)
        {
            if(num >= 15)
            {
                Console.WriteLine("Statement was valid");
            } else
            {
                Console.WriteLine("Statment was not valid");
            }
        } 

        // Basic if/else chain
        public string BasicIfElseChainExample(int able)
        {
            if(able == 10)
            {
                return "The value was 10";
            }
            else if(able == 15)
            {
                return "The value was 15";
            }
            else
            {
                return "The value is " + able;
            }
        }

        // This method uses the && operator
        public bool BasicAndConditionExample()
        {
            int beta = 18;
            if(beta > 15 && beta < 30)
            {
                return true;
            } else
            {
                return false;
            }
        }

        // This method uses the || operator
        public int BasicOrCondition(int charlie)
        {
            if(charlie == 12 || charlie > 13)
            {
                return charlie;
            } else
            {
                return 0;
            }
        }

        // This method shows a shortcut statement called the ternary operator.
        public void BasicTernaryExample(int beta)
        {
            string valid = beta > 30 ? "valid" : "not valid";
            Console.WriteLine(valid);
        }

        // This method shows a basic switch statement
        public void BasicSwitchExample(int able)
        {
            switch(able)
            {
                case 1:
                case 2:
                    Console.WriteLine("1 or 2 was chosen");
                    break;
                case 3:
                    Console.WriteLine("3 was chosen");
                    break;
                case 4:
                    Console.WriteLine("4 was chosen");
                    break;
                case 5:
                    Console.WriteLine("5 was chosen");
                    break;
                default:
                    Console.WriteLine("Th number was greater than 5");
                    break;

            }
        }

        // Basic while loop
        public void BasicWhileLoop()
        {
            int socks = 0;
            while(socks < 13)
            {
                Console.WriteLine("number = {0}", socks);
                socks++;
            }
        }

        // Basic do while loop
        public void BasicDoWhileExample()
        {
            int beta = 0;
            do
            {
                Console.WriteLine("Do While Number = {0}", beta);
                beta++;
            } while (beta < 12);
        }

        // This method shows a basic for loop
        public void BasicForLoopExample(int total)
        {
            for(int i = 0; i < total; i++)
            {
                Console.WriteLine("For Number = {0}", i);
            }
        }

        // This method shows a foreach loop
        public void BasicForEachExample()
        {
            foreach(char word in "something")
            {
                Console.WriteLine(word);
            }
        }

        // This method shows jump statements
        public void BasicJumpStatements()
        {
            for(int i = 0; i < 10; i++)
            {
                if(i == 2)
                {
                    continue;
                }

                if( i == 4)
                {
                    Console.WriteLine("loop breaks");
                    break;
                }
                Console.WriteLine(i);
            }
        }

    } // end class
}// end namespace
