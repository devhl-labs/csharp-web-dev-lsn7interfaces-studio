using System;
using System.Linq;

namespace SpinningDiscs
{
    class Program
    {
        static void Main(string[] args)
        {
            if (args.Count() > 0 )
                Console.WriteLine(args);

            CD cd = new CD("Lamb of God", 500, 300);
            DVD dvd = new DVD("Cloverfield", 1500, 1400);

            cd.SpinDisc();
            dvd.SpinDisc();

            cd.ReadData();
            dvd.ReadData();

            Console.WriteLine(cd.WriteData(200));
            Console.WriteLine(dvd.WriteData(100));

            Console.WriteLine(cd.Info());
            Console.WriteLine(dvd.Info());

            //should throw because the disc is full
            //Console.WriteLine(cd.WriteData(1));
        }
    }
}
