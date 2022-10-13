// See https://aka.ms/new-console-template for more information
using Console_Herentzia;

Console.WriteLine("Hello, World!");
try
{
    A objA = new A();
    objA.Prop1 = "pepe";
    objA.Prop2 = "20";
    objA.Erakutsi();
    B objB = new B();
    objB.Prop1 = "izaskun";
    //Prop2 8 baino luzeago bada Prop2 eta Prop3 imprimatu egingo dira.
    objB.Prop2 = "9999999999999";
    objB.Prop3 = "Kortabitarte";
    objB.Erakutsi();
    Console.ReadLine();
}
catch (Exception ex)
{
    Console.WriteLine(ex.Message);
    Console.ReadLine();
}
