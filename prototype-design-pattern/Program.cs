
using prototype_design_pattern.Employees;

Employee emp1 = new Employee();
emp1.Name = "Anurag";
emp1.Department = "IT";
Employee emp2 = emp1.GetClone();
emp2.Name = "Pranaya";

Console.WriteLine("Emplpyee 1: ");
Console.WriteLine("Name: " + emp1.Name + ", Department: " + emp1.Department);
Console.WriteLine("Emplpyee 2: ");
Console.WriteLine("Name: " + emp2.Name + ", Department: " + emp2.Department);
Console.Read();