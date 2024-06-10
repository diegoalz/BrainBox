using BrainBox.Domain.Common;

namespace BrainBox.Domain.Models;
public sealed class Brand : BaseAutidableModel
{
    public string? Name { get; set; }
    public string? Description { get; set; }
}