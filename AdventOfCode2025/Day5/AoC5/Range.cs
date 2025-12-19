internal class Range
{
    public int Start { get; set; }
    public int End { get; set; }

    public Range(int start, int end)
    {
        Start = start;
        End = end;
    }

    public bool Contains(int value)
    {
        return value >= Start && value <= End;
    }
}