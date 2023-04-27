namespace Aseguradora.Aplicacion;
public interface IRepositorioPoliza
{
    void AgregarPoliza(Poliza poliza);
    List<Poliza> ListarPolizas();
    void ModificarPoliza(Poliza poliza);
    void EliminarPoliza(int id);
}