using System;

namespace NullObjectPattern
{
    class Program
    {
        private const int SomeDamage = 50;

        static void Main(string[] args)
        {
            Player player = new Player("Luke");
            player.TakeArmor(new HeavyArmor());

            Player player2 = new Player("Tom");

            player2.TakeDamage(SomeDamage);
            player.TakeDamage(SomeDamage);

            Console.WriteLine(player.ToString());
            Console.WriteLine(player2.ToString());
        }
    }
}
