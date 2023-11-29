namespace _4._fastFood
{
    internal class Program
    {
        static void Main(string[] args)
        {
            var food = int.Parse(Console.ReadLine());
            
            var orders = Console.ReadLine().Split(" ").Select(int.Parse).ToArray();

            var queue = new Queue<int>(orders);

            Console.WriteLine(queue.Max());

            int actOrder = queue.Peek();
            while (food >= 0 && queue.Count() > 0)
            {
                if (actOrder > food )
                {
                    Console.WriteLine($"Orders left: {string.Join(", ", queue)}");
                    break;
                }

                else
                {
                    actOrder = queue.Dequeue();
                    food -= actOrder;
                }
            }
            if (queue.Count()==0) Console.WriteLine("Orders complete");
        }
    }
}