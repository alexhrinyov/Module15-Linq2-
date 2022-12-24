namespace U5_ToArray_
{
    internal class Program
    {
        static void Main(string[] args)
        {
            List<int> ints = new List<int>();
            ints.Add(1);
            ints.Add(2);
            ints.Add(3);
            ints.Add(4);
            ints.Add(5);
            // ToArray делает выполнение linq запроса мнгновенным, а не отложенным
            var ints2 = ints.Where(i => i<3).OrderBy(i => i).ToArray();
            ints.Add(0);
            foreach (var item in ints2)
            {
                Console.WriteLine(item);
            }
        
        }
    }
}