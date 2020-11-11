using System;
namespace SpinningDiscs
{
    public class CD : BaseDisc, IOpticalDisc
    {
        public CD(string name, double storageCapacity, bool audio = true, bool video = false) : base(name, storageCapacity, audio, video)
        {
            Console.WriteLine("Type: " + name);
            Console.WriteLine("Storage Capacity: " + storageCapacity);
            Console.WriteLine("Audio: " + audio);
            Console.WriteLine("Video: " + video);
        }
        // TODO: Implement your custom interface.
        
        public void Spin()
        {
            Console.WriteLine("A CD spins at a rate of 200 - 500 rpm.);
        }

        public void StoreData()
        {
            Console.WriteLine("A CD stores 737 MB of data.");
        }
        // TODO: Determine which fields, methods, and constructors can be extended from the base class and which ones
        //  need to be declared separately. 

    }
}
