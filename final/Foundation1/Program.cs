using System;

class Program
{
    static void Main(string[] args)
    {
        List<Video> videos = new List<Video>();
        videos.Add(new Video("Train crushes Lambo","Mr.Beast", 180));
        videos[0].makecomment("joe", "this video is so super awesome");
        videos[0].makecomment("momo124", "they should've given that lambo to me ");
        videos[0].makecomment("bob", "I loved it when the train destroyed the car");
        videos.Add(new Video("How to change the oil on a 2004 camry","timcars5", 80));
        videos[1].makecomment("howy","what happens if the oil is brown");
        videos[1].makecomment("ben","is it the same for the 2005");
        videos[1].makecomment("kim","very useful saved me over 50 dollars");
        videos.Add(new Video("Reaction to the dune 3 trailer","movies33", 120));
        videos[2].makecomment("bigmo76","im so excited for this movie");
        videos[2].makecomment("xxbilxx","Im so excited for timothy to kick butt");
        videos[2].makecomment("nemos","The last movie was amazing");
        foreach(Video video in videos)
        {
            video.displayvideo();
        }

    }
}