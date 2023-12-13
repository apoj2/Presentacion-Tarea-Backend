using Api.Pruebas.Comun;
using Api.Tareas.Dto.NotasDto;
using Api.Tareas.Dto.UsuariosDto;
using Api.Tareas.Negocio;
using Microsoft.AspNetCore.Mvc;

namespace Api.Tareas.Servicio.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class UsuarioController : ControllerBase
    {
        private readonly IUsuarioNegocio _negocio;
        public UsuarioController(IUsuarioNegocio negocio)
        {
            _negocio = negocio;
        }
        [HttpPost]
        public async Task<Retorno<UsuarioAdministracionSalida?>> CreateAsync(UsuarioAdministracionEntrada entidad)
        {
            var resultado = await _negocio.CreateAsync(entidad);

            return resultado;

        }
        [HttpDelete("{id}")]
        public async Task<Retorno<bool>> EliminarAsync(Guid id)
        {
            var resultado = await _negocio.EliminarAsync(id);

            return resultado;
        }
        [HttpGet]
        public async Task<Retorno<List<UsuarioAdministracionSalida>?>> GetAllAsync()
        {
            var resultado = await _negocio.GetAllAsync();

            return resultado;
        }
        [HttpGet("{id}")]
        public async Task<Retorno<UsuarioAdministracionSalida?>> GetByIdAsync(Guid id)
        {
            var resultado = await _negocio.GetByIdAsync(id);

            return resultado;
        }
        [HttpPut("{id}")]
        public async Task<Retorno<UsuarioAdministracionSalida?>> ActualizarAsync(Guid id, UsuarioAdministracionEntrada entidad)
        {

            var resultado = await _negocio.ActualizarAsync(id, entidad);

            return resultado;
        }
    }
}
