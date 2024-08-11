using Solid.LSP.Base;

namespace Solid.LSP
{
    public class Rectangulo : FiguraGeometrica
    {
        public override decimal CalcularArea ()
        {
            return Base * Altura;
        }
    }
}
