namespace AoC8;

internal class Point
{
    private int x;
    private int y;
    private int z;

    public int X { get { return x; } }
    public int Y { get { return y; } } 
    public int Z { get { return z; } }

    public Point(int x, int y, int z)
    {
        this.x = x;
        this.y = y;
        this.z = z;
    }
    
}