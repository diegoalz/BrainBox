using BrainBox.Domain.Common;
using BrainBox.Domain.Models;

namespace BrainBox.Application.Contracts;

public interface IProductRepository
{
    Task<Product> GetByIdAsync(BaseId id);
    // Task<bool> ExistsAsync(BaseId id);
    // void Add(Product product);
    // void Update(Product product);
    // void Delete(Product product);
}