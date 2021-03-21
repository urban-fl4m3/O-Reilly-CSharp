using System;
using System.Collections.Generic;
using System.Text;

namespace Chapter6_Program1
{
    class Owner
    {
        private Jewels returnedContents;

        public void ReceiveContents(Jewels safeContents)
        {
            returnedContents = safeContents;
            Console.WriteLine($"Thank you for returnin my jewels! {safeContents.Sparkle()}");
        }
    }
}
