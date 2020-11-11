using System;

namespace SpinningDiscs
{
    class Program
    {
        static void Main(string[] args)
        {
            // TODO: Declare and initialize a CD and a DVD object.
            CD myCD = new CD("My CD", 737);
            DVD myDVD = new DVD("My DVD", 4.7);
            // TODO: Call each CD and DVD method to verify that they work as expected.
            myCD.Spin();
            myDVD.Spin();
        }
    }
}
