using EBAR_BL;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Emoji_Based_Anime_Recommender
{
    public class User
    {
        static string[] emojis = { "[A]Like",
                                   "[B]Heart",
                                   "[C]Laugh",
                                   "[D]Wow",
                                   "[E]Sad",
                                   "[F]Angry",
                                   "[G]RANDOM",
                                  
                                "\n[H] HOME",
                                "\n[X] EXIT"
                            };

        EBARProcess eBARProcess = new EBARProcess();
        public void RunAsUser()
        {
            string userName;
            
            do
            {
                Console.Write("Enter Username : ");
                userName = Console.ReadLine();
              
                if (eBARProcess.ValidateEmptyUserName(userName))
                {
                    Console.WriteLine("Username cannot be empty. Please Try Again.");
                }
            } while (string.IsNullOrWhiteSpace(userName));

            Console.WriteLine($"Konnichiwa, {userName}!, How are you feeling today?");

            DisplayEmoji();



            string userInput = GetInput("Choose Emoji : ");
            
            

            while (userInput != "x".ToLower())
            {
                List<string> emojiList = eBARProcess.GetEmojiList(userInput);

           
               
                switch (userInput.ToLower())
                {            
                    case "a":
                        DisplayAnimeSeriesList("LIKE",emojiList);
                        break;
                    case "b":
                        DisplayAnimeSeriesList("HEART", emojiList);
                        break;
                    case "c":
                        DisplayAnimeSeriesList("LAUGH", emojiList);
                        break;
                    case "d":
                        DisplayAnimeSeriesList("WOW", emojiList);
                        break;
                    case "e":
                        DisplayAnimeSeriesList("SAD", emojiList);
                        break;
                    case "f":
                        DisplayAnimeSeriesList("ANGRY", emojiList);
                        break;
                    case "g":
                        Console.WriteLine("Random Anime : ");
                        Console.WriteLine(eBARProcess.GetRandomAnimeFromAllEmojis());
                        break;
                    case "h":
                        return; // return to MainMenu() or the previous method na nagcall kay RunAsUser();
                    default:
                        Console.WriteLine("Please enter the existing letters only");
                        break;
                }

                DisplayEmoji();
                userInput = GetInput("Choose Emoji : ");


            }
            if (userInput == "x".ToLower())
            {
                Console.WriteLine("Goodbye! See you in the next episode!");              
                Environment.Exit(0);
            }
        }

        public void DisplayAnimeSeriesList(string emojiType, List<string> animeList) // static >> no need to instantiate
        {
            Console.WriteLine($"Anime Recommendation : {emojiType} EMOJI");

            foreach (var anime in animeList)
            {
                Console.WriteLine(anime);
            }

        }

        public static void DisplayEmoji()
        {

            Console.WriteLine("Emojis : ");
            foreach (string emoji in emojis)
            {
                Console.WriteLine(emoji);
            }
        }

        public static string GetInput(string typeofInput)
        {
            Console.Write($"{typeofInput}");
            string userInput = Console.ReadLine().ToLower().Trim();

            return userInput;
        }
    }
}
