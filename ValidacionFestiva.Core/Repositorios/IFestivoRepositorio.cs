
using ValidacionFestiva.Dominio.Entidades;

public interface IFestivoRepositorio
{
    Task<IEnumerable<Festivo>> ObtenerTodos();

    Task<Festivo> Obtener(int Id);

    Task<Festivo> Agregar(Festivo festivo);

    Task<Festivo> Modificar(Festivo festivo);

    Task<bool> Eliminar(int Id);

    Task<IEnumerable<Festivo>> Buscar(int Tipo, string Dato);

   
    Task<IEnumerable<Festivo>> ObtenerPorMes(int mes);
    Task<bool> EsFestivo(DateTime fecha);
}

