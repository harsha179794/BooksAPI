using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using BooksAPI.Models;
using Microsoft.EntityFrameworkCore;

namespace BooksAPI.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class GetBooksController : Controller
    {
        private BooksContext _context;

        public GetBooksController(BooksContext context)
        {
            _context = context;

            if (_context.BookItems.Count() == 0)
            {
                // Create a new BooksItem if collection is empty,
                // which means you can't delete all BookItems.
                _context.BookItems.Add(new BooksItem { BookName = "C# Programming" , Author="Harsha" , Isbn=1234556788 });
                _context.SaveChanges();
            }
        }
        [HttpGet]
        public async Task<ActionResult<IEnumerable<BooksItem>>> GetBooksItems()
        {
            return await _context.BookItems.ToListAsync();
        }

        [HttpGet("{id}")]
        public async Task<ActionResult<BooksItem>> GetBooksItems(long id)
        {
            var bookItem = await _context.BookItems.FindAsync(id);

            if (bookItem == null)
            {
                return NotFound();
            }

            return bookItem;
        }

        
    }
}