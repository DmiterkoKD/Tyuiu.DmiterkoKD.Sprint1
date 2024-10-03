using tyuiu.cources.programming.interfaces.Sprint1;
namespace Tyuiu.DmiterkoKD.Sprint1.Task6.V4.Lib
{
    public class DataService : ISprint1Task6V4
    {
        public string CheckDoubleN(string value)
        {

            string[] words = value.Split(' ');

            var wordsWithNn = new List<string>();

            foreach (var word in words)
            {
                if (word.Count(c => c == 'н') == 2)
                {
                    wordsWithNn.Add(word);
                }
            }


            string result = String.Join(" ", wordsWithNn);

            return result;
        }
    }
}
