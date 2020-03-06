using System;

namespace CSharpDesignPatterns
{
    class Program
    {
        static void Main(string[] args)
        {
            SingletonDemo();
            //BuilderDemo();
            //AbstractFactoryDemo();
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
