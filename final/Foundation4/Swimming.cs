class Swimming : Activity
{
    private double laps;
    private double distance;
    public Swimming(string date, int time, int laps) : base(date, time)
    {
        this.laps = laps;
        activitytype = "Swimming";
    }
    protected override double calcdistance()
    {
        
        distance = laps * 50 / 1000 * .62;
        return Math.Round(distance, 2);
    }
    protected override double calcpace()
    {
        return Math.Round(time / distance, 2);
    }
    protected override double calcspeed()
    {
        return Math.Round(distance / time * 60, 2);
    }
}