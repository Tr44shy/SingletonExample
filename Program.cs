using System;

namespace ConsoleApp2
{
    class Program
    {
        static void Main(string[] args)
        {
            Class1 obj1 = Class1.Instance();
            Class1 obj2 = Class1.Instance();

            obj1.SetValue("Pedro");
            //el valor seteado en el obj1 es invocable desde el obj2 porque comparten una misma instancia
            Console.WriteLine(obj2.GetValue());

        }
    }
}
