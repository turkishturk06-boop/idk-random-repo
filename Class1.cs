using System;

class Program
{
    static int hp = 30;

    static void game()
    {
        Console.WriteLine("a guy comed nearby what you do ?(hit/quit)");
        string ilkcevap = Console.ReadLine().ToLower();

        if (ilkcevap == "hit")
        {
            hp -= 30;
            Console.WriteLine("you killed the guy");
        }
        else if (ilkcevap == "quit")
        {
            Console.WriteLine("you quited");
        }
        else
        {
            Console.WriteLine("invalid pls try again");
        }
    }

    static void game()
    {
        game();
    }
}
