﻿using EBAR_BL;
using EBARDataLogic;
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
            
            

            while (userInput != "X")
            {
                List<string> emojiList = eBARProcess.GetEmojiList(userInput);

                
                switch (userInput)
                {            
                    case "A":
                        Console.WriteLine("");
                        DisplayAnimeSeriesList("                            \r\n             " +
                                    "HJJI           \r\n             " +
                                    "JJJJI          \r\n             " +
                                    "IJJJJ          \r\n            " +
                                    "IJJJJJ          \r\n    " +
                            "HHHH   JJJJJJJJJJJJJH   \r\n   " +
                            "JJJJJJ JJJJJJJJJJJJJJJ   \r\n   " +
                            "JJJJJJEJJJJJJJJJJJJJJJ   \r\n   " +
                            "JJJJJJEKJJJJJJJJJJJJJI   \r\n   " +
                            "JJJJJJEJJJJJJJJJJJJJJI   \r\n   " +
                            "JJJJJJFJJJJJJJJJJJJI     \r\n   " +
                            "JJJJJJ IJJJJJJJJJJJI     \r\n   " +
                            "JJJJKJ                   \r\n                            ", emojiList);
                        break;
                    case "B":
                        DisplayAnimeSeriesList("                                                    " +
                            "\r\n                                                   " +
                            " \r\n                                                    " +
                            "\r\n                                                    " +
                            "\r\n                                                    " +
                            "\r\n                                                    " +
                            "\r\n            ILNNOOOONMKH     HKMNNNOOONL            " +
                            "\r\n          JNPPQQRRRRQPPOLI ILOPQQRRRRRQPONI         " +
                            "\r\n         LNPQRSSTTTTSRRQPNLNPQRSSTTTTTSRQPNL        " +
                            "\r\n        LNPQRSTUVUUUUTSRRRQQRRSTUUUUUUTSQQONK       " +
                            "\r\n        NNOQRSTUUUUUUTTTSSSSSSTUUUUUUUTSRQONN       " +
                            "\r\n        NNOPRRSSTTTTTTTTSSSSTTTTTTTTTTSSRPONO       " +
                            "\r\n        MMMOPRRRSSSSSSSSSRRRSSSSSSSSSRRQPONMM       " +
                            "\r\n        LLMNOPQQRRQQRRRRRQQQRRRRRRRRRQQPONLLL       " +
                            "\r\n         KLMNNOPPPPPPPPPPPPPQPPQPPPPPPONMMLK        " +
                            "\r\n          KKLMMNOOOOOOOOOOOOOOOOOOOOONMMLLK         " +
                            "\r\n           KKLLMMNNNNNNNNNNNNNNNNNNNMMLKKK          " +
                            "\r\n            JJKKLMMMMMMMMNNNNNMMMMMMLKKJJ           " +
                            "\r\n             IJJKLLLLLMMMMMMMMMMMLLKKJJJ            " +
                            "\r\n               JJJJKKLLLLLLLLLLLLKJJJJH             " +
                            "\r\n                IJJJJKKKKKKLKKKKJJJII               " +
                            "\r\n                  HJJJJJKKKKKJJJIIH                 " +
                            "\r\n                     JIIJJJJJIJI                    " +
                            "\r\n                       IIIIIIHGG                    " +
                            "\r\n                           G                        " +
                            "\r\n                                                   " +
                            " \r\n                                                    ", emojiList);
                        break;
                    case "C":
                        DisplayAnimeSeriesList("                                                                     " +
                            "\r\n                                                                     " +
                            "\r\n                                                                     " +
                            "\r\n                              @%%%%%%%%%%%%%%                        " +
                            "\r\n                           %%%%%############%%%%%                    " +
                            "\r\n                        @%%%##****************###%%@                 " +
                            "\r\n                       %%##**********************##%%                " +
                            "\r\n                    %%%##**************************##%%              " +
                            "\r\n                   %%##******************************###             " +
                            "\r\n                  %%#**********************************##            " +
                            "\r\n                 %%#**##%%%###***************####%%%##**##           " +
                            "\r\n                 %##***###%%%%%%##********##%%@%%%###****#           " +
                            "\r\n                %##********##%%@@###****##%@@%%##********##          " +
                            "\r\n               @%##****###%%%%%%%%##****#%%%%%@%%%###****##%         " +
                            "\r\n               @%##**##%%%%%###**************###%%%%%#***###         " +
                            "\r\n               @%##***####************************####***###         " +
                            "\r\n               @%##***######********************######***##%         " +
                            "\r\n                %###*##%%##########################%%#**###%         " +
                            "\r\n                %%#####%%#************************#%%######%         " +
                            "\r\n                 %######%%%##******************##%%%######%          " +
                            "\r\n                 %%######%%@%%%%%%#######%%%%%%%@%%######%%          " +
                            "\r\n                  %%#######%%@@@@@@@@@@@@@@@@@@%%#######%%           " +
                            "\r\n                    %########%%%@@@@@@@@@@@@%%%#######%%             " +
                            "\r\n                      %##########%%%%%%%%%%##########%               " +
                            "\r\n                        %##########################%                 " +
                            "\r\n                          %%%####################                    " +
                            "\r\n                            %%%%%%%######%%%                         " +
                            "\r\n                                                                     " +
                            "\r\n                                                                     ", emojiList);
                        break;
                    case "D":
                        DisplayAnimeSeriesList("                                                                     " +
                            "\r\n                                                                     " +
                            "\r\n                                                                     " +
                            "\r\n                                                                     " +
                            "\r\n                                                                     " +
                            "\r\n                                                                     " +
                            "\r\n                                                                     " +
                            "\r\n                                  %#############                     " +
                            "\r\n                              %%#****************##                  " +
                            "\r\n                            %##********************##                " +
                            "\r\n                           %#************************##              " +
                            "\r\n                         @%#***************************#             " +
                            "\r\n                         %#*****##%%#*********#%%#*****##            " +
                            "\r\n                        %#******%%@@@#*******%%@@%#*****##           " +
                            "\r\n                        %#******%%@@%#*******#%@%%#*****##%          " +
                            "\r\n                       @%#*******####*********####******##%          " +
                            "\r\n                       @%#******************************##%          " +
                            "\r\n                        %##************#####************##%          " +
                            "\r\n                        %%###********#%@@@@@%#*********##%@          " +
                            "\r\n                         %######****#%@@@@@@@%#****#####%%           " +
                            "\r\n                           ##########%@@@@@@@%#########%%            " +
                            "\r\n                            #########%%%@@@%%#########%@             " +
                            "\r\n                              ##########%%##########%%               " +
                            "\r\n                                #################%%%                 " +
                            "\r\n                                  %%%%%####%%%%%%                    ", emojiList);
                        break;
                    case "E":
                        DisplayAnimeSeriesList("                                                                     " +
                            "\r\n                                                                     " +
                            "\r\n                                   %%%######%%                       " +
                            "\r\n                               %%##************##                    " +
                            "\r\n                             %#********************#                 " +
                            "\r\n                           %#************************#               " +
                            "\r\n                         %%#********++++++++*+*********              " +
                            "\r\n                        %#****####**+++++++++**#####****             " +
                            "\r\n                       %%#**###****++++++++++++****###***            " +
                            "\r\n                       %#**#*******++++++++++++**********#           " +
                            "\r\n                       %#*******###**++++++++*####*******#           " +
                            "\r\n                      %%#******#%%%%#*++++++*#%%@@#******##          " +
                            "\r\n                       ##******#%%%%****+++**#%%%%#******#           " +
                            "\r\n                       %#*******###***********####******##           " +
                            "\r\n                        %#***###************************##           " +
                            "\r\n                        %%#*##*##****#%%@@%%#**********##            " +
                            "\r\n                         %%###*#####%@@%%%%@@%#******###             " +
                            "\r\n                           %##########******###**#*###               " +
                            "\r\n                            ########***#**#########%                 " +
                            "\r\n                             ###%%###############                    " +
                            "\r\n                                   %%%%%%%%%%%                       " +
                            "\r\n                                                                     " +
                            "\r\n                                                                     ", emojiList);
                        break;
                    case "F":
                        DisplayAnimeSeriesList("                           @@@                        " +
                            "\r\n                                   %%#############%                  " +
                            "\r\n                                %###***************###               " +
                            "\r\n                              %##*********************#              " +
                            "\r\n                            %%#***********+*************#            " +
                            "\r\n                           %#*********+++++++++++*********           " +
                            "\r\n                          %#*********++++++++++++**********#         " +
                            "\r\n                          #*********++++++++++++++*********#%        " +
                            "\r\n                         %#*********+++****+***++***********#        " +
                            "\r\n                         #******###*****##***##****###******##       " +
                            "\r\n                        %#*******##%%%###****####%%##*******##       " +
                            "\r\n                        %#********#%%%%#******#%%%@%#*******##       " +
                            "\r\n                         ##*******#%%%%#*******%%%%%********##       " +
                            "\r\n                         %#********####*********###********##%       " +
                            "\r\n                          ##*******************************#%        " +
                            "\r\n                           #*********##%%%@@@%%##*********#%         " +
                            "\r\n                            ##******#%%########%%##*****##%          " +
                            "\r\n                              ###********************####%           " +
                            "\r\n                                #######*******#*#######              " +
                            "\r\n                                 ####################                " +
                            "\r\n                                    %%%%#######%%%                   " +
                            "\r\n                                         @@@@                        ", emojiList);
                        break;
                    case "G":
                        Console.WriteLine("Random Anime : ");
                        Console.WriteLine(eBARProcess.GetRandomAnimeFromAllEmojis());
                        break;
                    case "H":
                        return; // return to MainMenu() or the previous method na nagcall kay RunAsUser();
                    default:
                        Console.WriteLine("Please enter the existing letters only");
                        break;
                }

               

                DisplayEmoji();
                userInput = GetInput("Choose Emoji : ");
            }

         
            if (userInput == "X")
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
            string userInput = Console.ReadLine().ToUpper().Trim();

            return userInput;
        }
    }
}
