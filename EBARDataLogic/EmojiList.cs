﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EBARDataLogic
{
    public static class EmojiList
    {
        // class made static >> kasi pag iniinstantiate sa ibang class narireset ung list (nabalik sa default na list) ->
        //                   >> d nauupdate yung list
            public static List<string> likeEmojis = new List<string> { "One Piece", "Naruto", "DragonBall" };
            public static List<string> heartEmojis = new List<string> { "Kimi Ni Todoke", "Kaguya-sama: Love Is War", "Fruits Basket" };
            public static List<string> laughEmojis = new List<string> { "Mashle: Magic And Muscles", "Dandadan", "KonoSuba" };
            public static List<string> wowEmojis = new List<string> { "Solo Leveling", "Frieren: Beyond Journey's End", "Jujutsu Kaisen" };
            public static List<string> sadEmojis = new List<string> { "A Silent Voice", "Your Lie in April", "Anohana: The Flower We Saw That Day" };
            public static List<string> angryEmojis = new List<string> { "Attack on Titan", "One Punch Man", "Vinland Saga" };

    }

    
}
