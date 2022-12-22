namespace U2_Aggregate_
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //Console.WriteLine(Factorial(5));
            CountExample();
        }
        static long Factorial(int number)
        {
            List<int> list = new List<int>();
            for (int i = 1; i <= number; i++)
            {
                list.Add(i);
            }

            long result = list.Aggregate((x,y) => x*y);
            return result;
        }
        static void CountExample()
        {
            var contacts = new List<Contact>()
            {
                new Contact() { Name = "Андрей", Phone = 79994500508 },
                new Contact() { Name = "Сергей", Phone = 799990455 },
                new Contact() { Name = "Иван", Phone = 79999675334 },
                 new Contact() { Name = "Игорь", Phone = 8884994 },
                 new Contact() { Name = "Анна", Phone = 665565656 },
                 new Contact() { Name = "Василий", Phone = 3434 }
            };
            var result = contacts.Count(c => c.Phone.ToString().Length == 11 &&
            c.Phone.ToString().StartsWith('7'));
            Console.WriteLine(result);
        }
        class Contact
        {
            public string Name { get; set; }
            public long Phone { get; set; }
            
        }
    }
}