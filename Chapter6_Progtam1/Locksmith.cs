﻿using System;
using System.Collections.Generic;
using System.Text;

namespace Chapter6_Program1
{
    class Locksmith
    {
        public void OpenSafe(Safe safe, Owner owner)
        {
            safe.PickLock(this);
            Jewels safeContents = safe.Open(writtenDownCombination);
            ReturnContents(safeContents, owner);
        }

        private string writtenDownCombination = null;

        public void WriteDownCombination(string combination)
        {
            writtenDownCombination = combination;
        }

        public virtual void ReturnContents(Jewels safeContents, Owner owner)
        {
            owner.ReceiveContents(safeContents);
        }
    }
}
