namespace Aseguradora.Repositorios;
using Aseguradora.Aplicacion;
public class RepositorioVehiculoTXT : IRepositorioVehiculo
{
    readonly string _nombreArch = "vehiculos.txt"; //readonly solo lectura

    public void AgregarVehiculo(Vehiculo vehiculo)
    {
        using var sw = new StreamWriter(_nombreArch, true);
        sw.WriteLine(vehiculo.Id);
        sw.WriteLine(vehiculo.TitularId);
        sw.WriteLine(vehiculo.marca);
        sw.WriteLine(vehiculo.dominio);
        sw.WriteLine(vehiculo.añoFabricacion);
    }

    public List<Vehiculo> ListarVehiculos()
    {
        var ListarVehiculos = new List<Vehiculo>();
        using var sr = new StreamReader(_nombreArch);
        while (!sr.EndOfStream)
        {
            var vehiculo = new Vehiculo();
            vehiculo.Id = int.Parse(sr.ReadLine() ?? "");
            vehiculo.marca = sr.ReadLine() ?? "";
            vehiculo.dominio = sr.ReadLine() ?? "";
            vehiculo.TitularId = int.Parse(sr.ReadLine() ?? "");
            vehiculo.añoFabricacion = int.Parse(sr.ReadLine() ?? "");
        }
        return ListarVehiculos;
    }

    public void ModificarVehiculo(Vehiculo vehiculo)
    {
        using var sw = new StreamWriter(_nombreArch, true);
        using var sr = new StreamReader(_nombreArch);
        try
        {
            while (!sr.EndOfStream)
            {
                var dato = new Vehiculo();
                dato.Id = int.Parse(sr.ReadLine() ?? "");
                if (dato.Id == vehiculo.Id)
                {
                    sw.WriteLine(dato.marca);
                    sw.WriteLine(dato.dominio);
                    sw.WriteLine(dato.añoFabricacion);
                }

            }
        }
        catch
        {
            Console.WriteLine("El id no existe");
        }
    }

        public void EliminarVehiculo(int id)
    {
        try
        {
            
        }
        catch
        {
            Console.WriteLine("El id no existe");
        }
    }
}
