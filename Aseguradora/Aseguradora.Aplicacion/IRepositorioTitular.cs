namespace Aseguradora.Aplicacion;
public interface IRepositorioTitular
{
    void AgregarTitular(Titular titular);
    List<Titular> ListarTitulares();
    void ModificarTitular(Titular titular);
    void EliminarTitular(int id);
}