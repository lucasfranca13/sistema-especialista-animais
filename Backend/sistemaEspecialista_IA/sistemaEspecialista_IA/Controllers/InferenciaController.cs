using Microsoft.AspNetCore.Mvc;
using sistemaEspecialista_IA.Services;

namespace sistemaEspecialista_IA.Controllers
{
    [ApiController]
    [Route("api/[controller]")]
    public class InferenciaController : ControllerBase
    {
        private readonly MotorDeInferencia _motor;

        
        public InferenciaController(MotorDeInferencia motor)
        {
            _motor = motor;
        }

        // Endpoint: POST /api/inferencia/executar
        [HttpPost("executar")]
        public async Task<IActionResult> ExecutarInferencia([FromBody] List<string> fatosIniciais)
        {
            if (fatosIniciais == null || !fatosIniciais.Any())
            {
                return BadRequest("Nenhum fato foi enviado para análise.");
            }

            
            var resultado = await _motor.ExecutarInferenciaAsync(fatosIniciais);

            return Ok(resultado);
        }
    }
}
