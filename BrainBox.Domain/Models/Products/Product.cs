using BrainBox.Domain.Common;
using Domain.ValueObjects;

namespace BrainBox.Domain.Models;

public sealed class Product : BaseAutidableModel
{
    public Product()
    // : base()
    {
    }

    public Product(
        BaseId id,
        string name,
        ProductUniqueId uniqueId,
        string description,
        string sku,
        Upc barcode,
        int categoryId,
        DateTime createdDate,
        int createdBy,
        DateTime updatedDate,
        int updatedBy
    )
    // : base (
    //     id,
    //     createdDate,
    //     createdBy,
    //     updatedDate,
    //     updatedBy
    // )
    {
        Name = name;
        UniqueId = uniqueId;
        Description = description;
        Sku = sku;
        Barcode = barcode;
        // CategoryId = categoryId;
    }

    public string Name { get; private set; } = string.Empty;
    public string Description { get; private set; } = string.Empty;
    public string Sku { get; private set; } = string.Empty;
    public ProductUniqueId UniqueId { get; private set; }
    public Upc Barcode { get; private set; }
    public bool Active {get; private set; } = true;
    // public int? CategoryId { get; private set; }
}