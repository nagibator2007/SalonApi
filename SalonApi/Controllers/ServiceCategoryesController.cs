using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using SalonApi.Models;

namespace SalonApi.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class ServiceCategoryesController : ControllerBase
    {
        private readonly BeautyDatebaseContext _context;

        public ServiceCategoryesController(BeautyDatebaseContext context)
        {
            _context = context;
        }

        // GET: api/ServiceCategoryes
        [HttpGet]
        public async Task<ActionResult<IEnumerable<ServiceCategoryes>>> GetServiceCategoryes()
        {
            return await _context.ServiceCategoryes.ToListAsync();
        }

        // GET: api/ServiceCategoryes/5
        [HttpGet("{categoryId}")]
        public async Task<ActionResult<ServiceCategoryes>> GetServiceCategoryes(int categoryId)
        {
            var serviceCategoryes = await _context.ServiceCategoryes.FindAsync(categoryId);

            if (serviceCategoryes == null)
            {
                return NotFound();
            }

            return serviceCategoryes;
        }

        // PUT: api/ServiceCategoryes/5
        // To protect from overposting attacks, enable the specific properties you want to bind to, for
        // more details, see https://go.microsoft.com/fwlink/?linkid=2123754.
        [HttpPut("{id}")]
        public async Task<IActionResult> PutServiceCategoryes(int id, ServiceCategoryes serviceCategoryes)
        {
            if (id != serviceCategoryes.CategoryId)
            {
                return BadRequest();
            }

            _context.Entry(serviceCategoryes).State = EntityState.Modified;

            try
            {
                await _context.SaveChangesAsync();
            }
            catch (DbUpdateConcurrencyException)
            {
                if (!ServiceCategoryesExists(id))
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

        // POST: api/ServiceCategoryes
        // To protect from overposting attacks, enable the specific properties you want to bind to, for
        // more details, see https://go.microsoft.com/fwlink/?linkid=2123754.
        [HttpPost]
        public async Task<ActionResult<ServiceCategoryes>> PostServiceCategoryes(ServiceCategoryes serviceCategoryes)
        {
            _context.ServiceCategoryes.Add(serviceCategoryes);
            await _context.SaveChangesAsync();

            return CreatedAtAction("GetServiceCategoryes", new { id = serviceCategoryes.CategoryId }, serviceCategoryes);
        }

        // DELETE: api/ServiceCategoryes/5
        [HttpDelete("{id}")]
        public async Task<ActionResult<ServiceCategoryes>> DeleteServiceCategoryes(int id)
        {
            var serviceCategoryes = await _context.ServiceCategoryes.FindAsync(id);
            if (serviceCategoryes == null)
            {
                return NotFound();
            }

            _context.ServiceCategoryes.Remove(serviceCategoryes);
            await _context.SaveChangesAsync();

            return serviceCategoryes;
        }

        private bool ServiceCategoryesExists(int id)
        {
            return _context.ServiceCategoryes.Any(e => e.CategoryId == id);
        }
    }
}
