using System;

namespace Chapter7_Program1
{
    class ScaryScary : FunnyFunny, IScaryClown
    {
        public string ScaryThingIHave => $"{numberOfScaryThings} пауков";

        private int numberOfScaryThings;

        public ScaryScary(string funnyThing, int numberOfScaryThings) : base(funnyThing)
        {
            this.numberOfScaryThings = numberOfScaryThings;
        }

        public void ScareLittleChicken()
        {
            Console.WriteLine("Ага! Попался!");
        }
    }
}
