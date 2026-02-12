namespace AoC6;

internal class Operator
{
    public string Value { get => _value; }
    private string _value;

    internal Operator(string value)
    {
        _value = value;
    }

    internal int Caulculate(List<int>operands)
    {
        return _value switch
        {
            "+" => operands.Sum(),
            "-" => operands.Aggregate((a, b) => a - b),
            "*" => operands.Aggregate((a, b) => a * b),
            "/" => operands.Aggregate((a, b) => a / b),
            _ => throw new InvalidOperationException($"Invalid operator: {_value}"),
        };
    }
    
}