using Solid.SRP.Interfaz;
using Solid.SRP.Models;

namespace Solid.SRP.Services
{
    public class ImprimirServices:IImprimirServices
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
