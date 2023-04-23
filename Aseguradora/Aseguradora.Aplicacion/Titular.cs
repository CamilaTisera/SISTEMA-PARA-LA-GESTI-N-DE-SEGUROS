namespace Aseguradora.Aplicacion;
class Titular : Persona
{
    //Id, DNI, apellido, nombre, dirección, teléfono y correo electrónico.
    public int Id { get; set; }
    public string? direccion { get; set; }
    public string? correoElectronico { get; set; }
    public List<Vehiculo> listaVehiculo= new List<Vehiculo>(); //Un titular puede tener mas de una vehiculo

    public Titular(int dni, string? apellido, string? nombre, int telefono) : 
    base(dni, apellido, nombre, telefono)
    {
    }

}