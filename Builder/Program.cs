// See https://aka.ms/new-console-template for more information
using Builder;

Console.WriteLine("Hello, World!");
var test = new ExternalEmployee();
test.SetName("asdasd");

Console.WriteLine(test.BuildEmployee().FullName);

Console.ReadLine();