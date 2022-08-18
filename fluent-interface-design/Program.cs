using fluent_interface_design.Employees;

FluentEmployee obj = new FluentEmployee();
obj.NameOfTheEmployee("Anurag Mohanty")
        .Born("10/10/1992")
        .WorkingOn("IT")
        .StaysAt("Mumbai-India");

Console.Read();