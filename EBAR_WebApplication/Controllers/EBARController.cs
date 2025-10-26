using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Microsoft.OpenApi.Models;

namespace EBAR_WebApplication.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class EBARController : ControllerBase
    {
        private readonly EBAR_BL.EBARProcess _ebarProcess;

        public EBARController(EBAR_BL.EBARProcess ebarProcess)
        {
            _ebarProcess = ebarProcess;
        }



        [HttpGet("View Anime List")]
        public List<string> ViewAnimeList(string emoji)
        {
            return _ebarProcess.ViewAnimeList(emoji);
        }

        [HttpGet("Get Random Anime")]
        public string GetRandomAnimeFromAllEmojis()
        {
            return _ebarProcess.GetRandomAnimeFromAllEmojis();
        }

        [HttpPost("Add Anime Based on Emoji")]

        public void AddAnimeBasedOnEmoji(string emoji, string anime)
        {
         
            _ebarProcess.AddAnimeBasedOnEmoji(emoji, anime);
        }

        [HttpDelete("Remove Anime Based on Emoji")]
        
        public void RemoveAnimeBasedOnEmoji(string emoji, string anime)
        {
            _ebarProcess.RemoveAnimeBasedOnEmoji(emoji, anime);
        }
    }
}
