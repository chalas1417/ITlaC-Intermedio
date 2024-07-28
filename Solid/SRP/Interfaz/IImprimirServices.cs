
using Solid.SRP.Models;
using System.Security.Cryptography.X509Certificates;

namespace Solid.SRP.Interfaz
{
    public interface IImprimirServices
    {
        
            public void ImprimirDatos(Persona persona)
            {
           
                Console.WriteLine($"Nombre: {persona.Nombre}");
                Console.WriteLine($"Edad: {persona.Edad}");
                Console.WriteLine($"Direccion: {persona.Direccion}");
                Console.WriteLine($"CorreoElectronico: {persona.CorreoElecronico}");
            }
        
    }
}
