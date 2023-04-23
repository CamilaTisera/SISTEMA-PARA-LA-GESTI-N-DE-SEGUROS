namespace Aseguradora.Aplicacion;
public class Vehiculo
{
  //Id, dominio, marca, año de fabricación y 
  //titular (identificado por el id del titular en la base de datos de la empresa)
  public int Id {get; set;}
  public int TitularId;
  public string? marca {get; set;}
  public string? dominio {get; set;} //Patente
  public int añoFabricacion {get; set;}
}