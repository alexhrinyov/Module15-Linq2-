namespace U4_Join_
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //Task1();
            Task2();
        }

        static void Task1()
        {
            //Соедините данные и выведите на экран, кто работает в каком отделе.
            var departments = new List<Department>()
            {
             new Department() {Id = 1, Name = "Программирование"},
             new Department() {Id = 2, Name = "Продажи"}
            };
            var employees = new List<Employee>()
            {
                 new Employee() { DepartmentId = 1, Name = "Инна", Id = 1},
                  new Employee() { DepartmentId = 1, Name = "Андрей", Id = 2},
                  new Employee() { DepartmentId = 2, Name = "Виктор ", Id = 3},
                 new Employee() { DepartmentId = 3, Name = "Альберт ", Id = 4},
            };

            var result = departments.Join(employees, d => d.Id, e => e.DepartmentId, (d, e) =>
            new
            {
                DepartmentId = d.Id,
                Name = d.Name,
                Id = e.Id,
                employeeName = e.Name,
            });

            foreach (var item in result)
            {
                Console.WriteLine(item.employeeName + "," + item.Name + "," + item.Id);
            }
        }
        static void Task2()
        {
            //Теперь сгруппируйте сотрудников по отделам, выведя на экран
            //последовательно сначала название отдела, а затем список его сотрудников:
            var departments = new List<Department>()
            {
             new Department() {Id = 1, Name = "Программирование"},
             new Department() {Id = 2, Name = "Продажи"}
            };
            var employees = new List<Employee>()
            {
                 new Employee() { DepartmentId = 1, Name = "Инна", Id = 1},
                  new Employee() { DepartmentId = 1, Name = "Андрей", Id = 2},
                  new Employee() { DepartmentId = 2, Name = "Виктор ", Id = 3},
                 new Employee() { DepartmentId = 3, Name = "Альберт ", Id = 4},
            };

            var result = departments.GroupJoin(employees, d => d.Id, e => e.DepartmentId, (d, e) =>
            new
            {
                DepName = d.Name,
                gEmployees = e.Select(e => e.Name),
            }
            );
            foreach (var dep in result)
            {
                Console.WriteLine(dep.DepName);
                foreach (var emp in dep.gEmployees)
                {
                    Console.WriteLine(emp);
                }
            }
        }

    }

    internal class Employee
    {
       
        public int DepartmentId { get; set; }
        public string Name { get; set; }
        public int Id { get; set; }
    }

    internal class Department
    {
        public int Id { get; set; }
        public string Name { get; set; }
    }
}