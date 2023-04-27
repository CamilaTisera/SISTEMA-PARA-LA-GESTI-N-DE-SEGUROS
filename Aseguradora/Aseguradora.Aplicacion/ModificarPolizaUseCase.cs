namespace Aseguradora.Aplicacion;

public class ModificarPolizaUseCase
{
    /*Clase ModificarPolizaUseCase con el método void Ejecutar(Poliza p) que actualiza los datos de
p en el repositorio de pólizas. La póliza se identifica por su Id. En caso de no existir ningúna póliza
con ese Id se debe lanzar una excepción.*/
    private readonly IRepositorioPoliza _repo;
    public ModificarPolizaUseCase(IRepositorioPoliza repo)
    {
        this._repo = repo;
    }

    public void Ejecutar(Poliza poliza)
    {
         _repo.ModificarPoliza(poliza);
    }
}