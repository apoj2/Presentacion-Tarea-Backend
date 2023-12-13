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
    public class UsuarioNegocio : IUsuarioNegocio
    {
        private readonly IUsuarioRepositorio _repositorio;
        public UsuarioNegocio(IUsuarioRepositorio repositorio)
        {
            _repositorio = repositorio;
        }

        public async Task<Retorno<UsuarioAdministracionSalida?>> CreateAsync(UsuarioAdministracionEntrada entidad)
        {
            Usuario resultado = Mapping.GetMapper(entidad);
            if (resultado != null)
            {
                await _repositorio.CreateAsync(resultado);
                return new Retorno<UsuarioAdministracionSalida> { Estado = true, Mensaje = new List<string> { "Consulta Exitosa" }, Informacion = null, TipoRetorno = GeneralEnum.TipoRetorno.OK };
            }
            else
            {
                return new Retorno<UsuarioAdministracionSalida> { Estado = false, Mensaje = new List<string> { "Haz realizado mal la peticion. ", "Consulta No exitosa" }, Informacion = null, TipoRetorno = GeneralEnum.TipoRetorno.NOK };
            }
        }
        public async Task<Retorno<bool>> EliminarAsync(Guid id)
        {
            Usuario resultado = await _repositorio.GetByIdAsync(id);
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

        public async Task<Retorno<List<UsuarioAdministracionSalida>?>> GetAllAsync()
        {
            List<Usuario> resultado = await _repositorio.GetAllAsync();


            if (resultado != null)
            {
                List<UsuarioAdministracionSalida> resultadoSalida = Mapping.GetMapper(resultado);
                return new Retorno<List<UsuarioAdministracionSalida>> { Estado = true, Mensaje = new List<string> { "Consulta Exitosa" }, Informacion = resultadoSalida, TipoRetorno = GeneralEnum.TipoRetorno.OK };
            }
            else
            {
                return new Retorno<List<UsuarioAdministracionSalida>> { Estado = false, Mensaje = new List<string> { "Haz realizado mal la peticion. ", "Consulta No exitosa" }, Informacion = null, TipoRetorno = GeneralEnum.TipoRetorno.NOK };
            }
        }

        public async Task<Retorno<UsuarioAdministracionSalida?>> GetByIdAsync(Guid id)
        {
            Usuario resultado = await _repositorio.GetByIdAsync(id);

            if (resultado != null)
            {
                UsuarioAdministracionSalida resultadoSalida = Mapping.GetMapper(resultado);

                return new Retorno<UsuarioAdministracionSalida> { Estado = true, Mensaje = new List<string> { "Consulta Exitosa" }, Informacion = resultadoSalida, TipoRetorno = GeneralEnum.TipoRetorno.OK };
            }
            else
            {
                return new Retorno<UsuarioAdministracionSalida> { Estado = false, Mensaje = new List<string> { "Haz realizado mal la peticion. ", "Consulta No exitosa" }, Informacion = null, TipoRetorno = GeneralEnum.TipoRetorno.NOK };
            }
        }

        public async Task<Retorno<UsuarioAdministracionSalida?>> ActualizarAsync(Guid id, UsuarioAdministracionEntrada entidad)
        {
            Usuario resultado = await _repositorio.GetByIdAsync(id);
            if (resultado != null)
            {
                Usuario resultadoSalida = Mapping.GetMapper(entidad);
                await _repositorio.ActualizarAsync(id, resultadoSalida);
                return new Retorno<UsuarioAdministracionSalida> { Estado = true, Mensaje = new List<string> { "Consulta Exitosa" }, Informacion = null, TipoRetorno = GeneralEnum.TipoRetorno.OK };
            }
            else
            {
                return new Retorno<UsuarioAdministracionSalida> { Estado = false, Mensaje = new List<string> { "Haz realizado mal la peticion. ", "Consulta No exitosa" }, Informacion = null, TipoRetorno = GeneralEnum.TipoRetorno.NOK };
            }
        }
    }
}
