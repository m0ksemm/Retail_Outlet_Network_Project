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
    public class SaleProductsController : ControllerBase
    {
        private readonly ISaleProductService _saleProductService;

        public SaleProductsController(ISaleProductService saleProductService)
        {
            _saleProductService = saleProductService;
        }

        // GET: api/SalesProducts
        [HttpGet]
        public async Task<ActionResult<IEnumerable<SaleProduct>>> GetSalesProducts()
        {
            return await _saleProductService.GetSalesProducts();
        }

        // GET: api/SaleProduct/5
        [HttpGet("{id}")]
        public async Task<ActionResult<SaleProduct>> GetSaleProduct(Guid id)
        {
            SaleProduct? saleProduct = await _saleProductService.GetSaleProduct(id);

            if (saleProduct == null)
            {
                return NotFound();
            }
            else
            {
                return saleProduct;
            }
        }

        // PUT: api/SaleProduct/5
        // To protect from overposting attacks, see https://go.microsoft.com/fwlink/?linkid=2123754
        [HttpPut("{id}")]
        public async Task<IActionResult> PutSaleProduct(Guid id, SaleProduct saleProduct)
        {
            bool result = await _saleProductService.UpdateSaleProduct(id, saleProduct);
            if (result)
            {
                return NoContent();
            }
            else
            {
                return BadRequest("Sale Product's data is invalid or such Sale Product already exists");
            }
        }

        // POST: api/SaleProduct
        // To protect from overposting attacks, see https://go.microsoft.com/fwlink/?linkid=2123754
        [HttpPost]
        public async Task<ActionResult<SaleProduct>> PostSaleProduct(SaleProduct saleProduct)
        {
            bool result = await _saleProductService.AddSaleProduct(saleProduct);
            if (result)
            {
                return CreatedAtAction("GetSaleProduct", new { id = saleProduct.SaleProductID }, saleProduct);
            }
            else
            {
                return BadRequest("Sale Product's data is invalid or this Sale Product already exists.");
            }
        }

        // DELETE: api/SaleProduct/5
        [HttpDelete("{id}")]
        public async Task<IActionResult> DeleteSaleProduct(Guid id)
        {
            bool result = await _saleProductService.DeleteSaleProduct(id);
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