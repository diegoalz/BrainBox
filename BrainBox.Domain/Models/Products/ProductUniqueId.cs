using Domain.ValueObjects;

namespace BrainBox.Domain.Models;

public record ProductUniqueId
{
    public string Value { get; set; }
    private const string Prefix = "PDT";
    public ProductUniqueId(string value)
    {
        Value = value;
    }
    public ProductUniqueId(int value)
    {
        Hexadecimal hexValue = Hexadecimal.Create(value)!;
        string prefixedValue = $"{Prefix}-{hexValue.Value}";
        Value = prefixedValue;
    }
    // public override string ToString() => $"{Prefix}-{Value}";
}