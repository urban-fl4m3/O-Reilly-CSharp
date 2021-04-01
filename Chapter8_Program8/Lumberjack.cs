using System;
using System.Collections.Generic;

namespace Chapter8_Program8
{
    enum Flapjack
    {
        Crispy,
        Soggy,
        Browned,
        Banana
    }

    class Lumberjack
    {
        private string name;
        public string Name { get { return name; } }

        private Stack<Flapjack> meal;
    
        public Lumberjack(string name)
        {
            this.name = name;
            meal = new Stack<Flapjack>();
        }

        public int FlapjackCount { get { return meal.Count; } }
    
        public void TakeFlapjacks(Flapjack food, int howMany)
        {
            for (int i = 0; i < howMany; i++)
            {
                meal.Push(food);
            }
        }

        public void EatFlapjacks()
        {
            string message = $"{Name}'s eating flapjacks \r\n";

            while(FlapjackCount > 0)
            {
                Flapjack currentMeal = meal.Pop();
                message += $"{Name} ate a {currentMeal.ToString().ToLower()} flapjack\r\n";
            }

            Console.WriteLine(message);
        }
    }
}
