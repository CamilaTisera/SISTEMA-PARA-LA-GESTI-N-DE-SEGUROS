namespace Aseguradora.Repositorios;
public class RepositorioTitularTXT : IRepositorioTitular
{
    readonly string _nombreArch = "titulares.txt"; //readonly solo lectura

    public void AgregarTitular(Titular titular)
    {
        using var sw = new StreamWriter(_nombreArch, true);
        sw.WriteLine(titular.Id);
        sw.WriteLine(titular.nombre);
        sw.WriteLine(titular.apellido);
        sw.WriteLine(titular.direccion);
        sw.WriteLine(titular.correoElectronico);
        sw.WriteLine(titular.telefono);
    }

    public List<Titular> ListarTitulares(){
        var listaTitulares = new List<Titular>();
        using var sr = new StreamReader(_nombreArch);
        while(!sr.EndOfStream){
            var titular = new Titular();
            titular.Id = int.Parse(sr.ReadLine() ?? "");
            titular.nombre = sr.ReadLine() ?? "";
            titular.apellido = sr.ReadLine() ?? "";
            titular.direccion = sr.ReadLine() ?? "";
            titular.correoElectronico = sr.ReadLine() ?? "";
            titular.telefono = int.Parse(sr.ReadLine() ?? "");
        }
        return listaTitulares;
    }
}