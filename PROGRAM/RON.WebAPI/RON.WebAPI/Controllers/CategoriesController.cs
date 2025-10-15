using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using RON.WebAPI.DatabaseContext;
using RON.WebAPI.Models;
using RON.WebAPI.ServicesContracts;

namespace RON.WebAPI.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class CategoriesController : ControllerBase
    {
        private readonly ICategoriesService _categoriesService;

        public CategoriesController(ICategoriesService categoriesInterface)
        {
            _categoriesService = categoriesInterface;
        }
        // GET: api/Categories
        [HttpGet]
        public async Task<ActionResult<IEnumerable<Category>>> GetCategories()
        {
            return await _categoriesService.GetCategories();
        }
        // GET: api/Categories/5
        [HttpGet("{id}")]
        public async Task<ActionResult<Category>> GetCategory(Guid id)
        {
            var category = await _categoriesService.GetCategory(id);

            if (category == null)
            {
                return NotFound();
            }

            return category;
        }
        // PUT: api/Categories/5
        [HttpPut("{id}")]
        public async Task<IActionResult> PutCategory(Guid id, Category category)
        {
            bool result = await _categoriesService.UpdateCategory(id, category);
            if (result)
            {
                
                return NoContent();
            }
            else 
            {
                return BadRequest("This category already exists");
            }
        }
        // POST: api/Categories
        [HttpPost]
        public async Task<ActionResult<Category>> PostCategory(Category category)
        {
            bool result = await _categoriesService.AddCategory(category);
            if (result)
            {
                return CreatedAtAction("GetCategory", new { id = category.CategoryID }, category);
            }
            else
            {
                return BadRequest("This category already exists");
            }
        }
        // DELETE: api/Categories/5
        [HttpDelete("{id}")]
        public async Task<IActionResult> DeleteCategory(Guid id)
        {
            bool result = await _categoriesService.DeleteCategory(id);
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
