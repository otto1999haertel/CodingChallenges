namespace AoC8;

internal class Point3D
{
    private int x;
    private int y;
    private int z;

    public int X { get { return x; } }
    public int Y { get { return y; } } 
    public int Z { get { return z; } }

    internal Point3D(int x, int y, int z)
    {
        this.x = x;
        this.y = y;
        this.z = z;
    }
    
}