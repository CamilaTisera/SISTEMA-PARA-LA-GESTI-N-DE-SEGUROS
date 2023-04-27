namespace Aseguradora.Aplicacion;
public class AgregarVehiculoUseCase
{
    private readonly IRepositorioVehiculo _repo;
    public AgregarVehiculoUseCase(IRepositorioVehiculo repo)
    {
        this._repo = repo;
    }

    public void Ejecutar(Vehiculo vehiculo)
    {
        _repo.AgregarVehiculo(vehiculo);
    }
}