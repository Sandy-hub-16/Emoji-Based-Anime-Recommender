using EBARCommon;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EBARDataLogic
{
    public interface IAnimeListDataService
    {
        public void AddAnimeBasedOnEmoji(string emoji, string anime);
        public void RemoveAnimeBasedOnEmoji(string emoji, string anime);
        public List<string> ViewAnimeList(string emoji);

        public string GetRandomAnimeFromAllEmojis();



    }
}
