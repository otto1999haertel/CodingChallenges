namespace AoC1;
public class Direction
{
    public DirectionEnum TurnDirection { get; private set; }
    public int Steps { get; private set; }

    public Direction(DirectionEnum turnDirection, int steps)
    {
        TurnDirection = turnDirection;
        Steps = steps;
    }
}