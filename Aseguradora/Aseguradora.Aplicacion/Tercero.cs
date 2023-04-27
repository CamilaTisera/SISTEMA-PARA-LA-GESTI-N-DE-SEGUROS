namespace Aseguradora.Aplicacion;
public class Tercero : Persona
{
    /*Id, DNI, apellido, nombre, teléfono, nombre de su aseguradora y siniestro en el que participó
  (identificado por medio del Id del siniestro en la base de datos de la empresa).*/
    public int Id { get; set; }
    public int SiniestroId;
    public string? nombreAseguradora { get; set; }
    public Tercero(int dni, string? apellido, string? nombre, int telefono) :
    base(dni, apellido, nombre, telefono)
    {
    }

    public Tercero()
    {
      this.Id++;
    }


}