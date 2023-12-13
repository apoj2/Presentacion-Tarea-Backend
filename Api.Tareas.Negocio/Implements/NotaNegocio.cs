using Api.Pruebas.Comun;
using Api.Pruebas.Comun.Enums;
using Api.Tareas.Dominio.Models;
using Api.Tareas.Dto.NotasDto;
using Api.Tareas.Dto.UsuariosDto;
using Api.Tareas.Repositorio;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Api.Tareas.Negocio.Implements
{
    public class NotaNegocio : INotaNegocio
    {
        private readonly INotaRepositorio _repositorio;
        public NotaNegocio(INotaRepositorio repositorio)
        {
            _repositorio = repositorio;
        }

        public async Task<Retorno<NotaAdministracionSalida?>> CreateAsync(NotaAdministracionEntrada entidad)
        {
            Nota resultado = Mapping.GetMapper(entidad);
            if (resultado != null)
            {
                await _repositorio.CreateAsync(resultado);
                return new Retorno<NotaAdministracionSalida> { Estado = true, Mensaje = new List<string> { "Consulta Exitosa" }, Informacion = null, TipoRetorno = GeneralEnum.TipoRetorno.OK };
            }
            else
            {
                return new Retorno<NotaAdministracionSalida> { Estado = false, Mensaje = new List<string> { "Haz realizado mal la peticion. ", "Consulta No exitosa" }, Informacion = null, TipoRetorno = GeneralEnum.TipoRetorno.NOK };
            }
        }
        public async Task<Retorno<bool>> EliminarAsync(Guid id)
        {
            Nota resultado = await _repositorio.GetByIdAsync(id);
            if (resultado != null)
            {
                await _repositorio.EliminarAsync(id);
                return new Retorno<bool> { Estado = true, Mensaje = new List<string> { "Consulta Exitosa" }, Informacion = true, TipoRetorno = GeneralEnum.TipoRetorno.OK };
            }
            else
            {
                return new Retorno<bool> { Estado = false, Mensaje = new List<string> { "Haz realizado mal la peticion. ", "Consulta No exitosa" }, Informacion = false, TipoRetorno = GeneralEnum.TipoRetorno.NOK };
            }
        }

        public async Task<Retorno<List<NotaAdministracionSalida>?>> GetAllAsync()
        {
            List<Nota> resultado = await _repositorio.GetAllAsync();


            if (resultado != null)
            {
                List<NotaAdministracionSalida> resultadoSalida = Mapping.GetMapper(resultado);
                return new Retorno<List<NotaAdministracionSalida>> { Estado = true, Mensaje = new List<string> { "Consulta Exitosa" }, Informacion = resultadoSalida, TipoRetorno = GeneralEnum.TipoRetorno.OK };
            }
            else
            {
                return new Retorno<List<NotaAdministracionSalida>> { Estado = false, Mensaje = new List<string> { "Haz realizado mal la peticion. ", "Consulta No exitosa" }, Informacion = null, TipoRetorno = GeneralEnum.TipoRetorno.NOK };
            }
        }

        public async Task<Retorno<NotaAdministracionSalida?>> GetByIdAsync(Guid id)
        {
            Nota resultado = await _repositorio.GetByIdAsync(id);

            if (resultado != null)
            {
                NotaAdministracionSalida resultadoSalida = Mapping.GetMapper(resultado);

                return new Retorno<NotaAdministracionSalida> { Estado = true, Mensaje = new List<string> { "Consulta Exitosa" }, Informacion = resultadoSalida, TipoRetorno = GeneralEnum.TipoRetorno.OK };
            }
            else
            {
                return new Retorno<NotaAdministracionSalida> { Estado = false, Mensaje = new List<string> { "Haz realizado mal la peticion. ", "Consulta No exitosa" }, Informacion = null, TipoRetorno = GeneralEnum.TipoRetorno.NOK };
            }
        }

        public async Task<Retorno<NotaAdministracionSalida?>> ActualizarAsync(Guid id, NotaAdministracionEntrada entidad)
        {
            Nota resultado = await _repositorio.GetByIdAsync(id);
            if (resultado != null)
            {
                Nota resultadoSalida = Mapping.GetMapper(entidad);
                await _repositorio.ActualizarAsync(id, resultadoSalida);
                return new Retorno<NotaAdministracionSalida> { Estado = true, Mensaje = new List<string> { "Consulta Exitosa" }, Informacion = null, TipoRetorno = GeneralEnum.TipoRetorno.OK };
            }
            else
            {
                return new Retorno<NotaAdministracionSalida> { Estado = false, Mensaje = new List<string> { "Haz realizado mal la peticion. ", "Consulta No exitosa" }, Informacion = null, TipoRetorno = GeneralEnum.TipoRetorno.NOK };
            }
        }
    }
}
