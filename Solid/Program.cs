using Solid.OCP;
using Solid.SRP.Interfaz;
using Solid.SRP.Models;
using Solid.SRP.Services;
public class Program
{
    
    public static void Main(string[] args)
    {
        //OCP
        TaxCalculator calculator = new TaxCalculator();

        decimal income = 100;
        decimal deduction = 20;
        string country = "India";


        decimal taxAmount = calculator.Calculate(income, deduction, country);
        

        

         Console.WriteLine($"El monto del impuesto para {country} es: {taxAmount}");


        //SRP
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