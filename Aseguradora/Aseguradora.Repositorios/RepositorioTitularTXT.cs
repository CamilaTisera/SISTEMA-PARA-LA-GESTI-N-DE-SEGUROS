namespace Aseguradora.Repositorios;
using Aseguradora.Aplicacion;
public class RepositorioTitularTXT : IRepositorioTitular
{
    readonly string _nombreArch = "titulares.txt"; //readonly solo lectura
    static int idIncremental;

    public void AgregarTitular(Titular titular)
    {
        using var sw = new StreamWriter(_nombreArch, true);
        RepositorioTitularTXT.idIncremental++;
        titular.Id = idIncremental;
        sw.WriteLine(titular.dni);
        sw.WriteLine(titular.apellido);
        sw.WriteLine(titular.nombre);
        sw.WriteLine(titular.telefono);
        sw.WriteLine(titular.Id);
        sw.WriteLine(titular.direccion);
        sw.WriteLine(titular.correoElectronico);
    }

    public List<Titular> ListarTitulares()
    {
        var listaTitulares = new List<Titular>();
        using var sr = new StreamReader(_nombreArch);

        while (!sr.EndOfStream)
        {
            var titular = new Titular();
            titular.dni = int.Parse(sr.ReadLine() ?? "");
            titular.apellido = sr.ReadLine() ?? "";
            titular.nombre = sr.ReadLine() ?? "";
            titular.telefono = int.Parse(sr.ReadLine() ?? "");
            titular.Id = int.Parse(sr.ReadLine() ?? "");
            titular.direccion = sr.ReadLine() ?? "";
            titular.correoElectronico = sr.ReadLine() ?? "";
            listaTitulares.Add(titular);
        }
        return listaTitulares;
    }

    public void ModificarTitular(Titular titular)
    {
        using var sw = new StreamWriter(_nombreArch, true);
        using var sr = new StreamReader(_nombreArch);
        try
        {
            while (!sr.EndOfStream)
            {
                var dato = new Titular();
                dato.dni = int.Parse(sr.ReadLine() ?? "");

                if (dato.dni == titular.dni)
                {
                    sw.WriteLine(dato.apellido);
                    sw.WriteLine(dato.nombre);
                    sw.WriteLine(dato.telefono);
                    sw.WriteLine(dato.direccion);
                    sw.WriteLine(dato.correoElectronico);
                }

            }
        }
        catch
        {
            Console.WriteLine("El dni no existe");
        }
    }

        public void EliminarTitular(int id)
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