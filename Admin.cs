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
    public class Admin 
    {

        EBARProcess eBARProcess = new EBARProcess();
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
                        Console.WriteLine("--ADD MENU--");
                        User.DisplayEmoji();
                        emojiInput = User.GetInput("SELECT EMOJI :");



                        do
                        {

                            animeInput = User.GetInput("Add : ");

                            if (eBARProcess.ValidateDuplicateInput(animeInput))
                            {
                                Console.WriteLine($"{animeInput} already added..");
                            }

                        } while (eBARProcess.ValidateDuplicateInput(animeInput));

                        eBARProcess.AddAnimeBasedOnEmoji(emojiInput, animeInput);
                        Console.WriteLine($"{animeInput} added on the list...");
                        Console.WriteLine("Going back to Admin Menu...");
                        Thread.Sleep(1000);
                        Console.Clear();



                    }

                    else if (choice == (int)AdminActions.Delete)
                    {
                        Console.Clear();
                        Console.WriteLine("--REMOVE MENU--");
                        User.DisplayEmoji();

                        emojiInput = User.GetInput("SELECT EMOJI :");

                        do
                        {
                            animeInput = User.GetInput("Remove : ");

                            if (!eBARProcess.ValidateDuplicateInput(animeInput))
                            {
                                Console.WriteLine($"{animeInput} doesn't exist from the selected list..");
                            }
                        } while (!eBARProcess.ValidateDuplicateInput(animeInput));

                        eBARProcess.RemoveAnimeBasedOnEmoji(emojiInput, animeInput);
                        Console.WriteLine($"{animeInput} removed on the list...");
                        Console.WriteLine("Going back to Admin Menu...");
                        Thread.Sleep(1000);
                        Console.Clear();



                    }
                    else if (choice ==  (int)AdminActions.ViewAnimeList)
                    {

                        User adminView = new User();
                        adminView.ViewEmojiBasedAnimeListInterface();


                    }

                    else if (choice == (int)AdminActions.Home)
                    {
                        return; // uses return >> babalik sa MainMenu() or babalik sa previous method na nagcall kay ShowAdminMenu()

                    }
                    else if (choice == (int)AdminActions.Exit)
                    {
                        Console.WriteLine("Bye Admin! <3");
                        Environment.Exit(0);

                    }
                    else if (string.IsNullOrWhiteSpace(adminInput))
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
}
