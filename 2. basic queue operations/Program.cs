namespace _2._basic_queue_operations
{
    internal class Program
    {
        static void Main(string[] args)
        {

            int[] parameters = Console.ReadLine().Split().Select(int.Parse).ToArray();
            int[] values = Console.ReadLine().Split().Select(int.Parse).ToArray();

            int pushElem = parameters[0];
            int popElem = parameters[1];
            int searchElem = parameters[2];

            var queue = new Queue<int>(values.Take(pushElem));

            while (popElem > 0 & queue.Count > 0)
            {
                queue.Dequeue();
                popElem--;
            }

            if (queue.Count == 0)
            { Console.WriteLine("0"); }

            else if (queue.Contains(searchElem)) { Console.WriteLine("true"); }
            else Console.WriteLine(queue.Min());
        }
    }
}