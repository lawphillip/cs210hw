class Activity
{
    private string date;
    protected int time;
    protected string activitytype;
    public Activity(string date, int time)
    {
        this.date = date;
        this.time = time;
    }

    protected virtual double calcdistance()
    {
        double distance = 0;
        return distance;
    }
    protected virtual double calcspeed()
    {
        double speed = 0;
        return speed;
    }
    protected virtual double calcpace()
    {
        double pace = 0;
        return pace;
    }
    public string getsummary()
    {
        return $"{date} {activitytype} ({time}min)- Distance {calcdistance()} miles, Speed {calcspeed()} mph, Pace: {calcpace()} min per mile";
    }
}