using System;
namespace SpinningDiscs
{
    public class CD : BaseDisc, IDisc
    {
        public CD(string name, int totalStorage, int usedStorage) : base(name, totalStorage, usedStorage)
        {
        }

        public void ReadData()
        {
            Console.WriteLine("CD was read.");
        }

        public void SpinDisc()
        {
            Console.WriteLine("CD is spinning");
        }
    }
}
