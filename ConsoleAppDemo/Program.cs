using ClassLibraryDemo;

namespace ConsoleAppDemo
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Hello, World!");
            ClassDemo cd = new ClassDemo();

            Console.WriteLine("Напиши первую цифорку йоу: ");
            int a = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Напиши вторую цифорку йоу: ");
            int b = Convert.ToInt32(Console.ReadLine());

            int resultSum = cd.Sum(a, b);
            int resultMinus = ClassDemo.Minus(a, b);


            Console.WriteLine("A + B = " + resultSum);
            Console.WriteLine(a + " - " + b + " = " + resultMinus);

            Console.ReadLine();
        }
    }
}
