
using BrainBox.Domain.Models;
using Microsoft.EntityFrameworkCore;

namespace BrainBox.Application.Data;

public interface IApplicationDbContext
{
    DbSet<Product> Products { get; }
    Task<int> SaveChangesAsync(CancellationToken cancellationToken = default);
}