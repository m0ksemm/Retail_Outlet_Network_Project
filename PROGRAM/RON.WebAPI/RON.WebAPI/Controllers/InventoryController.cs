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
    public class InventoryController : ControllerBase
    {
        private readonly IInventoryService _inventoryService;

        public InventoryController(IInventoryService inventoryService)
        {
            _inventoryService = inventoryService;
        }

        // GET: api/Inventory
        [HttpGet]
        public async Task<ActionResult<IEnumerable<Inventory>>> GetAllInventory()
        {
            return await _inventoryService.GetAllInventory();
        }

        // GET: api/Inventory/5
        [HttpGet("{id}")]
        public async Task<ActionResult<Inventory>> GetInventory(Guid id)
        {
            Inventory? inventory = await _inventoryService.GetInventory(id);

            if (inventory == null)
            {
                return NotFound();
            }
            else
            {
                return inventory;
            }
        }

        // PUT: api/Inventory/5
        // To protect from overposting attacks, see https://go.microsoft.com/fwlink/?linkid=2123754
        [HttpPut("{id}")]
        public async Task<IActionResult> PutInventory(Guid id, Inventory inventory)
        {
            bool result = await _inventoryService.UpdateInventory(id, inventory);
            if (result)
            {
                return NoContent();
            }
            else
            {
                return BadRequest("Inventory's data is invalid or such inventory already exists");
            }
        }

        // POST: api/Inventory
        // To protect from overposting attacks, see https://go.microsoft.com/fwlink/?linkid=2123754
        [HttpPost]
        public async Task<ActionResult<Inventory>> PostInventory(Inventory inventory)
        {
            bool result = await _inventoryService.AddInventory(inventory);
            if (result)
            {
                return CreatedAtAction("GetInventory", new { id = inventory.InventoryID }, inventory);
            }
            else
            {
                return BadRequest("Inventory's data is invalid or this inventory already exists.");
            }
        }

        // DELETE: api/Inventory/5
        [HttpDelete("{id}")]
        public async Task<IActionResult> DeleteInventory(Guid id)
        {
            bool result = await _inventoryService.DeleteInventory(id);
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
