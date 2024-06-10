namespace Domain.ValueObjects;

public partial record Hexadecimal
{
    public string Value { get; set; }
    private Hexadecimal(string value) => Value = value;

    public static Hexadecimal? Create(int Value)
    {
        if(Value < 0)
        {
            return null;
        }
        string ValueString = Value.ToString("X");
        return new Hexadecimal(ValueString);
    }
}