namespace _3task
{
    internal class Program
    {
        abstract class Worker
        {
            public string Name { get; set; }
            public abstract void Print();
        }

        class President : Worker
        { 
            public President(string name)
            {
                Name = name;
            }
            public President() { }
            public override void Print() 
            {
                if (Name != null)
                {
                    Console.WriteLine($"Presidents {Name} print");
                }
                else
                {
                    Console.WriteLine("President print");
                }
            }
        }
        class Security : Worker
        {
            public Security(string name)
            {
                Name = name;
            }
            public Security() { }
            public override void Print()
            {
                if (Name != null)
                {
                    Console.WriteLine($"Presidents {Name} print");
                }
                else
                {
                    Console.WriteLine("President print");
                }
            }
        }
        class Manager : Worker 
        {
            public Manager(string name)
            {
                Name = name;
            }
            public Manager() { }
            public override void Print()
            {
                if (Name != null)
                {
                    Console.WriteLine($"Presidents {Name} print");
                }
                else
                {
                    Console.WriteLine("President print");
                }
            }
        }
        class Engeneer : Worker 
        {
            public Engeneer(string name)
            {
                Name = name;
            }
            public Engeneer() { }
            public override void Print()
            {
                if (Name != null)
                {
                    Console.WriteLine($"Presidents {Name} print");
                }
                else
                {
                    Console.WriteLine("President print");
                }
            }
        }


        static void Main(string[] args)
        {
            Console.WriteLine("Hello, World!");
        }
    }
}
