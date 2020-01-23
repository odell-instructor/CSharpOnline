using System;
using System.Collections.Generic;
using System.Text;

namespace CSharpOnline.Lessons
{
    public struct Lesson10Struct
    {
        private decimal _price;
        private string _author;
        private string _title;

        public Lesson10Struct(decimal price, string author, string title)
        {
            _price = price;
            _author = author;
            _title = title;

            Console.WriteLine("The title {0} from {1} costs ${2}", title, author, price);
        }

    } // end struct
} // end namespace
