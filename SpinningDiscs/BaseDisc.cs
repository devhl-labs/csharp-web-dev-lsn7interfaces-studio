using System;
using System.Collections.Generic;
using System.Text;

namespace SpinningDiscs
{
    public abstract class BaseDisc
    {
        public string Name { get; set; }

        public int TotalStorage { get; set; }

        public int UsedStorage { get; set; }

        public List<string> Contents { get; set; } = new List<string>();


        public BaseDisc(string name, int totalStorage, int usedStorage)
        {
            if (totalStorage < usedStorage)
                throw new ArgumentException("Used storage must be less than or equal to the total storage.");

            Name = name;

            TotalStorage = totalStorage;

            UsedStorage = usedStorage;
        }
        
        public int RemainingStorage() => TotalStorage - UsedStorage;

        public string Info()
            => $"Name: {Name}\nTotal Storage: {TotalStorage}\nSpace Used: {UsedStorage}\nRemaining Storage: {RemainingStorage()}";

        public string WriteData(int size)
        {
            if (size > RemainingStorage())
                throw new ArgumentException("Not enough space left on this disc.");

            UsedStorage += size;
            
            return "Data written to disc. Remaining space = " + RemainingStorage();
        }
    }
}
