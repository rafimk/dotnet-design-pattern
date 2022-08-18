
using singleton_design_pattern;

Singleton fromTeachaer = Singleton.GetInstance;
fromTeachaer.PrintDetails("From Teacher");
Singleton fromStudent = Singleton.GetInstance;
fromStudent.PrintDetails("From Student");
Console.ReadLine();