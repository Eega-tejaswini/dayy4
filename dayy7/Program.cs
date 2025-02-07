// See https://aka.ms/new-console-template for more information
//Console.WriteLine("Hello, World!");

internal class Program
{
 
   // public delegate void delsample(string msg); 
    public delegate void delsample2();
    private static void Main(string[] args)
    {
      //  Program obj = new Program();

     
       // delsample del = new delsample(obj.Display);

       // del("welcome");


        delsample2 del2 = new delsample2(Display);
        del2();

        Display();


    }
    //Instance Method
    void Display(string msg)
    {
        Console.WriteLine("Welcome to delegates" + msg);
    }
    //Static method
    static void Display()
    {
        Console.WriteLine("Hello");
    }
}
