namespace Aseguradora.Repositorios;
public class RepositorioPolizaTXT
{
    readonly string _nombreArch = "poliza.txt"; //readonly solo lectura

    public void AgregarTitular(Poliza poliza)
    {
        using var sw = new StreamWriter(_nombreArch, true);
        sw.WriteLine(poliza.Id);
        sw.WriteLine(poliza.VehiculoId);
        sw.WriteLine(poliza.valorAsegurado);
        sw.WriteLine(poliza.franquicia);
        sw.WriteLine(poliza.tipoCobertura);
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
            poliza.tipoCobertura = sr.ReadLine() ?? ""; //Tipo enum preguntar
            poliza.fechaInicio = sr.ReadLine() ?? ""; //Convertir tipo de fecha en string
            poliza.fechaFin = sr.ReadLine() ?? ""; //Convertir tipo de fecha en string
        }
        return ListarPolizas;
    }
}