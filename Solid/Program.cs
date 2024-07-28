using Solid.SRP.Interfaz;
using Solid.SRP.Models;
using Solid.SRP.Services;
public class Program
{
    public static string nombre { get; private set; }
    public static int edad { get; private set; }
    public static string direccion { get; private set; }
    public static string correo { get; private set; }

    private static void Main(string[] args)
    {
        Persona persona = new Persona();
        Console.WriteLine("Ditite el Nombre");
        Console.ReadLine();
        Console.WriteLine("Ditite la Edad");
        Console.ReadLine();
        Console.WriteLine("Ditite la Direcion");
        Console.ReadLine();
        Console.WriteLine("Ditite el Correo");
        Console.ReadLine();



        ICorreoElectronicoServices correoElectronicoServices = new CorreoElectronicoServices();

        IImprimirServices imprimirServices = new ImprimirServices();

         correoElectronicoServices.EnviarCorreo("Hola, este es el correo");
        imprimirServices.ImprimirDatos(persona);


    }
}   