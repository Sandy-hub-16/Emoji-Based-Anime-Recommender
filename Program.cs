using System;
using EBAR_BL;

namespace Emoji_Based_Anime_Recommender
{
    internal class Program
    {
     
        static void Main(string[] args)
        {
            while (true) // uses loop -- para sa "return" statement
            {
                MainMenu(); 
            }

        }

       
        public static void MainMenu()
        {
            Console.WriteLine("Emoji-based Anime Series Recommendation");

            string confirmIdentity;

            string[] identities = { "[1]Admin", "[2]User","[X]EXIT" };

           
                Console.Clear();
                Console.WriteLine("IDENTITY CONFIRMATION");
                foreach (string identity in identities)
                {
                    Console.WriteLine(identity);
                }

                    confirmIdentity = User.GetInput("Choose Identity : ");
                    Console.Clear();
                if (confirmIdentity.Equals("1") || confirmIdentity == "ADMIN")
                {
                    Admin admin = new Admin();
                    admin.ShowAdminMenu();
                 
                }

                else if (confirmIdentity.Equals("2") || confirmIdentity == "USER")
                {
                    User user = new User();
                    user.RunAsUser();
                
                }
                else if (confirmIdentity.Equals("X") || confirmIdentity == "EXIT")
                {
                    Console.WriteLine("Bye, Mr./Miss Unknown!");
                    Environment.Exit(0);
                    
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
