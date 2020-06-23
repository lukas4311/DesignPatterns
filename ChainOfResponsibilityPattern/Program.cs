using System;

namespace ChainOfResponsibilityPattern
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Chain of responsibility!");

            var monkey = new MonkeyHandler();
            var snake = new SnakeHandler();
            var dog = new DogHandler();

            monkey.SetNext(snake).SetNext(dog);

            Console.WriteLine("Chain: Monkey > Snake > Dog\n");
            Client.ClientCode(monkey);
            Console.WriteLine();

            Console.WriteLine("Subchain: Snake > Dog\n");
            Client.ClientCode(snake);
        }
    }
}
