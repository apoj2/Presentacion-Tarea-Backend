using Api.Pruebas.Comun;
using Api.Tareas.Dto.NotasDto;
using Api.Tareas.Negocio;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace Api.Tareas.Servicio.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class NotaController : ControllerBase
    {
        private readonly INotaNegocio _negocio;
        public NotaController(INotaNegocio negocio)
        {
            _negocio = negocio;
        }
        [HttpPost]
        public async Task<Retorno<NotaAdministracionSalida?>> CreateAsync(NotaAdministracionEntrada entidad)
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
        public async Task<Retorno<List<NotaAdministracionSalida>?>> GetAllAsync()
        {
            var resultado = await _negocio.GetAllAsync();

            return resultado;
        }
        [HttpGet("{id}")]
        public async Task<Retorno<NotaAdministracionSalida?>> GetByIdAsync(Guid id)
        {
            var resultado = await _negocio.GetByIdAsync(id);

            return resultado;
        }
        [HttpPut("{id}")]
        public async Task<Retorno<NotaAdministracionSalida?>> ActualizarAsync(Guid id, NotaAdministracionEntrada entidad)
        {

            var resultado = await _negocio.ActualizarAsync(id, entidad);

            return resultado;
        }
    }
}
