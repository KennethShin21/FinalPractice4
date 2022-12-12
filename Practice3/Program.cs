using System;

namespace Practice3
{
    class Program
    {
        static void Main(string[] args)
        {
            //create first event that is a lecture.
            Lecture event1 = new Lecture();
            event1.SetSpeaker("Robert Takahashi");
            event1.SetCapacity("500 people");
            event1.SetDescription("A lecture on financial education for High School Students.");
            event1.SetTitle("How to be a Millionaire?");
            var lectureDate = new DateOnly(2023, 01, 09);
            event1.SetDate(lectureDate);
            
            var lectureTime = new TimeOnly(18, 0, 0);
            event1.SetTime(lectureTime);
            event1.SetAddress("Mountain High School, Riverland City");

            //output!
            Console.WriteLine("========================================================================================================");
            Console.WriteLine($"Standard Details:");
            Console.WriteLine(event1.GetFullEvent());
            Console.WriteLine($"Attendance will be checked! Please attend the lecture!");
            Console.WriteLine("--------------------------------------------------------------------------------------------------------");
            Console.WriteLine($"Full Details:");
            Console.WriteLine(event1.PrintLecture());
            Console.WriteLine($"Be ready to take down notes on this lecture as we will have a quiz about it later on!");
            Console.WriteLine("--------------------------------------------------------------------------------------------------------");
            Console.WriteLine($"Short Details:");
            Console.WriteLine(event1.GetShortDetails());
            Console.WriteLine($"Join us and you'll not regret!");

            //creating an outdoor gathering event!
            OutdoorGathering event2 = new OutdoorGathering();
            event2.SetForecast("Sunny Day");
            event2.SetDescription("IT students camping at Mt. Fuji");
            event2.SetTitle("A day in the forest! Survival of the fittest!");
            var gatheringDate = new DateOnly(2023, 01, 28);
            event2.SetDate(gatheringDate);
            var gatheringTime = new TimeOnly(8, 0, 0);
            event2.SetTime(gatheringTime);
            event2.SetAddress("Mt. Fuji, Honshu");

            //for the output!
            Console.WriteLine("========================================================================================================");
            Console.WriteLine($"Standard Details:");
            Console.WriteLine(event2.GetFullEvent());
            Console.WriteLine($"Trying to live with the environment for a while makes you healthier!");
            Console.WriteLine("--------------------------------------------------------------------------------------------------------");
            Console.WriteLine($"Full Details:");
            Console.WriteLine(event2.PrintOutdoorGathering());
            Console.WriteLine($"Camping with friends is the best! Try it now!");
            Console.WriteLine("--------------------------------------------------------------------------------------------------------");
            Console.WriteLine($"Short Details:");
            Console.WriteLine(event2.GetShortDetails());
            Console.WriteLine($"Join us and you'll not regret!");
            
            //creating a reception event!
            Reception event3 = new Reception();
            event3.SetRegistered("150 people");
            event3.SetDescription("Stark and Lannister Nuptial Reception");
            event3.SetTitle("A Day When a Man and a Woman becomes One!");
            event3.SetRSVPEmail("kenny.b@gmail.com");
            var receptionDate = new DateOnly(2023, 04, 17);
            event3.SetDate(receptionDate);
            var receptionTime = new TimeOnly(12, 0, 0);
            event3.SetTime(receptionTime);
            event3.SetAddress("Cebu City, Cebu");

            //for output!
            Console.WriteLine("========================================================================================================");
            Console.WriteLine($"Standard Details:");
            Console.WriteLine(event3.GetFullEvent());
            Console.WriteLine($"Witnessing the heart-warming wedding of two lovebirds!");
            Console.WriteLine("--------------------------------------------------------------------------------------------------------");
            Console.WriteLine($"Full Details:");
            Console.WriteLine(event3.PrintReception());
            Console.WriteLine($"Family and friends are invited to eat, drink and be merry!");
            Console.WriteLine("--------------------------------------------------------------------------------------------------------");
            Console.WriteLine($"Short Details:");
            Console.WriteLine(event3.GetShortDetails());
            Console.WriteLine($"Join us and you'll not regret!");
        }
    }
}