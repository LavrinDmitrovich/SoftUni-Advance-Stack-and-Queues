namespace _8._Balanced_parantheses
{
    internal class Program
    {
        static void Main(string[] args)
        {
            var list = Console.ReadLine();

            
            Stack<char> listStack1 = new Stack<char>(list);
            Stack<char> listStack2 = new Stack<char>();

            bool stat = true;

            for (int i = 0; i <listStack1.Count; i++) 
            {
                listStack2.Push(listStack1.Pop());
            }
            
            for (int i = 0; i < ((listStack1.Count) / 2) + 1; i++)
            {
                if (listStack1.Pop() != listStack2.Pop()) { stat = false; break; }
            }

            if (stat == false ) Console.WriteLine("NO");
           else  Console.WriteLine("Yes");
                

        }
    }
}