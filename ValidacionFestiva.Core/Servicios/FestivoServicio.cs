using ValidacionFestiva.Core.Repositorios;
using ValidacionFestiva.Dominio.Entidades;

namespace ValidacionFestiva.Servicio.Servicios
{
    public interface IFestivoServicio
    {
        Task<IEnumerable<Festivo>> ObtenerTodos();
        Task<Festivo> Obtener(int Id);
        Task<Festivo> Agregar(Festivo festivo);
        Task<Festivo> Modificar(Festivo festivo);
        Task<bool> Eliminar(int Id);
        Task<IEnumerable<Festivo>> Buscar(int Tipo, string Dato);

       
        Task<bool> ValidarFecha(int dia, int mes, int anio);
    }

    public class FestivoServicio : IFestivoServicio
    {
        private readonly IFestivoRepositorio festivoRepositorio;

        public FestivoServicio(IFestivoRepositorio festivoRepositorio)
        {
            this.festivoRepositorio = festivoRepositorio;
        }

        #region CRUD

        public Task<IEnumerable<Festivo>> ObtenerTodos()
        {
            return festivoRepositorio.ObtenerTodos();
        }

        public Task<Festivo> Obtener(int Id)
        {
            return festivoRepositorio.Obtener(Id);
        }

        public Task<Festivo> Agregar(Festivo festivo)
        {
            return festivoRepositorio.Agregar(festivo);
        }

        public Task<Festivo> Modificar(Festivo festivo)
        {
            return festivoRepositorio.Modificar(festivo);
        }

        public Task<bool> Eliminar(int Id)
        {
            return festivoRepositorio.Eliminar(Id);
        }

        public Task<IEnumerable<Festivo>> Buscar(int Tipo, string Dato)
        {
            return festivoRepositorio.Buscar(Tipo, Dato);
        }

        #endregion

        #region Validación

        public async Task<bool> ValidarFecha(int dia, int mes, int anio)
        {
            var festivos = await festivoRepositorio.ObtenerTodos();
            return festivos.Any(f => f.Dia == dia && f.Mes == mes);
        }

        #endregion
    }
}
