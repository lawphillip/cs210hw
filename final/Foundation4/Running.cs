class Running : Activity
{
    private double distance;
    public Running(string date, int time, double distance) : base(date, time)
    {
        this.distance = distance;
        activitytype = "Running";
    }
    protected override double calcdistance()
    {
        return distance;
    }
    protected override double calcpace()
    {
        return time / distance;
    }
    protected override double calcspeed()
    {
        return distance / time * 60;
    }

}