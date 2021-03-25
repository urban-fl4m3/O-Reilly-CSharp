using System;

namespace Chapter7_Program1
{
    class FunnyFunny : IClown
    {
        public string FunnyThingIHave => funnyThing;

        private string funnyThing;

        public FunnyFunny(string funnyThing)
        {
            this.funnyThing = funnyThing;
        }

        public void Honk()
        {
            Console.WriteLine($"Привет, у меня есть {FunnyThingIHave}");
        }
    }
}
