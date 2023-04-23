namespace Aseguradora.Aplicacion;
public interface IRepositorioTitular
{
    void AgregarTitular(Titular titular);
    List<Titular> ListarTitulares();
}