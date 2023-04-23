namespace Aseguradora.Aplicacion;
public class Siniestro
{
  /*Id, póliza (identificada mediante el Id de la póliza en la base de datos de la empresa), la fecha
de ingreso (tomada automáticamente por el sistema al momento de carga), fecha de ocurrencia, dirección
del hecho y descripción del accidente.*/
  public int Id {get; set;}
  public int PolizaId;
  public DateTime fechaIngreso {get; set;}
  public DateTime fechaOcurrencia {get; set;}
  public string? direccion {get; set;}
  public string? descripción {get; set;}

}