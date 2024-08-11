namespace Solid.LSP.Base
{
    public abstract class FiguraGeometrica
    {
        public virtual decimal Base { get; set; }
        public virtual decimal Altura { get; set; }

        public abstract decimal CalcularArea();
    }
}
