using System.ComponentModel;

namespace AoC1;

public class Rotator
{
    private readonly int startingPoint = 50; 
    private readonly int maxPosition = 99;
    private List<Direction> directions;
    public Rotator(List<Direction> Directions)
    {
        directions = Directions;
    }

    public int GetPassword()
    {
        int zeroStopped =0; 
        int currentPosition = startingPoint;
        foreach(var direction in directions)
        {
            if(direction.TurnDirection == DirectionEnum.R)
            {
                if(currentPosition + direction.Steps > maxPosition)
                {
                    currentPosition = (currentPosition + direction.Steps) - (maxPosition + 1);
                }
                else
                {
                    currentPosition += direction.Steps;
                }
            }
            else if(direction.TurnDirection == DirectionEnum.L)
            {
                if(currentPosition - direction.Steps < 0)
                {
                    currentPosition = (maxPosition + 1) + (currentPosition - direction.Steps);
                }
                else
                {
                    currentPosition -= direction.Steps;
                }
            }
            if(currentPosition==0) zeroStopped++;
        }
        return zeroStopped;
    }
}
