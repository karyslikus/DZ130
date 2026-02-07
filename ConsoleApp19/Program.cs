namespace CompositePattern
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("--- Расчет фонда заработной платы ---");
            Console.WriteLine("Создаем структуру компании...");
            var programmer1 = new Employee("Иван Петров", 150000);
            var programmer2 = new Employee("Алексей Сидоров", 170000);
            var manager1 = new Employee("Менеджер 1", 80000);
            var manager2 = new Employee("Менеджер 2", 100000);
            var manager3= new Employee("Менеджер 3", 200000);
            var developmentDepartment = new Department("Отдел Разработки");
            developmentDepartment.Add(programmer1);
            developmentDepartment.Add(programmer2);
            var salesDepartment = new Department("Отдел Продаж");
            salesDepartment.Add(manager1);
            salesDepartment.Add(manager2);
            var company = new Department("Компания");
            company.Add(developmentDepartment);
            company.Add(salesDepartment);
            company.Add(manager3);
            Console.WriteLine($"Зарплата программиста '{programmer1.Name}': {programmer1.GetSalary()}");
            Console.WriteLine($"Общий фонд зарплаты отдела '{developmentDepartment.Name}': {developmentDepartment.GetSalary()}");
            Console.WriteLine($"Общий фонд заработной платы всей компании: {company.GetSalary()}");
        }
    }
}