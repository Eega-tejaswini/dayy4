// See https://aka.ms/new-console-template for more information
//Console.WriteLine("Hello, World!");
using System.Reflection;
internal class Program
{
    private static void Main(string[] args)
    {
        Type T = Type.GetType("ReflectionConcpt.Studentt");
        Console.WriteLine(T.Name);
        Console.WriteLine(T.FullName);




        MethodInfo[] mthds = T.GetMethods();
        Console.WriteLine(mthds.GetType);
        Console.WriteLine(mthds.GetType().FullName);

        foreach (MethodInfo method in mthds)
        {
            Console.WriteLine(method.ReturnType.Name + " " + method.Name);
        }




    }
}