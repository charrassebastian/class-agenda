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
    public class CourseController : ControllerBase
    {
        private readonly ClassAgendaDbContext _context;

        public CourseController(ClassAgendaDbContext context)
        {
            _context = context;
        }

        // GET: api/Course
        [HttpGet]
        public async Task<ActionResult<IEnumerable<CourseModel>>> GetCourseModel()
        {
            return await _context.CourseModel.ToListAsync();
        }

        // GET: api/Course/5
        [HttpGet("{id}")]
        public async Task<ActionResult<CourseModel>> GetCourseModel(Guid id)
        {
            var courseModel = await _context.CourseModel.FindAsync(id);

            if (courseModel == null)
            {
                return NotFound();
            }

            return courseModel;
        }

        // PUT: api/Course/5
        // To protect from overposting attacks, see https://go.microsoft.com/fwlink/?linkid=2123754
        [HttpPut("{id}")]
        public async Task<IActionResult> PutCourseModel(Guid id, CourseModel courseModel)
        {
            if (id != courseModel.Id)
            {
                return BadRequest();
            }

            _context.Entry(courseModel).State = EntityState.Modified;

            try
            {
                await _context.SaveChangesAsync();
            }
            catch (DbUpdateConcurrencyException)
            {
                if (!CourseModelExists(id))
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

        // POST: api/Course
        // To protect from overposting attacks, see https://go.microsoft.com/fwlink/?linkid=2123754
        [HttpPost]
        public async Task<ActionResult<CourseModel>> PostCourseModel(CourseModel courseModel)
        {
            _context.CourseModel.Add(courseModel);
            await _context.SaveChangesAsync();

            return CreatedAtAction("GetCourseModel", new { id = courseModel.Id }, courseModel);
        }

        // DELETE: api/Course/5
        [HttpDelete("{id}")]
        public async Task<IActionResult> DeleteCourseModel(Guid id)
        {
            var courseModel = await _context.CourseModel.FindAsync(id);
            if (courseModel == null)
            {
                return NotFound();
            }

            _context.CourseModel.Remove(courseModel);
            await _context.SaveChangesAsync();

            return NoContent();
        }

        private bool CourseModelExists(Guid id)
        {
            return _context.CourseModel.Any(e => e.Id == id);
        }
    }
}
