using System;
using System.Collections.Generic;
using System.Text;

namespace CSharpDesignPatterns
{
    public class RoadBikeBuilder : BikeBuilder
    {
        private AbstractRoadBike _roadBikeInProgress;

        public override IBicycle Bicycle
        {
            get { return _roadBikeInProgress; }
        }

        public RoadBikeBuilder(AbstractRoadBike roadBike)
        {
            this._roadBikeInProgress = roadBike;
        }

        public override void BuildHandlebars()
        {
            Console.WriteLine("Building Roadbike handle bars.");
        }

        public override void BuildStreetTires()
        {
            Console.WriteLine("Building RoadBike Street Tires.");
        }


    } // end class
} // end namespace
