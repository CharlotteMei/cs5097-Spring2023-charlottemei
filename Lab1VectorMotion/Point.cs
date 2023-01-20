public class Point
{
    
    public double x { get; set; }
    public double y { get; set; }
    public double z { get; set; }
    public Point(){}
    public Point(double x, double y, double z)
    {
        this.x = x;
        this.y = y; 
        this.z = z;
    }

    public string Print()
    {
        return $"{x} {y} {z}";
    }
    
}