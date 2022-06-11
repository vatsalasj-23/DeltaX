using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using MovieSystem.Models;

namespace MovieSystem.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class ProducersController : ControllerBase
    {
        private readonly MovieSystemContext _context;

        public ProducersController(MovieSystemContext context)
        {
            _context = context;
        }

        // GET: api/Producers
        [HttpGet]
        public IEnumerable<Producer> GetProducer()
        {
            return _context.Producer;
        }

        // GET: api/Producers/5
        [HttpGet("{id}")]
        public async Task<IActionResult> GetProducer([FromRoute] int id)
        {
            if (!ModelState.IsValid)
            {
                return BadRequest(ModelState);
            }

            var producer = await _context.Producer.FindAsync(id);

            if (producer == null)
            {
                return NotFound();
            }

            return Ok(producer);
        }

        // PUT: api/Producers/5
        [HttpPut("{id}")]
        public async Task<IActionResult> PutProducer([FromRoute] int id, [FromBody] Producer producer)
        {
            if (!ModelState.IsValid)
            {
                return BadRequest(ModelState);
            }

            if (id != producer.ID)
            {
                return BadRequest();
            }

            _context.Entry(producer).State = EntityState.Modified;

            try
            {
                await _context.SaveChangesAsync();
            }
            catch (DbUpdateConcurrencyException)
            {
                if (!ProducerExists(id))
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

        // POST: api/Producers
        [HttpPost]
        public async Task<IActionResult> PostProducer([FromBody] Producer producer)
        {
            if (!ModelState.IsValid)
            {
                return BadRequest(ModelState);
            }

            _context.Producer.Add(producer);
            await _context.SaveChangesAsync();

            return CreatedAtAction("GetProducer", new { id = producer.ID }, producer);
        }

        // DELETE: api/Producers/5
        [HttpDelete("{id}")]
        public async Task<IActionResult> DeleteProducer([FromRoute] int id)
        {
            if (!ModelState.IsValid)
            {
                return BadRequest(ModelState);
            }

            var producer = await _context.Producer.FindAsync(id);
            if (producer == null)
            {
                return NotFound();
            }

            _context.Producer.Remove(producer);
            await _context.SaveChangesAsync();

            return Ok(producer);
        }

        private bool ProducerExists(int id)
        {
            return _context.Producer.Any(e => e.ID == id);
        }
    }
}