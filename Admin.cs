using EBAR_BL;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Emoji_Based_Anime_Recommender
{
    public class Admin 
    {


        public void ShowAdminMenu()
        {
            string[] updateAnimeSeriesList = {"[1]Add", "[2]Delete","[H]HOME","[X]EXIT"};

            

            while (true)
            {
                Console.WriteLine("ADMIN MENU :");
                foreach (var updateList in updateAnimeSeriesList)
                {
                    Console.WriteLine(updateList);
                }
                string adminInput = User.GetUserInput();

                if (adminInput.Equals("1") || adminInput == "add")
                {
                    Console.WriteLine("SELECT EMOJI to ADD on the list : ");
                    User.DisplayEmoji();
                   
                    
                   
                    EBARProcess eBARProcess = new EBARProcess();
                    eBARProcess.SelectedEmojiToAdd();
                    
               
                }

                else if (adminInput.Equals("2") || adminInput == "delete")
                {
                    Console.WriteLine("SELECT EMOJI to DELETE on the list: ");
                    User.DisplayEmoji();

                    
                    EBARProcess eBARProcess = new EBARProcess();
                    eBARProcess.RemoveAnimeToEmojiList();

                    break;
                }

                else if (adminInput.Equals("h")|| adminInput == "home") 
                {
                    return; // uses return >> babalik sa MainMenu() or babalik sa previous method na nagcall kay ShowAdminMenu()

                }
                else if (adminInput == "x" || adminInput == "exit") 
                {
                    Console.WriteLine("Bye Admin! <3");
                    Environment.Exit(0);
                    break;
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
