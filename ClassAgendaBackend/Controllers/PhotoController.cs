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
    public class PhotoController : ControllerBase
    {
        private readonly CourseAgendaDbContext _context;

        public PhotoController(CourseAgendaDbContext context)
        {
            _context = context;
        }

        // GET: api/Photo
        [HttpGet]
        public async Task<ActionResult<IEnumerable<PhotoModel>>> GetPhotoModel()
        {
            return await _context.PhotoModel.ToListAsync();
        }

        // GET: api/Photo/5
        [HttpGet("{id}")]
        public async Task<ActionResult<PhotoModel>> GetPhotoModel(Guid id)
        {
            var photoModel = await _context.PhotoModel.FindAsync(id);

            if (photoModel == null)
            {
                return NotFound();
            }

            return photoModel;
        }

        // PUT: api/Photo/5
        // To protect from overposting attacks, see https://go.microsoft.com/fwlink/?linkid=2123754
        [HttpPut("{id}")]
        public async Task<IActionResult> PutPhotoModel(Guid id, PhotoModel photoModel)
        {
            if (id != photoModel.Id)
            {
                return BadRequest();
            }

            _context.Entry(photoModel).State = EntityState.Modified;

            try
            {
                await _context.SaveChangesAsync();
            }
            catch (DbUpdateConcurrencyException)
            {
                if (!PhotoModelExists(id))
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

        // POST: api/Photo
        // To protect from overposting attacks, see https://go.microsoft.com/fwlink/?linkid=2123754
        [HttpPost]
        public async Task<ActionResult<PhotoModel>> PostPhotoModel(PhotoModel photoModel)
        {
            _context.PhotoModel.Add(photoModel);
            await _context.SaveChangesAsync();

            return CreatedAtAction("GetPhotoModel", new { id = photoModel.Id }, photoModel);
        }

        // DELETE: api/Photo/5
        [HttpDelete("{id}")]
        public async Task<IActionResult> DeletePhotoModel(Guid id)
        {
            var photoModel = await _context.PhotoModel.FindAsync(id);
            if (photoModel == null)
            {
                return NotFound();
            }

            _context.PhotoModel.Remove(photoModel);
            await _context.SaveChangesAsync();

            return NoContent();
        }

        private bool PhotoModelExists(Guid id)
        {
            return _context.PhotoModel.Any(e => e.Id == id);
        }
    }
}
