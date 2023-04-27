namespace Aseguradora.Repositorios;
using Aseguradora.Aplicacion;
public class RepositorioPolizaTXT : IRepositorioPoliza

{
    readonly string _nombreArch = "poliza.txt"; //readonly solo lectura

    public void AgregarPoliza(Poliza poliza)
    {
        using var sw = new StreamWriter(_nombreArch, true);
        sw.WriteLine(poliza.Id);
        sw.WriteLine(poliza.VehiculoId);
        sw.WriteLine(poliza.valorAsegurado);
        sw.WriteLine(poliza.franquicia);
        sw.WriteLine(poliza.tipoC);
        sw.WriteLine(poliza.fechaInicio);
        sw.WriteLine(poliza.fechaFin);
    }

    public List<Poliza> ListarPolizas()
    {
        var ListarPolizas = new List<Poliza>();
        using var sr = new StreamReader(_nombreArch);
        while (!sr.EndOfStream)
        {
            var poliza = new Poliza();
            poliza.Id = int.Parse(sr.ReadLine() ?? "");
            poliza.valorAsegurado = int.Parse(sr.ReadLine() ?? "");
            poliza.franquicia = sr.ReadLine() ?? "";
            poliza.tipoC = Enum.Parse<Poliza.tipoCobertura>(sr.ReadLine() ?? ""); //Tipo enum preguntar
            poliza.fechaInicio = DateTime.Parse(sr.ReadLine() ?? ""); //Convertir tipo de fecha en string
            poliza.fechaFin = DateTime.Parse(sr.ReadLine() ?? ""); //Convertir tipo de fecha en string
        }
        return ListarPolizas;
    }

    public void ModificarPoliza(Poliza poliza)
    {
        using var sw = new StreamWriter(_nombreArch, true);
        using var sr = new StreamReader(_nombreArch);
        try
        {
            while (!sr.EndOfStream)
            {
                var dato = new Poliza();
                dato.Id = int.Parse(sr.ReadLine() ?? "");
                if (dato.Id == poliza.Id)
                {
                    sw.WriteLine(dato.valorAsegurado);
                    sw.WriteLine(dato.franquicia);
                    sw.WriteLine(dato.tipoC);
                    sw.WriteLine(dato.fechaInicio);
                    sw.WriteLine(dato.fechaFin);
                }

            }
        }
        catch
        {
            Console.WriteLine("El id no existe");
        }
    }

    public void EliminarPoliza(int id)
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