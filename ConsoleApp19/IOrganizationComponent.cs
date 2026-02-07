namespace CompositePattern
{
    public interface IOrganizationComponent
    {
        string Name { get; set;  }
        decimal GetSalary();
        void Display(int indent = 0);
    }
}