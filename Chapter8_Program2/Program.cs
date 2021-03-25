using System;
using System.Collections.Generic;

namespace Chapter8_Program2
{
    static class Program
    {
        static void Main()
        {
            List<Shoe> shoeCloset = new List<Shoe>();

            shoeCloset.Add(new Shoe()
            { Style = Style.Sneakers, Color = "Чёрный" });
            shoeCloset.Add(new Shoe()
            { Style = Style.Clogs, Color = "Коричневый" });
            shoeCloset.Add(new Shoe()
            { Style = Style.Wingtips, Color = "Чёрный" });
            shoeCloset.Add(new Shoe()
            { Style = Style.Loafers, Color = "Белый" });
            shoeCloset.Add(new Shoe()
            { Style = Style.Loafers, Color = "Красный" });
            shoeCloset.Add(new Shoe()
            { Style = Style.Sneakers, Color = "Зелёный" });

            int numberOfShoes = shoeCloset.Count;

            foreach (Shoe shoe in shoeCloset)
            {
                shoe.Style = Style.Flipflops;
                shoe.Color = "Оранжевый";
            }

            shoeCloset.RemoveAt(4);

            Shoe thirdShoe = shoeCloset[3];
            Shoe secondShoe = shoeCloset[2];
            shoeCloset.Clear();

            shoeCloset.Add(thirdShoe);

            if (shoeCloset.Contains(secondShoe))
            {
                Console.WriteLine("Удвитиельно!");
            }

            Console.ReadKey();
        }
    }
}
