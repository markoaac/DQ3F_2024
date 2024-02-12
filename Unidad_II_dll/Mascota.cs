namespace Unidad_II_dll
{
    public class Mascota
    {
        public string? Tipo { get; set; }
        public string? Nombre { get; set; }

        public override string ToString()
        {
            return "Nombre: " + Nombre;
        }
        
    }
}
