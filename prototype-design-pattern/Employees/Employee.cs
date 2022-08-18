namespace prototype_design_pattern.Employees
{
    public class Employee
    {
        public string Name { get; set; }
        public string Department { get; set; }
        public Employee GetClone()
        {
            return (Employee)this.MemberwiseClone();
        }
    }
}