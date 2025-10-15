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
    public class StoresController : ControllerBase
    {
        private readonly IStoresService _storesService;

        public StoresController(IStoresService storesService)
        {
            _storesService = storesService;
        }

        // GET: api/Stores
        [HttpGet]
        public async Task<ActionResult<IEnumerable<Store>>> GetStores()
        {
            return await _storesService.GetStores();
        }

        // GET: api/Stores/5
        [HttpGet("{id}")]
        public async Task<ActionResult<Store>> GetStore(Guid id)
        {
            Store? store = await _storesService.GetStore(id);

            if (store == null)
            {
                return NotFound();
            }
            else
            {
                return store;
            }
        }

        // PUT: api/Stores/5
        // To protect from overposting attacks, see https://go.microsoft.com/fwlink/?linkid=2123754
        [HttpPut("{id}")]
        public async Task<IActionResult> PutStore(Guid id, Store store)
        {
            bool result = await _storesService.UpdateStore(id, store);
            if (result)
            {
                return NoContent();
            }
            else
            {
                return BadRequest("Store's data is invalid or such store already exists");
            }
        }

        // POST: api/Stores
        // To protect from overposting attacks, see https://go.microsoft.com/fwlink/?linkid=2123754
        [HttpPost]
        public async Task<ActionResult<Store>> PostStore(Store store)
        {
            bool result = await _storesService.AddStore(store);
            if (result)
            {
                return CreatedAtAction("GetStore", new { id = store.StoreID }, store);
            }
            else
            {
                return BadRequest("Store's data is invalid or this store already exists.");
            }
        }

        // DELETE: api/Stores/5
        [HttpDelete("{id}")]
        public async Task<IActionResult> DeleteStore(Guid id)
        {
            bool result = await _storesService.DeleteStore(id);
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
