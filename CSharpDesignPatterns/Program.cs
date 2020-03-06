using System;
using System.Collections.Generic;

namespace CSharpDesignPatterns
{
    class Program
    {
        static void Main(string[] args)
        {
            FacadeDemo();
           // DecoratorDemo();
            //AdapterDemo();
            //SingletonDemo();
            //BuilderDemo();
            //AbstractFactoryDemo();
        }

        static void FacadeDemo()
        {
            BikeFacade facade = new BikeFacade();
            facade.PrepareForSale(new Downhill(new WideWheel(20), BikeColor.Red));
        }

        static void DecoratorDemo()
        {
            IBicycle tourBike = new Touring(new NarrowWheel(23));
            Console.WriteLine(tourBike);

            tourBike = new GoldFrame(tourBike);
            Console.WriteLine(tourBike);

            tourBike = new CustomGrip(tourBike);
            Console.WriteLine(tourBike);
        }

        static void AdapterDemo()
        {
            IList<IWheel> wheels = new List<IWheel>();
            wheels.Add(new NarrowWheel(24));
            wheels.Add(new NarrowWheel(20));
            wheels.Add(new WideWheel(24));

            UltraWheel ultraWheel = new UltraWheel(22);
            wheels.Add(new UltraWheelAdapter(ultraWheel));

            foreach (IWheel item in wheels)
            {
                Console.WriteLine(item);
            }
        }

        static void SingletonDemo()
        {
            SerialNumberGenerator generator = SerialNumberGenerator.Instance;

            Console.WriteLine("next serial: {0}", generator.NextSerial());
            Console.WriteLine("next serial: {0}", generator.NextOtherSerial);
            Console.WriteLine("next serial: {0}", generator.NextSerial());
            Console.WriteLine("next serial: {0}", generator.NextOtherSerial);
        }

        static void BuilderDemo()
        {
            AbstractMountainBike mountainBike = new Downhill(new WideWheel(24), BikeColor.Red);
            BikeBuilder builder = new MountainBikeBuilder(mountainBike);
            BikeDirector director = new MountainBikeDirector();
            IBicycle bicycle = director.Build(builder);
            Console.WriteLine(bicycle);
        }

        static void AbstractFactoryDemo()
        {
            AbstractBikeFactory factory = new RoadBikeFactory();

            // create the bike parts
            IBikeFrame bikeFrame = factory.CreateBikeFrame();
            IBikeSeat bikeSeat = factory.CreateBikeSeat();
            // Show what we created
            Console.WriteLine(bikeFrame.BikeFrameParts);
            Console.WriteLine(bikeSeat.BikeSeatParts);
        }
    }
}
