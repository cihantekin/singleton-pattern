// See https://aka.ms/new-console-template for more information
using singleton_pattern;

Console.WriteLine("Hello, World!");


Thread process1 = new(() =>
{
    TestSingleton("Process1");
});

Thread process2 = new(() =>
{
    TestSingleton("Process2");
});

process1.Start();
process2.Start();
process1.Join();
process2.Join();

static void TestSingleton(string value)
{
    Singleton singleton = Singleton.GetInstance(value);
    Console.Write(singleton.Value);
}