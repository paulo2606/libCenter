using libCenter.src.Data;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace libCenter.src.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class AuthController : ControllerBase
    {
        private readonly AppDbContext _context;

        public AuthController(AppDbContext context)
        {
            _context = context;
        }

        [HttpGet("testConection")]
        public async Task<IActionResult> TestConnection()
        {
            try
            {
                await _context.Database.CanConnectAsync();
                return Ok("Conexão bem sucedida!");
            }
            catch(Exception ex)
            {
                return BadRequest($"Não foi possível conectar: {ex.Message}");
            }
        }
    }
}
