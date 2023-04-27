namespace Aseguradora.Aplicacion;
public interface IRepositorioVehiculo
{
    void AgregarVehiculo(Vehiculo vehiculo);
    List<Vehiculo> ListarVehiculos();
    void ModificarVehiculo(Vehiculo vehiculo);
    void EliminarVehiculo(int id);
}