using System;

namespace Chapter7_Program1
{
    class ScaryScary : FunnyFunny, IScaryClown
    {
        public string ScaryThingIHave => $"У меня {numberOfScaryThings} пауков";

        private int numberOfScaryThings;

        public ScaryScary(string funnyThing, int numberOfScaryThings) : base(funnyThing)
        {
            this.numberOfScaryThings = numberOfScaryThings;
        }

        public void ScareLittleChicken()
        {
            Console.WriteLine($"Ты не можешь забрать {funnyThing}");
        }
    }
}
