using Api.Tareas.Dominio.Models;
using Api.Tareas.Dto.UsuariosDto;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Api.Tareas.Negocio
{
    public interface IUsuarioNegocio: IGenericoNegocio<UsuarioAdministracionEntrada,UsuarioAdministracionSalida>
    {
    }
}
