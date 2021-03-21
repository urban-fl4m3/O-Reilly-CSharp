using System;
using System.Collections.Generic;
using System.Text;

namespace Chapter6_Program1
{
    class JewelThief : Locksmith
    {
        private Jewels stolenContents = null;

        public override void ReturnContents(Jewels safeContents, Owner owner)
        {
            stolenContents = safeContents;
            Console.WriteLine($"I'm stealing the contents: {stolenContents.Sparkle()}");
        }
    }
}
