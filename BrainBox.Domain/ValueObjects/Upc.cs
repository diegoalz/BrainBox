namespace Domain.ValueObjects;

public partial record Upc
{
    public int Value { get; init; }
    private const int DefaultLenght = 12;
    private Upc(int value) => Value = value;

    public static Upc? Create(int Value)
    {
        if(Value.ToString().Length != DefaultLenght)
        {
            return null;
        }
        return new Upc(Value);
    }
}