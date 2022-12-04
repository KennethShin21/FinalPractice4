using System;

namespace Practice1
{
    class Program
    {
        static void Main(string[] args)
        {
            List<Video> videoList = new List<Video>();

            Video video1 = new Video();
            video1._title = "Trip to Rank Game! All Tank, Mid Only!";
            video1._author = "ChooxTV";
            video1._length = 11.68F;
                List<Comment> Video1Comments = new List<Comment>();
                Comment ChooxTVComment1 = new Comment();
                ChooxTVComment1._nameOfCommenter = "@obiwanshinobi9368";
                ChooxTVComment1._textOfCommenter = "Bat now I've just watched? 💕";
                Video1Comments.Add(ChooxTVComment1);

                Comment ChooxTVcomment2 = new Comment();
                ChooxTVcomment2._nameOfCommenter = "@kpopies7588";
                ChooxTVcomment2._textOfCommenter = "Last time I was in the same room, he gave a new skin and star light.";
                Video1Comments.Add(ChooxTVcomment2);

                Comment ChooxTVComment3 = new Comment();
                ChooxTVComment3._nameOfCommenter = "@mayiehantolin693";
                ChooxTVComment3._textOfCommenter = "I'm recently depressed.. but when i started following you sir chook i almost forgot na may have passed ako... Hahahaha thanks to videos mu... i keep smiling na everyday... hahahaha";
                Video1Comments.Add(ChooxTVComment3);

                video1._comments = Video1Comments;
            videoList.Add(video1);

            Video video2 = new Video();
            video2._title = "BTS (방탄소년단) 'Permission to Dance' Official MV";
            video2._author = "HYBE LABELS";
            video2._length = 4.99F;
                List<Comment> Video2Comments = new List<Comment>();
                Comment HypeLabelsComment1 = new Comment();
                HypeLabelsComment1._nameOfCommenter = "@chosogcf4427";
                HypeLabelsComment1._textOfCommenter = "That little dance in the 'danananananana' part is so addictive I love it.";
                Video2Comments.Add(HypeLabelsComment1);

                Comment HypeLabelsComment2 = new Comment();
                HypeLabelsComment2._nameOfCommenter = "@maevilynlozano2573";
                HypeLabelsComment2._textOfCommenter = "Let's go to 600M views they deserve it BTS forever 💜💜💜";
                Video2Comments.Add(HypeLabelsComment2);

                Comment HypeLabelsComment3 = new Comment();
                HypeLabelsComment3._nameOfCommenter = "@yambemnanaobi9530";
                HypeLabelsComment3._textOfCommenter = "Wow! Beautiful song.";
                Video2Comments.Add(HypeLabelsComment3);

                video2._comments = Video2Comments;
            videoList.Add(video2);

            Video video3 = new Video();
            video3._title = "I Spent 150 Days Creating A Naruto Trailer - Part 3";
            video3._author = "Jalex Rosa";
            video3._length = 10.81F;
                List<Comment> Video3Comments = new List<Comment>();
                Comment JalexComment1 = new Comment();
                JalexComment1._nameOfCommenter = "@MundusFate";
                JalexComment1._textOfCommenter = "Imagine if he has a whole Hollywood budget, he'll create masterpieces🤩🤩🤩";
                Video3Comments.Add(JalexComment1);

                Comment JalexComment2 = new Comment();
                JalexComment2._nameOfCommenter = "@guanedits6349";
                JalexComment2._textOfCommenter = "Never disappoints. Your work flow is amazing and inspiring";
                Video3Comments.Add(JalexComment2);

                Comment JalexComment3 = new Comment();
                JalexComment3._nameOfCommenter = "@muhammadzeeshan877";
                JalexComment3._textOfCommenter = "This guy deserves a huge appreciation for the efforts he's putting for this... amazing indeed";
                Video3Comments.Add(JalexComment3);

                video3._comments = Video3Comments;
            videoList.Add(video3);

            foreach (Video video in videoList)
            {
                Console.WriteLine("--------------------------------------------------------------------------");
                Console.WriteLine($"Title: {video._title}");
                Console.WriteLine($"Author: {video._author}");
                Console.WriteLine($"Length: {video._length} minutes");
                Console.WriteLine($"Number of Comments: {video.GetCommentCount()}");

                    foreach (Comment comment in video._comments)
                    {
                        Console.WriteLine($"Username: {comment._nameOfCommenter}");
                        Console.WriteLine($"      Comment: {comment._textOfCommenter}");
                    }
            }



        }
    }
}
