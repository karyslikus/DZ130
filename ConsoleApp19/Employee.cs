namespace CompositePattern
{
    public class Employee : IOrganizationComponent{
        private decimal _salary;
        public string Name { get; set; }

        public Employee(string name, decimal salary)
        {
            Name = name;
            _salary = salary;
        }
        public decimal GetSalary()
        {
            return _salary;
        }
        public void Display(int indent = 0)
        {
            
        }
    }
}