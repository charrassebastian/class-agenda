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
    public class ClassController : ControllerBase
    {
        private readonly CourseAgendaDbContext _context;

        public ClassController(CourseAgendaDbContext context)
        {
            _context = context;
        }

        // GET: api/Class
        [HttpGet]
        public async Task<ActionResult<IEnumerable<ClassModel>>> GetClassModel()
        {
            return await _context.ClassModel.ToListAsync();
        }

        // GET: api/Class/5
        [HttpGet("{id}")]
        public async Task<ActionResult<ClassModel>> GetClassModel(Guid id)
        {
            var classModel = await _context.ClassModel.FindAsync(id);

            if (classModel == null)
            {
                return NotFound();
            }

            return classModel;
        }

        // PUT: api/Class/5
        // To protect from overposting attacks, see https://go.microsoft.com/fwlink/?linkid=2123754
        [HttpPut("{id}")]
        public async Task<IActionResult> PutClassModel(Guid id, ClassModel classModel)
        {
            if (id != classModel.Id)
            {
                return BadRequest();
            }

            _context.Entry(classModel).State = EntityState.Modified;

            try
            {
                await _context.SaveChangesAsync();
            }
            catch (DbUpdateConcurrencyException)
            {
                if (!ClassModelExists(id))
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

        // POST: api/Class
        // To protect from overposting attacks, see https://go.microsoft.com/fwlink/?linkid=2123754
        [HttpPost]
        public async Task<ActionResult<ClassModel>> PostClassModel(ClassModel classModel)
        {
            _context.ClassModel.Add(classModel);
            await _context.SaveChangesAsync();

            return CreatedAtAction("GetClassModel", new { id = classModel.Id }, classModel);
        }

        // DELETE: api/Class/5
        [HttpDelete("{id}")]
        public async Task<IActionResult> DeleteClassModel(Guid id)
        {
            var classModel = await _context.ClassModel.FindAsync(id);
            if (classModel == null)
            {
                return NotFound();
            }

            _context.ClassModel.Remove(classModel);
            await _context.SaveChangesAsync();

            return NoContent();
        }

        private bool ClassModelExists(Guid id)
        {
            return _context.ClassModel.Any(e => e.Id == id);
        }
    }
}
