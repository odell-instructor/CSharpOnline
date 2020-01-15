using System;
using System.Collections.Generic;
using System.Text;

namespace CSharpOnline.Lessons
{
    /*This class will show different ways to create arrays
     Lesson 9 Arrays*/
    public class Lesson9
    {

        // This method shows different arrays
        public void BasicArrayDeclarations()
        {
            int[] myIntArray = new int[3];
            int[] myOtherArray = { 1, 3, 5 };
            int[] myThirArray = new int[] { 1, 5, 10 };
        }

        // Basic array with for loop
        public void BasicArray()
        {
            int[] intArray = { 2, 5, 34, 56, 28, 32 };
            for(int i = 0; i < intArray.Length; i++)
            {
                Console.WriteLine(intArray[i]);
            }
        } 

        // Two-dimensional Array with 2 for loops
        public void MultiArray2D()
        {
            int[,] sample2D = new int[2, 2];
            sample2D[0, 0] = 2;
            sample2D[0, 1] = 4;
            sample2D[1, 0] = 6;
            sample2D[1, 1] = 8;
          
            for(int i = 0; i < sample2D.GetLength(0); i++)
            {
                for(int k = 0; k < sample2D.GetLength(1); k++)
                {
                    Console.WriteLine(sample2D[i, k]);
                } // end inner loop
            } // end outer loop
        }

        // This method will demonstrate a 3D Array
        public void My3DArray()
        {
            int[,,] my3DArray = new int[2, 2, 3]
                { {{1,2,3} , {4,5,6}} , {{7,8,9} , {10, 11, 12}} };

            for(int i = 0; i < my3DArray.GetLength(0); i++)
            {
                for(int k = 0; k < my3DArray.GetLength(1); k++)
                {
                    for(int m = 0; m < my3DArray.GetLength(2); m++)
                    {
                        //Console.WriteLine(my3DArray[i, k, m]);
                        Console.WriteLine($"{i.ToString()},{k.ToString()}," +
                            $"{m.ToString()} : {my3DArray.GetValue(i, k, m)} ");

                    } // end inner inner for loop
                } // end inner for loop
            } // end outer for loop
        }

        // A basic jagged array with 2 loops
        public void MyJaggedArray()
        {
            int[][] sampleArray = new int[3][];
            sampleArray[0] = new int[]{ 2, 5};
            sampleArray[1] = new int[] { 6, 8, 12 };
            sampleArray[2] = new int[] { 13, 15, 17, 19, 21 };

            for(int i = 0; i < sampleArray.Length; i++)
            {
                Console.WriteLine("Row({0}):", i);
                for(int k = 0; k < sampleArray[i].Length; k++)
                {
                    Console.WriteLine("{0}", sampleArray[i][k]);
                } // end inner loop
                Console.WriteLine();
            } // end outer loop
        }

    } // end class
} // end namespace
