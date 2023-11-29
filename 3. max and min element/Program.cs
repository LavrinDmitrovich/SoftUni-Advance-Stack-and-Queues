namespace _3._max_and_min_element
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int num = int.Parse(Console.ReadLine());
            var stack = new Stack<int>();

            for (int i = 0; i < num; i++) 
            { 
            
                var comm = Console.ReadLine().Split(" ").Select(int.Parse).ToArray();
                int first = comm[0];

                if (first == 1)  stack.Push(comm[1]); 
                else if (first == 2) stack.Pop();
                else if (first == 3 && stack.Count > 0) Console.WriteLine(stack.Max());
                else if (first == 4 && stack.Count > 0) Console.WriteLine(stack.Min());


            }

            Console.WriteLine(string.Join(", ", stack));

        }
    }
}