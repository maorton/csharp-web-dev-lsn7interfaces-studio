using System;
namespace SpinningDiscs
{
    public class DVD : BaseDisc, IOpticalDisc
    {
        public DVD(string name, double storageCapacity, bool audio = true, bool video = true) : base(name, storageCapacity, audio, video)
        {
            Console.WriteLine("Type: " + name);
            Console.WriteLine("Storage Capacity: " + storageCapacity);
            Console.WriteLine("Audio: " + audio);
            Console.WriteLine("Video: " + video);
        }

        // TODO: Implement your custom interface.
        public void Spin()
        {
            Console.WriteLine("A DVD spins at a rate of 570 - 1600 rpm.");
        }

        public void StoreData()
        {
            Console.WriteLine("A DVD stores  4.7 GB of data.");
        }
        // TODO: Determine which fields, methods, and constructors can be extended from the base class and which ones
        //  need to be declared separately.
    }
}
