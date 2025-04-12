using System;
using EBAR_BL;

namespace Emoji_Based_Anime_Recommender
{
    internal class Program
    {
     
        static void Main(string[] args)
        {
            MainMenu();

        }

       
        public static void MainMenu()
        {
            Console.WriteLine("Emoji-based Anime Series Recommendation");

            string confirmIdentity;

            string[] identities = { "[1]Admin", "[2]User" };

            while (true)
            {
                Console.WriteLine("---------------------------------");
                Console.WriteLine("IDENTITY CONFIRMATION");
                foreach (string identity in identities)
                {
                    Console.WriteLine(identity);
                }
                Console.Write("Input : ");
                confirmIdentity = Console.ReadLine().ToLower();

                if (confirmIdentity.Equals("1") || confirmIdentity == "admin")
                {
                    Admin admin = new Admin();
                    admin.ShowAdminMenu();
                    break;
                }

                else if (confirmIdentity.Equals("2") || confirmIdentity == "user")
                {
                    User user = new User();
                    user.RunAsUser();
                    break;
                }
                else if (string.IsNullOrWhiteSpace(confirmIdentity))
                {
                    Console.WriteLine("Input cannot be empty");
                }
                else
                {
                    Console.WriteLine("Enter existing choices only");
                }

            }
        }

       
    }
}
