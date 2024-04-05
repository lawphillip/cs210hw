using System.Dynamic;

class Cycling : Activity
{
    private double speed;
    public Cycling(string date, int time, double speed) : base(date, time)
    {
        this.speed = speed;
        activitytype = "Cycling";
    }
    protected override double calcdistance()
    {
        double distance = speed / 60 * time;
        return distance;
    }
    protected override double calcpace()
    {
        return 60 / speed;
    }
    protected override double calcspeed()
    {
        return speed;
    }
    
}