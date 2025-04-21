using EBAR_BL;
using EBARDataLogic;
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
            string[] updateAnimeSeriesList = {"[1]Add", "[2]Delete", "[3]View Anime List", "[H]HOME","[X]EXIT"};

            

            while (true)
            {
                Console.WriteLine("----------------------------------");
                Console.WriteLine("ADMIN MENU :");
                foreach (var updateList in updateAnimeSeriesList)
                {
                    Console.WriteLine(updateList);
                }
                string adminInput = User.GetInput("Choose Options : ");

                if (adminInput.Equals("1") || adminInput == "ADD")
                {
                    Console.WriteLine("SELECT EMOJI to ADD on the list : ");
                    User.DisplayEmoji();
                   
                                              
                    SelectedEmojiToAdd();
                    
               
                }

                else if (adminInput.Equals("2") || adminInput == "DELETE")
                {
                    Console.WriteLine("SELECT EMOJI to DELETE on the list: ");
                    User.DisplayEmoji();



                    SelectedEmojiToRemove();

                    
                }
                else if (adminInput.Equals("3") || adminInput == "VIEW ANIME LIST")
                {
                    
                    User adminView = new User();
                    adminView.ViewEmojiBasedAnimeListInterface();

                
                }

                else if (adminInput.Equals("H")|| adminInput == "HOME") 
                {
                    return; // uses return >> babalik sa MainMenu() or babalik sa previous method na nagcall kay ShowAdminMenu()

                }
                else if (adminInput == "X" || adminInput == "EXIT") 
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

        public void UpdatedAnimeList(List<string> emojiType)
        {
            Console.WriteLine($"UPDATE LIST:");
            foreach (var anime in emojiType)
            {
                Console.WriteLine(anime);
            }
        }

        #region -- Add Function --

        public void SelectedEmojiToAdd()
        {

            while (true)
            {
                
                string adminInput = User.GetInput("Enter Emoji to Add : ");
                if (adminInput == "A" || adminInput == "LIKE" || adminInput == "LIKE EMOJI")
                    AddAnimeToEmojiListInterface(EmojiList.likeEmojis);

                else if (adminInput == "B" || adminInput == "HEART" || adminInput == "HEART EMOJI")
                    AddAnimeToEmojiListInterface(EmojiList.heartEmojis);

                else if (adminInput == "C" || adminInput == "laugh" || adminInput == "LAUGH EMOJI")
                    AddAnimeToEmojiListInterface(EmojiList.laughEmojis);

                else if (adminInput == "D" || adminInput == "wow" || adminInput == "WOW EMOJI")
                    AddAnimeToEmojiListInterface(EmojiList.wowEmojis);

                else if (adminInput == "E" || adminInput == "sad" || adminInput == "SAD EMOJI")
                    AddAnimeToEmojiListInterface(EmojiList.sadEmojis);

                else if (adminInput == "F" || adminInput == "angry" || adminInput == "ANGRY EMOJI")
                    AddAnimeToEmojiListInterface(EmojiList.angryEmojis);

                else
                {
                    Console.WriteLine("Invalid Input");
                }
                Console.WriteLine("----------------------------------");
                string input = User.GetInput("Type [B] to go back to Admin Menu OR Type any key to add another : ");

                if (input == "B" || input == "BACK")
                {
                    return;
                }

            }

        }
        public void AddAnimeToEmojiListInterface(List<string> emojiList)
        {
            Console.WriteLine("----------------------------------");
            string animeAdd = User.GetInput("Add Anime : ");
            Console.WriteLine(ValidateAddedAnime(animeAdd, emojiList));

        }
        public string ValidateAddedAnime(string anime, List<string> emojiType)
        {
            if (string.IsNullOrEmpty(anime))
            {
                return "Input cannot be empty...";
            }

            else if (emojiType.Contains(anime))
            {
                return $"Anime : {anime} already exists from the list";
            }

            emojiType.Add(anime);
            return $"{anime} added to the list.";

        }

        #endregion

        #region -- Remove Function --
        public void SelectedEmojiToRemove()
        {
            List<string> selectedEmojiList = null;
            while (true)
            {
                Console.WriteLine("----------------------------------");
                string adminInput = User.GetInput("Enter Emoji to Delete : ");


                if (adminInput == "A" || adminInput == "LIKE" || adminInput == "LIKE EMOJI")
                    selectedEmojiList = EmojiList.likeEmojis;

                else if (adminInput == "B" || adminInput == "HEART" || adminInput == "HEART EMOJI")
                    selectedEmojiList = EmojiList.heartEmojis;

                else if (adminInput == "C" || adminInput == "LAUGH" || adminInput == "LAUGH EMOJI")
                    selectedEmojiList = EmojiList.laughEmojis;

                else if (adminInput == "D" || adminInput == "WOW" || adminInput == "WOW EMOJI")
                    selectedEmojiList = EmojiList.wowEmojis;

                else if (adminInput == "E" || adminInput == "SAD" || adminInput == "SAD EMOJI")
                    selectedEmojiList = EmojiList.sadEmojis;

                else if (adminInput == "F" || adminInput == "ANGRY" || adminInput == "ANGRY EMOJI")
                    selectedEmojiList = EmojiList.angryEmojis;

                else
                {
                    Console.WriteLine("Invalid Input");
                    continue; // skips the next line of codes and go back to the top of the loop -> "Enter Emoji to Remove : "
                }
                Console.WriteLine("----------------------------------");
                Console.WriteLine("Current Anime List : ");
                foreach (var animeList in selectedEmojiList)
                {
                    Console.WriteLine(animeList);
                }

                RemoveAnimeToEmojiListInterface(selectedEmojiList);
                Console.WriteLine("----------------------------------");
                string continueOrNotInput = User.GetInput("Type [B] to go back to Admin Menu or type any key to delete another anime : ");

                if (continueOrNotInput == "B")
                {
                    return;
                }
            }

        }

        public void RemoveAnimeToEmojiListInterface(List<string> selectedEmojiList)
        {
            Console.WriteLine("----------------------------------");
            string animeRemove = User.GetInput("Delete Anime : ");
            Console.WriteLine(ValidateRemovedAnime(animeRemove, selectedEmojiList));
        }

        public string ValidateRemovedAnime(string animeInput, List<string> emojiList)
        {
       
            if (string.IsNullOrEmpty(animeInput))
            {
                return "Input cannot be empty...";
            }

            else if (!emojiList.Contains(animeInput))
            {

                return $"Anime : {animeInput} doesn't exist from the list";
            }

            emojiList.Remove(animeInput);

            return $"Anime : {animeInput} has been removed to the list";


            
        }

        #endregion






    }
}
