using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using BooksAPI.Models;
using System.Collections.Generic;
using Microsoft.EntityFrameworkCore;

namespace BooksAPI.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class AddBooksController : Controller
    {
        private BooksContext _context ;

        public AddBooksController(BooksContext context)
        {
            _context = context;
        }

        [HttpPost]
        public async Task<ActionResult<BooksItem>> PostBookItem(BooksItem item)
        {
            _context.BookItems.Add(item);
            await _context.SaveChangesAsync();

            return CreatedAtAction(nameof(GetBooksItems), new { id = item.Id }, item);
        }


        [HttpPost("AddBookItem")]
        public async Task<ActionResult<BooksItem>> AddBookItem(BooksItem item)
        {
            _context.BookItems.Add(item);
            await _context.SaveChangesAsync();

            return CreatedAtAction(nameof(GetBooksItems), new { id = item.Id }, item);
        }

        [HttpGet]
        public async Task<ActionResult<IEnumerable<BooksItem>>> GetBooksItems()
        {
            return await _context.BookItems.ToListAsync();
        }
    }
}