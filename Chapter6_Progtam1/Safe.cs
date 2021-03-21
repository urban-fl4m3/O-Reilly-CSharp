﻿using System;
using System.Collections.Generic;
using System.Text;

namespace Chapter6_Program1
{
    class Safe
    {
        private Jewels contents = new Jewels();
        private string safeCombination = "12345";

        public Jewels Open(string combination)
        {
            if (combination == safeCombination)
            {
                return contents;
            }
            else
            {
                return null;
            }
        }

        public void PickLock(Locksmith lockpicker)
        {
            lockpicker.WriteDownCombination(safeCombination);
        }
    }
}
