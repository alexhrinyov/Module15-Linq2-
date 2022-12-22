
namespace U1_Union_
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //UniqueSymbols();
            UniqueSymbols2();
        }

        static void UniqueSymbols()
        {
            string word1 = "Каракатица";
            string word2 = "Коромысло";
            IEnumerable<char> union = word1.Union(word2);
            foreach (var item in union)
            {
                Console.WriteLine(item);
            }
        }

        static void UniqueSymbols2()
        {
            Console.WriteLine("Введите строчку: ");
            string chars = Console.ReadLine();
            string uselessChars = " ,.;:?!";
            var uniqChars = chars.Distinct().Except(uselessChars).ToArray();
            Console.WriteLine(uniqChars);
            
        }
    }
}