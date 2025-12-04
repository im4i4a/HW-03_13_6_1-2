using System.Diagnostics;
using System.Linq;


namespace HW_03_13_6_1_2
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string text = File.ReadAllText("C:\\Users\\admin\\Desktop\\input.txt");

            char[] delimiters = new char[] { ' ', '\r', '\n' };
            var noPunctuationText = new string(text.Where(c => !char.IsPunctuation(c)).ToArray());
            var words = noPunctuationText.Split(delimiters, StringSplitOptions.RemoveEmptyEntries);

            #region 1_Задание
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
            #endregion

            #region 2_задание
            Dictionary<string,int> rateWords = new Dictionary<string,int>();
            foreach(string word in list)
            {
                if (rateWords.ContainsKey(word))
                {
                    rateWords[word]++;
                }else
                    rateWords[word] = 1;
            }
            List<KeyValuePair<string, int>> listCounterWord = rateWords.ToList();

            listCounterWord.Sort((a,b) => b.Value.CompareTo(a.Value));
            /*foreach (var word in listCounterWord)
            {
                Console.WriteLine($"Слово {word.Key} встречалось ровно {word.Value}" );
            }*/

            for(int i = 0; i < 10; i++)
            {
                Console.WriteLine((i + 1) + ": " + listCounterWord[i].Key + " - " + listCounterWord[i].Value);
            }

            #endregion

        }
    }
}
