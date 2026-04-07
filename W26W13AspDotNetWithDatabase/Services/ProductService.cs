using Microsoft.EntityFrameworkCore;
using W26W13AspDotNetWithDatabase.Models;
using W26W13AspDotNetWithDatabase.Data;

namespace W26W13AspDotNetWithDatabase.Services
{
    public class ProductService
    {
        private AppDbContext _context;

        public ProductService(AppDbContext context)
        {
            _context = context;
        }

        public async Task<List<Product>> GetProductsAsync()
        {
            return await _context.Products.ToListAsync();
        }
    }
}
