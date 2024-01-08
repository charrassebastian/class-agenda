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
    public class AnnotationController : ControllerBase
    {
        private readonly ClassAgendaDbContext _context;

        public AnnotationController(ClassAgendaDbContext context)
        {
            _context = context;
        }

        // GET: api/Annotation
        [HttpGet]
        public async Task<ActionResult<IEnumerable<AnnotationModel>>> GetAnnotationModel()
        {
            return await _context.AnnotationModel.ToListAsync();
        }

        // GET: api/Annotation/5
        [HttpGet("{id}")]
        public async Task<ActionResult<AnnotationModel>> GetAnnotationModel(Guid id)
        {
            var annotationModel = await _context.AnnotationModel.FindAsync(id);

            if (annotationModel == null)
            {
                return NotFound();
            }

            return annotationModel;
        }

        // PUT: api/Annotation/5
        // To protect from overposting attacks, see https://go.microsoft.com/fwlink/?linkid=2123754
        [HttpPut("{id}")]
        public async Task<IActionResult> PutAnnotationModel(Guid id, AnnotationModel annotationModel)
        {
            if (id != annotationModel.Id)
            {
                return BadRequest();
            }

            _context.Entry(annotationModel).State = EntityState.Modified;

            try
            {
                await _context.SaveChangesAsync();
            }
            catch (DbUpdateConcurrencyException)
            {
                if (!AnnotationModelExists(id))
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

        // POST: api/Annotation
        // To protect from overposting attacks, see https://go.microsoft.com/fwlink/?linkid=2123754
        [HttpPost]
        public async Task<ActionResult<AnnotationModel>> PostAnnotationModel(AnnotationModel annotationModel)
        {
            _context.AnnotationModel.Add(annotationModel);
            await _context.SaveChangesAsync();

            return CreatedAtAction("GetAnnotationModel", new { id = annotationModel.Id }, annotationModel);
        }

        // DELETE: api/Annotation/5
        [HttpDelete("{id}")]
        public async Task<IActionResult> DeleteAnnotationModel(Guid id)
        {
            var annotationModel = await _context.AnnotationModel.FindAsync(id);
            if (annotationModel == null)
            {
                return NotFound();
            }

            _context.AnnotationModel.Remove(annotationModel);
            await _context.SaveChangesAsync();

            return NoContent();
        }

        private bool AnnotationModelExists(Guid id)
        {
            return _context.AnnotationModel.Any(e => e.Id == id);
        }
    }
}
