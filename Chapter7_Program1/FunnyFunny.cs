using System;

namespace Chapter7_Program1
{
    class FunnyFunny : IClown
    {
        public string FunnyThingIHave
        {
            get
            {
                return $"Привет, у меня есть {funnyThing}";
            }
        }

        protected string funnyThing;

        public FunnyFunny(string funnyThing)
        {
            this.funnyThing = funnyThing;
        }

        public void Honk()
        {
            Console.WriteLine(FunnyThingIHave);
        }
    }
}
