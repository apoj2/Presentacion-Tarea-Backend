using Api.Tareas.Dominio.Models;
using Api.Tareas.Dto.NotasDto;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Api.Tareas.Negocio
{
    public interface INotaNegocio: IGenericoNegocio<NotaAdministracionEntrada,NotaAdministracionSalida>
    {
    }
}
