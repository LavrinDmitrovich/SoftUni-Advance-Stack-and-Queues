using System.Text;

namespace _6.SongsQueue
{
    internal class Program
    {
        static void Main(string[] args)
        {
            var songs = Console.ReadLine().Split(", ").ToArray();
               
            var songsQueue = new Queue<string>(songs);

                       
            while (songsQueue.Count > 0) 
            {
                var orders = Console.ReadLine().Split(" ").ToArray();
               
                var cmd = orders[0];
                
                
                switch (cmd) 
                {
                    case "Play": { songsQueue.Dequeue(); break; }

                    case "Add": {
                            StringBuilder cmdSong = new StringBuilder();

                            for (int i = 1; i < orders.Length; i++)
                            {
                                cmdSong.Append(orders[i]+" ");
                            }

                            cmdSong.Remove(cmdSong.Length - 1, 1);
                            string newSong = cmdSong.ToString();

                            
                            if (songsQueue.Contains(newSong)) { Console.WriteLine($"{newSong} is already contained!"); break; }
                            else songsQueue.Enqueue(newSong);
                            break; }

                    case "Show": { Console.WriteLine(string.Join(", ", songsQueue)); break; }    
                }
            }
            Console.WriteLine("No more songs!");

        }
    }
}