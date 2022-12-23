namespace U3_Grouping_
{
    internal class Program
    {
        static void Main(string[] args)
        {
            var phoneBook = new List<Contact>();

            // добавляем контакты
            phoneBook.Add(new Contact("Игорь", 79990000001, "igor@example.com"));
            phoneBook.Add(new Contact("Сергей", 79990000010, "serge@example.com"));
            phoneBook.Add(new Contact("Анатолий", 79990000011, "anatoly@example.com"));
            phoneBook.Add(new Contact("Валерий", 79990000012, "valera@example.com"));
            phoneBook.Add(new Contact("Сергей", 799900000013, "serg@gmail.com"));
            phoneBook.Add(new Contact("Иннокентий", 799900000013, "innokentii@example.com"));

            //с помощью фильтрации
            Console.WriteLine("Filtration: ");
            Console.WriteLine("Real Contacts: ");
            var realGroup = phoneBook.Where(c => !c.Email.Contains("example"));
            foreach (var item in realGroup)
            {
                Console.WriteLine(item.Name);
            }
            Console.WriteLine("Fake Contacts: ");
            var fakeGroup = phoneBook.Where(c => c.Email.Contains("example"));
            foreach (var item in fakeGroup)
            {
                Console.WriteLine(item.Name);
            }

            //с помощью группировки и метода расширения bool
            
            Console.WriteLine();
            Console.WriteLine("GroupBy: ");
            var Groups = phoneBook.GroupBy(c => c.Email.Contains("example")).Select(gr => 
            new {Name = gr.Key.Definition(), Contacts = gr.Select(c => c) });
            foreach (var group in Groups)
            {
                Console.WriteLine(group.Name);
                foreach (var item in group.Contacts)
                {
                    Console.WriteLine(item.Name + ", " + item.Email);
                }
            }

        }
    }
    // расширение, которое преобразует true в Fake, а false в Real, для имени группы
    public static class BoolExtension
    {
        public static string Definition(this bool parameter)
        {
            if (parameter == true)
                return  "Fake: ";
            else
                return  "Real: ";
            

        }
    }

    public class Contact
    {
        public Contact(string name, long phone, string email)
        {
            Name = name;
            Phone = phone;
            Email = email;
        }
        public string Name { get; set; }
        public string Email { get; set; }

        public long Phone { get; set; }

    }
}