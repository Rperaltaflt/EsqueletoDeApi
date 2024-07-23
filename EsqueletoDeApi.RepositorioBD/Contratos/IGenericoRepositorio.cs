using System;
using System.Collections.Generic;
using System.Linq;
using System.Linq.Expressions;
using System.Text;
using System.Threading.Tasks;

namespace EsqueletoDeApi.RepositorioBD.Contratos
{
    public interface IGenericoRepositorio<unModelo> where unModelo : class //Un modelo va a ser una clase :class
    {
        //Esto va a retornar un Usuario, un Producto o lo que sea, colocando un filtro si se quiere o si no 
        //esto es como poner SELECT * FROM USUARIOS WHERE ROL = "ALGO"
        IQueryable<unModelo> Consultar(Expression<Func<unModelo, bool>>? filtro = null);
        Task<unModelo> Crear(unModelo modelo);
        Task<bool> Editar(unModelo modelo);
        Task<bool> Eliminar(unModelo modelo);
    }
}
