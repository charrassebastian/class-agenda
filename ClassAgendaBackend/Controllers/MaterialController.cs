using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using ClassAgendaBackend.Models;

namespace ClassAgendaBackend.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class MaterialController : ControllerBase
    {
        private readonly ClassAgendaDbContext _context;

        public MaterialController(ClassAgendaDbContext context)
        {
            _context = context;
        }

        // GET: api/Material
        [HttpGet]
        public async Task<ActionResult<IEnumerable<MaterialModel>>> GetMaterialModel()
        {
            return await _context.MaterialModel.ToListAsync();
        }

        // GET: api/Material/5
        [HttpGet("{id}")]
        public async Task<ActionResult<MaterialModel>> GetMaterialModel(Guid id)
        {
            var materialModel = await _context.MaterialModel.FindAsync(id);

            if (materialModel == null)
            {
                return NotFound();
            }

            return materialModel;
        }

        // PUT: api/Material/5
        // To protect from overposting attacks, see https://go.microsoft.com/fwlink/?linkid=2123754
        [HttpPut("{id}")]
        public async Task<IActionResult> PutMaterialModel(Guid id, MaterialModel materialModel)
        {
            if (id != materialModel.Id)
            {
                return BadRequest();
            }

            _context.Entry(materialModel).State = EntityState.Modified;

            try
            {
                await _context.SaveChangesAsync();
            }
            catch (DbUpdateConcurrencyException)
            {
                if (!MaterialModelExists(id))
                {
                    return NotFound();
                }
                else
                {
                    throw;
                }
            }

            return NoContent();
        }

        // POST: api/Material
        // To protect from overposting attacks, see https://go.microsoft.com/fwlink/?linkid=2123754
        [HttpPost]
        public async Task<ActionResult<MaterialModel>> PostMaterialModel(MaterialModel materialModel)
        {
            _context.MaterialModel.Add(materialModel);
            await _context.SaveChangesAsync();

            return CreatedAtAction("GetMaterialModel", new { id = materialModel.Id }, materialModel);
        }

        // DELETE: api/Material/5
        [HttpDelete("{id}")]
        public async Task<IActionResult> DeleteMaterialModel(Guid id)
        {
            var materialModel = await _context.MaterialModel.FindAsync(id);
            if (materialModel == null)
            {
                return NotFound();
            }

            _context.MaterialModel.Remove(materialModel);
            await _context.SaveChangesAsync();

            return NoContent();
        }

        private bool MaterialModelExists(Guid id)
        {
            return _context.MaterialModel.Any(e => e.Id == id);
        }
    }
}
