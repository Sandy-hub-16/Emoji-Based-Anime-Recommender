using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Microsoft.OpenApi.Models;

namespace EBAR_WebApplication.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class EBARController : ControllerBase
    {
        EBAR_BL.EBARProcess ebarProcess = new EBAR_BL.EBARProcess();

   

        [HttpGet("View Anime List")]
        public List<string> ViewAnimeList(string emoji)
        {
            return ebarProcess.ViewAnimeList(emoji);
        }

        [HttpGet("Get Random Anime")]
        public string GetRandomAnimeFromAllEmojis()
        {
            return ebarProcess.GetRandomAnimeFromAllEmojis();
        }

        [HttpPost("Add Anime Based on Emoji")]

        public void AddAnimeBasedOnEmoji(string emoji, string anime)
        {
         
            ebarProcess.AddAnimeBasedOnEmoji(emoji, anime);
        }

        [HttpDelete("Remove Anime Based on Emoji")]
        
        public void RemoveAnimeBasedOnEmoji(string emoji, string anime)
        {
            ebarProcess.RemoveAnimeBasedOnEmoji(emoji, anime);
        }
    }
}
