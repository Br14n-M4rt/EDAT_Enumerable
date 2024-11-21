namespace Enumerable.UI.Consola
{
    public class Alumnos
    {
        public int Matricula { get; init; }
        public string ?Nombre { get; init; }
        public decimal Precio { get; init; }

        public override string ToString()
        {
            return $"{Matricula}\t{Nombre}\t{Precio:C2}";
        }
    }
}
