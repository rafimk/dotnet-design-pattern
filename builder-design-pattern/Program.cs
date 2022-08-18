// Client Code
using builder_design_pattern.Beverages;
using builder_design_pattern.Reports;

Report report;
ReportDirector reportDirector = new ReportDirector();
// Construct and display Reports
PDFReport pdfReport = new PDFReport();
report = reportDirector.MakeReport(pdfReport);
report.DisplayReport();
Console.WriteLine("-------------------");
ExcelReport excelReport = new ExcelReport();
report = reportDirector.MakeReport(excelReport);
report.DisplayReport();

Beverage beverage;
BeverageDirector beverageDirector = new BeverageDirector();

TeaBuider tea = new TeaBuider();
beverage = beverageDirector.MakeBeverage(tea);
Console.WriteLine(beverage.ShowBeverage());
CoffeeBuilder coffee = new CoffeeBuilder();
beverage = beverageDirector.MakeBeverage(coffee);
Console.WriteLine(beverage.ShowBeverage());

Console.ReadKey();