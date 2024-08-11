
using Solid.LSP.Base;

namespace Solid.LSP
{
    public class Cuadrado : FiguraGeometrica
    {
        public override decimal CalcularArea()
        {
            // violación del LSP.
            return Base * Altura;
        }
        public override decimal Base
        {
            get => base.Base;
            set
            {
                base.Base = value;
                base.Altura = value;
            }
        }

        public override decimal Altura
        {
            get => base.Altura;
            set
            {
                base.Altura = value;
                base.Base = value;
            }
        }

       
}
    }