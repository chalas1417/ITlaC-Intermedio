using Solid.DIP.Models;
using Solid.DIP.Services;
using Solid.ISP.Refactory;
using Solid.ISP.Refactory.Interfaz;
using Solid.LSP;
using Solid.LSP.Base;
using Solid.OCP;
using Solid.SRP.Interfaz;
using Solid.SRP.Models;
using Solid.SRP.Services;

namespace Solid
{
    public class Program
    {

        public static void Main(string[] args)
        {



            //Practica DIP
            CustomerServices services = new CustomerServices();
            Customer customer = new Customer();

            Console.WriteLine($"Customer ID: 22{customer.Id}, Name:Leidy {customer.Name}");



            //LSP

            FiguraGeometrica rectangulo1 = new Solid.LSP.Rectangulo { Base = 4, Altura = 5 };
            FiguraGeometrica cuadrado1 = new Cuadrado { Base = 4, Altura = 5 }; // Violación del LSP

            Console.WriteLine($"Área del rectángulo: {rectangulo1.CalcularArea()}");
            Console.WriteLine($"Área del cuadrado: {cuadrado1.CalcularArea()}"); // Esto falla al no ser un cuadrado.




            Rectangulo rectangulo = new Rectangulo();
            rectangulo.CalcularArea();

            //ISP
            Iave2 pato = new Pato2();
            pato.Cantar();
            pato.PonerHuevos();
            ((IAveNadora)pato).AvaNadora();

            Iave2 alcon = new Alcon2();
            alcon.Cantar();
            alcon.PonerHuevos();
            ((IAveCazadora)alcon).AveCzadora();

            Iave2 gaviota = new Gaviota2();
            gaviota.PonerHuevos();
            



            //OCP
            TaxCalculator calculator = new TaxCalculator();

            decimal income = 100;
            decimal deduction = 20;
            string country = "India";


            decimal taxAmount = calculator.Calculate(income, deduction, country);
            
            Console.WriteLine($"El monto del impuesto para {country} es: {taxAmount}");




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
}