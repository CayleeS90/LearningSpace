using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace LearningSpace
{
    class RockClimbing
    {
        List<RockClimbingUser> users = new List<RockClimbingUser>();
        List<Route> routes = new List<Route>();

        public void Run()
        {
            Console.WriteLine("Welcome to the Vertical Ventures rock climbing scorekeeper!");

            SeedUsers();
            SeedRoutes();

            Console.WriteLine("What's your name?");

            string name = Console.ReadLine();

            RockClimbingUser user = new RockClimbingUser
            {
                FirstName = name
            };

            users.Add(user);

            Console.WriteLine("Which route did you complete? Here are the choices, enter the #. Type stop to see leaderboard.");
            foreach (var route in routes)
            {
                Console.WriteLine($"Route {route.Id}, {route.Name}, {route.Points}");
            }

            while (true)
            {
                if (!int.TryParse(Console.ReadLine(), out int routeId)) break;
                Route currRoute = routes.Where(x => x.Id == routeId).FirstOrDefault();
                user.Score += currRoute.Points;
                Console.WriteLine($"Your current score is now: {user.Score}");
            }

            PrintLeaderBoard();
        }

        private void SeedRoutes()
        {
            Route route1 = new Route
            {
                Id = 1,
                Grade = VGrade.V1,
                Points = 10,
                Name = "Beginner pink"
            };

            routes.Add(route1);

            Route route2 = new Route
            {
                Id = 2,
                Grade = VGrade.V4,
                Points = 45,
                Name = "On the way!"
            };

            routes.Add(route2);

            Route route3 = new Route
            {
                Id = 3,
                Grade = VGrade.V7,
                Points = 120,
                Name = "Send em high!"
            };

            routes.Add(route3);
        }

        private void SeedUsers()
        {
            RockClimbingUser user1 = new RockClimbingUser
            {
                FirstName = "Crystal",
                Score = 300
            };

            users.Add(user1);

            RockClimbingUser user2 = new RockClimbingUser
            {
                FirstName = "Viktor",
                Score = 150
            };

            users.Add(user2);

            RockClimbingUser user3 = new RockClimbingUser
            {
                FirstName = "Derek",
                Score = 200
            };

            users.Add(user3);

            RockClimbingUser user4 = new RockClimbingUser
            {
                FirstName = "Yogurt",
                Score = 0
            };

            users.Add(user4);
        }

        public void PrintLeaderBoard()
        {
            List<RockClimbingUser> orderedList = users.OrderByDescending(x => x.Score).ToList();

            int count = 1;

            Console.WriteLine("Current Leaderboard:");

            foreach (var user in orderedList)
            {
                Console.WriteLine($"{count++}. {user.FirstName} score is {user.Score}");
            }

            Console.WriteLine("Thanks for climbing!");
        }
    }
}
