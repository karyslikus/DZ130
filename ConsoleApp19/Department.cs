
namespace CompositePattern
{
    public class Department : IOrganizationComponent
    {
        private List<IOrganizationComponent> _components = new List<IOrganizationComponent>();

        public string Name { get; set; }

        public Department(string name)
        {
            Name = name;
        }

        public void Add(IOrganizationComponent component)
        {
            _components.Add(component);
        }
        public decimal GetSalary()
        {
            decimal total = 0;
            foreach (var component in _components)
            {
                total += component.GetSalary();
            }
            return total;
        }
        public void Display(int indent = 0)
        {
        }
    }
}