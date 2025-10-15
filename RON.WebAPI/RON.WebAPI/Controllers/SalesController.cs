using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using RON.WebAPI.DatabaseContext;
using RON.WebAPI.Models;
using RON.WebAPI.Services;
using RON.WebAPI.ServicesContracts;

namespace RON.WebAPI.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class SalesController : ControllerBase
    {
        private readonly ISalesService _salesService;

        public SalesController(ISalesService salesService)
        {
            _salesService = salesService;
        }

        // GET: api/Sales
        [HttpGet]
        public async Task<ActionResult<IEnumerable<Sale>>> GetSales()
        {
            return await _salesService.GetSales();
        }

        // GET: api/Sale/5
        [HttpGet("{id}")]
        public async Task<ActionResult<Sale>> GetSale(Guid id)
        {
            Sale? sale = await _salesService.GetSale(id);

            if (sale == null)
            {
                return NotFound();
            }
            else
            {
                return sale;
            }
        }

        // PUT: api/Sale/5
        // To protect from overposting attacks, see https://go.microsoft.com/fwlink/?linkid=2123754
        [HttpPut("{id}")]
        public async Task<IActionResult> PutSale(Guid id, Sale sale)
        {
            bool result = await _salesService.UpdateSale(id, sale);
            if (result)
            {
                return NoContent();
            }
            else
            {
                return BadRequest("Sale's data is invalid or such sale already exists");
            }
        }

        // POST: api/Sale
        // To protect from overposting attacks, see https://go.microsoft.com/fwlink/?linkid=2123754
        [HttpPost]
        public async Task<ActionResult<Sale>> PostSale(Sale sale)
        {
            bool result = await _salesService.AddSale(sale);
            if (result)
            {
                return CreatedAtAction("GetSale", new { id = sale.SaleID }, sale);
            }
            else
            {
                return BadRequest("Sale's data is invalid or this sale already exists.");
            }
        }

        // DELETE: api/Sale/5
        [HttpDelete("{id}")]
        public async Task<IActionResult> DeleteSale(Guid id)
        {
            bool result = await _salesService.DeleteSale(id);
            if (result)
            {
                return NoContent();
            }
            else
            {
                return BadRequest();
            }
        }
    }
}
