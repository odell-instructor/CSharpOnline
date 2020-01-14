using System;
using System.Collections.Generic;
using System.Text;

namespace CSharpOnline
{
    // This class sings a song using different statements
    public class BottlesOfBeer
    {
        int _beerNum = 99;
        string _word = "bottles", _result;

        public string LetsSing()
        {
            while(_beerNum > 0)
            {
                if(_beerNum == 1)
                {
                    _word = "bottle";
                }

                Console.WriteLine("{0} {1} of beer on the wall", _beerNum, _word);
                Console.WriteLine("{0} {1} of beer", _beerNum, _word);
                Console.WriteLine("Take one down");
                Console.WriteLine("Pass it around");

                _beerNum--;
                if(_beerNum > 0)
                {
                    Console.WriteLine("{0} {1} of beer on the wall", _beerNum, _word);
                    Console.WriteLine();
                }
                else
                {
                    _result = "No more bottles of beer on the wall.";
                }
            }
            return _result;
        }


    } // end class
} // end namespace
