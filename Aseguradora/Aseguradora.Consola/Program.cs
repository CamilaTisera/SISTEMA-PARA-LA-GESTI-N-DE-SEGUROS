// See https://aka.ms/new-console-template for more information
using Aseguradora.Aplicacion;
using Aseguradora.Repositorios;

//creamos los casos de uso inyectando dependencias
RepositorioTitularTXT repoTitular = new RepositorioTitularTXT();
AgregarTitularUseCase agregarTitular = new AgregarTitularUseCase(repoTitular);
ListarTitularesUseCase listarTitulares = new ListarTitularesUseCase(repoTitular);
ModificarTitularUseCase modificarTitular = new ModificarTitularUseCase(repoTitular);
EliminarTitularUseCase eliminarTitular = new EliminarTitularUseCase(repoTitular);
//Instanciamos un titular
Titular titular = new Titular(33123456, "García", "Juan", 15406498)
{
    direccion = "13 nro. 546",
    correoElectronico = "joseGarcia@gmail.com"
};
Console.WriteLine($"Id del titular recién instanciado: {titular.Id}");
//agregamos el titular utilizando un método local
PersistirTitular(titular);
//el id que corresponde al titular es establecido por el repositorio
Console.WriteLine($"Id del titular una vez persistido: {titular.Id}");
//agregamos unos titulares más
PersistirTitular(new Titular(20654987, "Rodriguez", "Ana", 541524));
PersistirTitular(new Titular(31456444, "Alconada", "Fermín", 5415546));
PersistirTitular(new Titular(12345654, "Perez", "Cecilia", 514551));
//listamos los titulares utilizando un método local
ListarTitulares();
//no debe ser posible agregar un titular con igual DNI que uno existente
Console.WriteLine("Intentando agregar un titular con DNI 20654987");
titular = new Titular(20654987, "Alvarez", "Alvaro", 5641654);
//este titular no pudo persistirse
//Entonces vamos a modificar el titular existente
PersistirTitular(new Titular(33123456, "García", "Juan", 15406498));
Console.WriteLine("Modificando el titular con DNI 12345654");
modificarTitular.Ejecutar(titular);
ListarTitulares();
//Eliminando un titular
//métodos locales
void PersistirTitular(Titular t)
{
    try
    {
        agregarTitular.Ejecutar(t);
    }
    catch (Exception e)
    {
        Console.WriteLine(e.Message);
    }
}
void ListarTitulares()
{
    Console.WriteLine("Listando todos los titulares de vehículos");
    List<Titular> lista = listarTitulares.Ejecutar();
    foreach (Titular t in lista)
    {
        Console.WriteLine("nombre: " + t.nombre + " apellido: " + t.apellido + " dni: " + t.dni);
    }
}
