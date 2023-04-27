namespace Aseguradora.Aplicacion;
public class ListaVehiculoUseCase
{
    private readonly IRepositorioVehiculo _repo;
    public ListaVehiculoUseCase(IRepositorioVehiculo repo)
    {
        this._repo = repo;
    }

    public List<Vehiculo> Ejecutar()
    {
        return _repo.ListarVehiculos();
    }
}