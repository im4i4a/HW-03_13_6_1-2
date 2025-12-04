using System.Diagnostics;

namespace HW_03_13_6_1_2
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string text = File.ReadAllText("C:\\Users\\admin\\Desktop\\input.txt");

            char[] delimiters = new char[] { ' ', '\r', '\n', '.', ',' };

            var words = text.Split(delimiters, StringSplitOptions.RemoveEmptyEntries);

            Stopwatch swList = Stopwatch.StartNew();

            List<string> list = new List<string>();
            foreach ( string word in words )
            {
                list.Add( word );
            }
            swList.Stop();
            Console.WriteLine("Итоговое время List: " + swList.Elapsed.TotalMilliseconds);

            Stopwatch swLinkedList = Stopwatch.StartNew();
            LinkedList<string> linkedList = new LinkedList<string>();
            foreach(string word in words)
            {
                linkedList.AddFirst( word );
            }
            swLinkedList.Stop();
            Console.WriteLine("Итоговое время LinkedList: " + swLinkedList.Elapsed.TotalMilliseconds);
        }
    }
}
