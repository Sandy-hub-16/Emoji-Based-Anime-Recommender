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
        public void RunAsUser()
        {
            string userName;

            do
            {
                Console.Write("Enter Username : ");
                userName = Console.ReadLine();

                if (EBARProcess.ValidateEmptyUserName(userName))
                {
                    Console.WriteLine("Username cannot be empty. Please Try Again.");
                }
            } while (string.IsNullOrWhiteSpace(userName));

            Console.WriteLine($"Konnichiwa, {userName}!, How are you feeling today?");

            DisplayEmoji();



            string userInput = GetUserInput();
            

            while (userInput != "x".ToLower())
            {
                switch (userInput.ToLower())
                {
                    case "a":
                        DisplayAnimeSeriesList("LIKE",AdminActions.likeEmojis);
                        break;
                    case "b":
                        DisplayAnimeSeriesList("HEART", AdminActions.heartEmojis);
                        break;
                    case "c":
                        DisplayAnimeSeriesList("LAUGH", AdminActions.laughEmojis);
                        break;
                    case "d":
                        DisplayAnimeSeriesList("WOW", AdminActions.wowEmojis);
                        break;
                    case "e":
                        DisplayAnimeSeriesList("LIKE", AdminActions.sadEmojis);
                        break;
                    case "f":
                        DisplayAnimeSeriesList("LIKE", AdminActions.angryEmojis);
                        break;
                    case "g":
                        //SetAnimeSeriesList("Random", "Steins Gate", "Erased", "Black Clover");
                        break;
                    case "h":
                        Program.MainMenu();
                        break;

                    default:
                        Console.WriteLine("Please enter the existing letters only");
                        break;
                }

                DisplayEmoji();
                userInput = GetUserInput();



                if (userInput == "x".ToLower())
                {
                    Console.WriteLine("Goodbye! See you in the next episode!");
                    break;
                }


            }
        }

        public static void DisplayAnimeSeriesList(string emojiType, List<string> animeList) // static >> no need to instantiate
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

        public static string GetUserInput()
        {
            Console.Write("Input : ");
            string userInput = Console.ReadLine();

            return userInput;
        }
    }
}
