using System;
namespace SpinningDiscs
{
    public class DVD : BaseDisc, IDisc
    {
        public DVD(string name, int totalStorage, int usedStorage) : base(name, totalStorage, usedStorage)
        {                
        }

        public void ReadData()
        {
            Console.WriteLine("DVD was read.");
        }

        public void SpinDisc()
        {
            Console.WriteLine("DVD is spinning.");
        }
    }
}
