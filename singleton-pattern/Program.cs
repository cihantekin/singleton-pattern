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

Thread process3 = new(() =>
{
    TestSingleton("Process3");
});

process1.Start();
process2.Start();
process3.Start();
process1.Join();
process2.Join();
process3.Join();

static void TestSingleton(string value)
{
    Singleton singleton = Singleton.GetInstance(value);
    Console.Write(singleton.Value);
}