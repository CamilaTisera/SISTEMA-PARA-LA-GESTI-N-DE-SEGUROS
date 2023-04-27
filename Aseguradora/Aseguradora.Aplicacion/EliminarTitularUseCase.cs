namespace Aseguradora.Aplicacion;

public class EliminarTitularUseCase
{
    private readonly IRepositorioTitular _repo;
    public EliminarTitularUseCase(IRepositorioTitular repo)
    {
        this._repo = repo;
    }

    public void Ejecutar(int id)
    {
        _repo.EliminarTitular(id);
    }
}