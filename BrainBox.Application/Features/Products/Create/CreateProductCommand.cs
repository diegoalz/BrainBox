using BrainBox.Domain.Models;
using MediatR;
using Microsoft.AspNetCore.Authorization.Infrastructure;

namespace BrainBox.Application.Features.Products.Create;

public record CreateProductCommand(
    string Name,
    string Description,
    ProductUniqueId UniqueId,
    string Sku,
    string Barcode
) : IRequest<Unit>;