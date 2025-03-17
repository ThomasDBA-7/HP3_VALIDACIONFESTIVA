using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using ValidacionFestiva.Dominio.Entidades;

namespace ValidacionFestiva.Core.Repositorios
{
    public interface ITipoFestivoRepositorio
    {
        Task<IEnumerable<TipoFestivo>> ObtenerTodos();

        Task<TipoFestivo> Obtener(int Id);

        Task<TipoFestivo> Agregar(TipoFestivo tipoFestivo);

        Task<TipoFestivo> Modificar(TipoFestivo tipoFestivo);

        Task<bool> Eliminar(int Id);

     
        Task<TipoFestivo> ObtenerPorDescripcion(string descripcion);
    }
}
