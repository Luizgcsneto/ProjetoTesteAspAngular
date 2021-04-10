using System.Collections.Generic;
using System.Threading.Tasks;
using BackEnd.Model;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;

namespace BackEnd.Controllers
{
    [ApiController]
    [Route("api/[controller]")]
    public class ProgramadoresController : ControllerBase
    {
        private readonly Context _context;

        public ProgramadoresController( Context context)
        {
            _context = context;
        }

        [HttpGet]
        public async Task<ActionResult<IEnumerable<Programador>>> PegarTodosAsync()
        {
            return await _context.Programadores.ToListAsync();
        }

        [HttpGet("{id}")]
        public async Task<ActionResult<Programador>> PegarPeloIdAsync(int id)
        {
           Programador programador = await _context.Programadores.FindAsync(id);
           if(programador == null)
                 NotFound();

            return programador;
        }


     [HttpPost]
        public async Task<ActionResult<Programador>> SalvarProgramadorAsync(Programador programador)
        {
            await _context.Programadores.AddAsync(programador);
            await _context.SaveChangesAsync();

            return Ok();
        }

        [HttpPut]
        public async Task<ActionResult> AtualizarProgramadorAsync(Programador programador)
        {
            _context.Programadores.Update(programador);
            await _context.SaveChangesAsync();

            return Ok();
        }

        [HttpDelete("{Id}")]
        public async Task<ActionResult> DeletarProgramadorAsync(int Id)
        {
            Programador programador = await _context.Programadores.FindAsync(Id);
            if (programador == null)
                return NotFound();
            _context.Remove(programador);
            await _context.SaveChangesAsync();
            return Ok();
        }

    }
}