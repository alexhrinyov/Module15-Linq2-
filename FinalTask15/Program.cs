namespace FinalTask15
{
    //Напишите метод, который соберет всех учеников всех классов в один список, используя LINQ.
    class Program
    {
        static void Main(string[] args)
        {
            var classes = new[]
            {
               new Classroom { Students = {"Evgeniy", "Sergey", "Andrew"}, },
               new Classroom { Students = {"Anna", "Viktor", "Vladimir"}, },
               new Classroom { Students = {"Bulat", "Alex", "Galina"}, }
           };
            var allStudents = GetAllStudents(classes);

            Console.WriteLine(string.Join(" ", allStudents));
        }

        static string[] GetAllStudents(Classroom[] classes)
        {
            string[]? students = classes.SelectMany(st => st.Students).ToArray();
            return students;
        }

        public class Classroom
        {
            public List<string> Students = new List<string>();
        }
    }
}