using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using BusinessLookup.Models;

namespace BusinessLookup.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class BusinessesController : ControllerBase
    {
        private readonly BusinessLookupContext _context;

        public BusinessesController(BusinessLookupContext context) { _context = context; }

        // GET: api/Businesses
        [HttpGet]
        public async Task<ActionResult<IEnumerable<Business>>> Get(string city, string state, int zip, string price, string minPrice, string category, string subcategory)
        {
            var query = _context.Businesses.AsQueryable();

            if (city != null)
            {
                query = query.Where(entry => entry.City == city);
            }
            
            if (state != null)
            {
                query = query.Where(entry => entry.State == state);
            }
            
            if (zip > 9999)
            {
                query = query.Where(entry => entry.Zip == zip);
            }

            if (price != null)
            {
                query = query.Where(entry => entry.Price == price);
            }

            // if (price > minPrice.Length){
            //     query = query.Where(entry => entry.Price >= minPrice);
            // }elseif (price < minPrice.Length){
            //     query = query.Where(entry => entry.Price <= minPrice);
            // }else{
            //     query = query.Where(entry => entry.Price == minPrice);
            // }

            if (category != null)
            {
                query = query.Where(entry => entry.Category == category);
            }
            
            if (subcategory != null)
            {
                query = query.Where(entry => entry.Subcategory == subcategory);
            }

            return await query.ToListAsync();
        }
        
        // GET: api/Businesses/5
        [HttpGet("{id}")]
        public async Task<ActionResult<IEnumerable<Business>>> Get(int id)
        {
            var businesses = await _context.Businesses.Where(entry => entry.Id == id).ToListAsync();

            if (businesses == null)
            {
                return NotFound();
            }

            return businesses;
        }

        // PUT: api/Businesses/5
        [HttpPut("{id}")]
        public async Task<IActionResult> PutBusiness(int id, Business business)
        {
            if (id != business.Id)
            {
                return BadRequest();
            }

            _context.Entry(business).State = EntityState.Modified;

            try
            {
                await _context.SaveChangesAsync();
            }
            catch (DbUpdateConcurrencyException)
            {
                if (!BusinessExists(id))
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

        // POST: api/Businesses
        [HttpPost]
        public async Task<ActionResult<Business>> PostBusiness(Business business)
        {
            _context.Businesses.Add(business);
            await _context.SaveChangesAsync();

            return CreatedAtAction("Get", new { id = business.Id }, business);
        }

        // DELETE: api/Businesses/5
        [HttpDelete("{id}")]
        public async Task<IActionResult> DeleteBusiness(int id)
        {
            var business = await _context.Businesses.FindAsync(id);
            if (business == null)
            {
                return NotFound();
            }

            _context.Businesses.Remove(business);
            await _context.SaveChangesAsync();

            return NoContent();
        }

        private bool BusinessExists(int id)
        {
            return _context.Businesses.Any(e => e.Id == id);
        }
    }
}
