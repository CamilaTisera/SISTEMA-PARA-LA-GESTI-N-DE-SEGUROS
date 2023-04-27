namespace Aseguradora.Aplicacion;
public class ListaPolizaUseCase
{
    private readonly IRepositorioPoliza _repo;
    public ListaPolizaUseCase(IRepositorioPoliza repo)
    {
        this._repo = repo;
    }

    public List<Poliza> Ejecutar()
    {
        return _repo.ListarPolizas();
    }
}