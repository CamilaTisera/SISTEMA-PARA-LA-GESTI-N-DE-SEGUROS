namespace Aseguradora.Repositorios;
public class RepositorioVehiculoTXT {
    readonly string _nombreArch = "vehiculos.txt"; //readonly solo lectura

    public void AgregarTitular(Vehiculo vehiculo)
    {
        using var sw = new StreamWriter(_nombreArch, true);
        sw.WriteLine(vehiculo.Id);
        sw.WriteLine(vehiculo.TitularId);
        sw.WriteLine(vehiculo.marca);
        sw.WriteLine(vehiculo.dominio);
        sw.WriteLine(vehiculo.añoFabricacion);
    }

    public List<Vehiculo> ListarVehiculos(){
        var ListarVehiculos = new List<Vehiculo>();
        using var sr = new StreamReader(_nombreArch);
        while(!sr.EndOfStream){
            var vehiculo = new Vehiculo();
            vehiculo.Id = int.Parse(sr.ReadLine() ?? "");
            vehiculo.marca = sr.ReadLine() ?? "";
            vehiculo.dominio = sr.ReadLine() ?? "";
            vehiculo.direccion = sr.ReadLine() ?? "";
        }
        return ListarVehiculos;
    }

}