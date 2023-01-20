using System;


public class Program
{
    public static void Main(string[] args)
    {
        Console.WriteLine("===== Start of Program =====.\n");

        if (args.Length < 7) {
            Console.WriteLine("Please enter at least 7 numbers as the inputs");
            System.Environment.Exit(0);  
        }

        List<double> UserInputs = new List<double>();
        for (int i=0; i < args.Length; i++) {

            double OutVal;
            Double.TryParse(args[i], out OutVal);
            if (double.IsNaN(OutVal) || double.IsInfinity(OutVal)) {
                Console.WriteLine("Please enter a valid input, it can be integer or decimal number.");
                System.Environment.Exit(0);  
            }

            UserInputs.Add(OutVal);
        }

        // organize input
        Point start = new Point {x=UserInputs[0], y=UserInputs[1], z=UserInputs[2]};
        Point end = new Point {x=UserInputs[3], y=UserInputs[4], z=UserInputs[5]};
        double time = UserInputs[6];

        Console.WriteLine($"start position: {start.Print()}");
        Console.WriteLine($"end position: {end.Print()}");
        Console.WriteLine($"time: {time}");
        
        // speed
        Console.WriteLine($"distance: {GetDistance(start, end)}");
        double speed = GetDistance(start, end)/time;
        Console.WriteLine($"speed: {speed}");

        // iterate through
        for (int i=1; i < 11; i++) {
            Console.WriteLine($"\niteration {i}");
            Console.WriteLine($"distance traveled {speed*time*i/10}");
            Console.WriteLine(
                $"current position: [{GetLocation(start.x, end.x, i, 10)}, {GetLocation(start.y, end.y, i, 10)}, {GetLocation(start.z, end.z, i, 10)}]"
            );
            Console.WriteLine($"time: {time/10*i}\n");
        }


        Console.WriteLine("\n===== End of Program =====.");
        

    }

    public static double GetDistance(Point p1, Point p2) 
    {
        return Math.Sqrt(Math.Pow(p1.x-p2.x, 2)+Math.Pow(p1.y-p2.y, 2)+Math.Pow(p1.z-p2.z, 2));
    }

    public static double GetLocation(double x1, double x2, int timestep, int totalstep)
    {
        return x1+(x2-x1)*timestep/totalstep;
    }
    
    
    
}

