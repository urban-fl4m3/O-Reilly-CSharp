using System;

namespace Chapter7_Program1
{
    class TallGuy
    {
        public string Name;
        public int Height;

        public void TalkAboutYourself()
        {
            Console.WriteLine($"My name is {Name} and I'm {Height} inches tall.");
        }
    }
}
