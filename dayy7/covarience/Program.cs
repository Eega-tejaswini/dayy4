// See https://aka.ms/new-console-template for more information
//Console.WriteLine("Hello, World!");



// See https://aka.ms/new-console-template for more information
using Covarience;


delegate Vehicle delveh();
delegate void delcontra(Bike bike);
internal class Program
{
    private static void Main(string[] args)
    {
       

        Vehicle vhl = new Vehicle();
        delveh delv = new delveh(vhl.CreateVehicle);

        Bike br = new Bike();

        delv = new delveh(br.CreateBike);

        //contravariance
        delcontra delcont = new delcontra(vhl.Display);
        delcont.Invoke(br);

        delcont += br.DisplayBike;

    }
}

