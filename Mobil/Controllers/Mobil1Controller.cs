using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using Mobil1.Data;
using Mobil1.Models;
using System.Collections.Generic;
using System.Threading.Tasks;

namespace Mobil1.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class Mobil1Controller : ControllerBase
    {
        private readonly Mobil1DbContext _context;

        public Mobil1Controller(Mobil1DbContext context)
        {
            _context = context;
        }

        [HttpGet]
        public async Task<ActionResult<IEnumerable<Fatura>>> GetFaturalar()
        {
            var faturalar = await _context.Faturalar
                .Include(f => f.Fatura_Bilgi) 
                .ToListAsync();

            return Ok(faturalar);
        }


        [HttpGet("{id}")]
        public async Task<ActionResult<Fatura>> GetFatura(int id)
        {
            var fatura = await _context.Faturalar.FindAsync(id);

            if (fatura == null)
            {
                return NotFound();
            }

            return fatura;
        }
    }
}
