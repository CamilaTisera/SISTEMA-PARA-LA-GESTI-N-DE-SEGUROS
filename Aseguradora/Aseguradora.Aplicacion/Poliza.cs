namespace Aseguradora.Aplicacion;
public class Poliza
{
    /*Id, vehículo asegurado (identificado mediante el Id del vehículo en la base de datos de la empresa),
  valor asegurado, franquicia, tipo de cobertura (Responsabilidad Civil o Todo Riesgo), fecha de inicio de
  vigencia y fecha de fin de vigencia.*/

    public int VehiculoId;
    public int Id { get; set; }
    public int valorAsegurado { get; set; }
    public string? franquicia { get; set; }
    public tipoCobertura tipoC;
    public DateTime fechaInicio;
    public DateTime fechaFin;

    public enum tipoCobertura
    {
        ResponsabilidadCivil, TodoRiesgo
    }

    public Poliza()
    {
        this.Id++;
    }
}