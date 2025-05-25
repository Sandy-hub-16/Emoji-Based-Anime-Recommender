using EBAR_BL;
using EBARDataLogic;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Linq;

namespace Emoji_Based_Anime_Recommender
{
    // Inheritance => ":" also means "extends" in java(":" == inherits), EBARProcess => Parent
    // Admin class can now use the methods in EBARProcess class without instantiating

    // *for practice purpose*
    public class Admin : EBARProcess  
    {
        AnimeListDataService animeListDataService = new AnimeListDataService();

        public void ShowAdminMenu()
        {
            string[] menuOptions = {"[1]Add", "[2]Delete", "[3]View Anime List", "[4]HOME","[5]EXIT"};
            string adminInput;
            string emojiInput;
            string animeInput;
            

            while (true)
            {
                Console.Clear();
                Console.WriteLine("ADMIN MENU :");
                foreach (var menu in menuOptions)
                {
                    Console.WriteLine(menu);
                }
                adminInput = User.GetInput("Choose Options : "); ;

                if (int.TryParse(adminInput, out int choice))
                {
                    if (choice == (int)AdminActions.Add)
                    {
                        Console.Clear();
                        User.emojis.Remove("[G]RANDOM");
                      
                        Console.WriteLine("--ADD MENU--");
                        User.DisplayEmoji();
                        emojiInput = User.GetInput("SELECT EMOJI :");

                        if (CheckReturntoMenu(emojiInput))
                        {
                            Console.WriteLine("Returning to Main Menu");
                            return;
                        }


                        animeInput = User.GetInput("Add : ");


                        animeListDataService.AddAnimeBasedOnEmoji(emojiInput, animeInput);

                        Console.WriteLine($"{animeInput} added on the list...");
                        Console.WriteLine("Going back to Admin Menu...");
                        Thread.Sleep(1000);
                        Console.Clear();



                    }

                    else if (choice == (int)AdminActions.Delete)
                    {
                        Console.Clear();
                        Console.WriteLine("--REMOVE MENU--");
                        User.emojis.Remove("[G]RANDOM");
           
                        User.DisplayEmoji();

                        emojiInput = User.GetInput("SELECT EMOJI :");

                        if (CheckReturntoMenu(emojiInput))
                        {
                            Console.WriteLine("Returning to Main Menu");
                            return;
                        }


                        animeInput = User.GetInput("Remove : ");

                        animeListDataService.RemoveAnimeBasedOnEmoji(emojiInput, animeInput);

                        Console.WriteLine($"{animeInput} removed on the list...");
                        Console.WriteLine("Going back to Admin Menu...");
                        Thread.Sleep(1000);
                        Console.Clear();


                    }
                    else if (choice ==  (int)AdminActions.ViewAnimeList)
                    {
                        Console.Clear();
                        User adminView = new User();
                        adminView.ViewEmojiBasedAnimeListInterface();


                    }

                    else if (choice == (int)AdminActions.Home)
                    {
                        Console.Write("Returning to Admin Menu...");
                        Thread.Sleep(1000);
                        return; // uses return >> babalik sa AdminMenu() or babalik sa previous method na nagcall kay ShowAdminMenu()

                    }
                    else if (choice == (int)AdminActions.Exit)
                    {
                        Console.WriteLine("Bye Admin! <3");
                        Environment.Exit(0);

                    }
                  
                }
          
            }

        }









    }
}
