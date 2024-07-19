using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using Api_Test.Models;

namespace Api_Test.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class NumberOrdersController : ControllerBase
    {
        private readonly Test1Context _context;

        public NumberOrdersController(Test1Context context)
        {
            _context = context;
        }

        // GET: api/NumberOrders
        [HttpGet]
        public async Task<ActionResult<IEnumerable<NumberOrder>>> GetNumberOrders()
        {
            return await _context.NumberOrders.ToListAsync();
        }

        // GET: api/NumberOrders/5
        [HttpGet("{id}")]
        public async Task<ActionResult<NumberOrder>> GetNumberOrder(int? id)
        {
            var numberOrder = await _context.NumberOrders.FindAsync(id);

            if (numberOrder == null)
            {
                return NotFound();
            }

            return numberOrder;
        }

        // PUT: api/NumberOrders/5
        // To protect from overposting attacks, see https://go.microsoft.com/fwlink/?linkid=2123754
        [HttpPut("{id}")]
        public async Task<IActionResult> PutNumberOrder(int? id, NumberOrder numberOrder)
        {
            if (id != numberOrder.IdNumberOrder)
            {
                return BadRequest();
            }

            _context.Entry(numberOrder).State = EntityState.Modified;

            try
            {
                await _context.SaveChangesAsync();
            }
            catch (DbUpdateConcurrencyException)
            {
                if (!NumberOrderExists(id))
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

        // POST: api/NumberOrders
        // To protect from overposting attacks, see https://go.microsoft.com/fwlink/?linkid=2123754
        [HttpPost]
        public async Task<ActionResult<NumberOrder>> PostNumberOrder(NumberOrder numberOrder)
        {
            _context.NumberOrders.Add(numberOrder);
            await _context.SaveChangesAsync();

            return CreatedAtAction("GetNumberOrder", new { id = numberOrder.IdNumberOrder }, numberOrder);
        }

        // DELETE: api/NumberOrders/5
        [HttpDelete("{id}")]
        public async Task<IActionResult> DeleteNumberOrder(int? id)
        {
            var numberOrder = await _context.NumberOrders.FindAsync(id);
            if (numberOrder == null)
            {
                return NotFound();
            }

            _context.NumberOrders.Remove(numberOrder);
            await _context.SaveChangesAsync();

            return NoContent();
        }

        private bool NumberOrderExists(int? id)
        {
            return _context.NumberOrders.Any(e => e.IdNumberOrder == id);
        }
    }
}
