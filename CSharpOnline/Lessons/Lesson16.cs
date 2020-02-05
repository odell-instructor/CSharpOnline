using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace CSharpOnline.Lessons
{
    /* This class goes over lesson 16 content
     Collections & LINQ*/
    public class Lesson16
    {
        public void MyArrayListExample()
        {
            ArrayList myList = new ArrayList();
            myList.Add("Hello");
            myList.Add(42);
            myList.Add(true);
            myList.Add('T');
            PrintValues(myList);
        }

        private void PrintValues(IEnumerable myListing)
        {
            foreach (Object item in myListing)
            {
                Console.WriteLine("Values: {0}", item);
            }
        }

        public void MyHashtableExample()
        {
            Hashtable myHash = new Hashtable();
            myHash.Add(10, "CSharp");
            myHash.Add(20, 24);
            myHash.Add(30, "Rocks");
            myHash.Add(40, 'J');

            foreach (DictionaryEntry item in myHash)
            {
                Console.WriteLine("Key: {0}, Value: {1}", item.Key, item.Value);
            }
        }

        public void MyListExample()
        {
            List<string> myList = new List<string>();
            myList.Add("Alpha");
            myList.Add("Bravo");
            myList.Add("Charlie");
            myList.Add("Delta");

            foreach (string item in myList)
            {
                Console.WriteLine(item);
            }
        }

        public void MyHouseListExample()
        {
            List<House> myHouseList = new List<House>();
            myHouseList.Add(new House(24, "concrete"));
            myHouseList.Add(new House());
            myHouseList.Add(new House(36, "brick", "shingle", "red"));

            foreach (House item in myHouseList)
            {
                Console.WriteLine(item.DoorColor + " " + item.RoofType);
            }
        }

        public void MyDictionaryExample()
        {
            Dictionary<int, string> myList = new Dictionary<int, string>();
            myList.Add(10, "CSharp");
            myList.Add(20, "Rocks");
            myList.Add(30, "Happy");
            myList.Add(40, "Coding");

            // A single value we use TryGetValue
            string temp = "";
            if(myList.TryGetValue(20, out temp))
            {
                Console.WriteLine("Key 20 is {0}", temp);
            }

            // Use foreach to get all values using KeyValuePair
            foreach (KeyValuePair<int, string> item in myList)
            {
                Console.WriteLine("Key: {0}, Value: {1}", item.Key, item.Value);
            }

        }

        public void MyLinqExample()
        {
            int[] scores = new int[] { 97, 92, 88, 60, 55, 40, 20 };

            IEnumerable<int> query =
                from score in scores
                where score < 85
                select score;

            foreach (int item in query)
            {
                Console.WriteLine(item);
            }
        }

        public void MyOtherLinq()
        {
            List<House> houses = new List<House>();
            houses.Add(new House(23, "concrete"));
            houses.Add(new House(24, "steel", "plastic", "red"));
            houses.Add(new House());
            houses.Add(new House(32, "wood", "wood", "blue"));

            var subset = from myHouse in houses
                         where myHouse.RoofType == "composite"
                         orderby myHouse.DoorColor
                         select myHouse;

            foreach (House item in subset)
            {
                Console.WriteLine("My house has {0} roof", item.RoofType);
            }
        }

    } // end class
} // end namespace
