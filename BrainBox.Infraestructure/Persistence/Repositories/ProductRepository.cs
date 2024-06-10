using BrainBox.Application.Contracts;
using BrainBox.Domain.Common;
using BrainBox.Domain.Models;
using Infraestructure.Persistence;
using Microsoft.EntityFrameworkCore;

namespace BrainBox.Infraestructure.Persistence.Repositories;

public class ProductRepository : IProductRepository
{
    private readonly ApplicationDbContext _context;
    public ProductRepository(ApplicationDbContext context)
    {
        _context = context ?? throw new ArgumentNullException(nameof(context));
    }
    public async Task<Product> GetByIdAsync(BaseId id) => await _context.Products.SingleOrDefaultAsync(c => c.Id == id) ?? throw new ArgumentNullException(nameof(_context));
}