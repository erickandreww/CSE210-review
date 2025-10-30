using System;

class Program
{
    static void Main(string[] args)
    {
        List<Video> videos = new List<Video>();

        Video video1 = new Video("Learning C# for Beginners", "CodeMaster Academy", 480);
        video1.SetVideoComment("Anna", "This was super helpful! The examples were easy to follow.");
        video1.SetVideoComment("Lucas", "Finally understood classes and objects thanks to this.");
        video1.SetVideoComment("Maria", "Please make a follow-up video on inheritance!");
        videos.Add(video1);

        Video video2 = new Video("Understanding Object-Oriented Programming", "Dev Insights", 720);
        video2.SetVideoComment("Bruno", "Clear explanations and great pacing.");
        video2.SetVideoComment("Nina", "Loved how you broke down the concepts step by step.");
        video2.SetVideoComment("Felipe", "Helped me a lot with my university project.");
        videos.Add(video2);

        Video video3 = new Video("Top 5 Programming Languages in 2025", "Tech Vision", 650);
        video3.SetVideoComment("Sophia", "I totally agree with Python being at the top!");
        video3.SetVideoComment("Diego", "Nice overview! Curious to see how Rust will grow.");
        video3.SetVideoComment("Lara", "Could you make one focused on game development next?");
        videos.Add(video3);

        Video video4 = new Video("Building Your First Game with Unity", "GameLab Studios", 900);
        video4.SetVideoComment("Erick", "Perfect tutorial for beginners. Thank you!");
        video4.SetVideoComment("Carla", "I followed along and created my first working prototype!");
        video4.SetVideoComment("Jonas", "Can you do one about adding animations next?");
        videos.Add(video4);

        foreach (Video video in videos)
        {
            video.displayVideo();
            Console.WriteLine(""); 
        }
    }
}