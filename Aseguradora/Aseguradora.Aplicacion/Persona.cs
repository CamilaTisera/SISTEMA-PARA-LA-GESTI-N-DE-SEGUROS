namespace Aseguradora.Aplicacion; //Consultar
public abstract class Persona
{
    public int dni { get; set; }
    public string? apellido { get; set; }
    public string? nombre { get; set; }
    public int telefono {get; set;}

    public Persona(int dni, string? apellido, string? nombre, int telefono)
    {
        this.dni = dni;
        this.apellido = apellido;
        this.nombre = nombre;
        this.telefono = telefono;
    }
        public Persona()
    {
    }
}