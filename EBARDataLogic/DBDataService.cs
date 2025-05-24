using EBARCommon;
using Microsoft.Data.Sql;
using Microsoft.Data.SqlClient;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Intrinsics.X86;
using System.Text;
using System.Threading.Tasks;

namespace EBARDataLogic
{
    class DBDataService : IAnimeListDataService
    {
        static string connectionString = "Data Source=DESKTOP-I2KC1NQ\\SQLEXPRESS;Initial Catalog=AnimeList;Integrated Security=true;TrustServerCertificate=true; ";
        static SqlConnection sqlConnection;
        private static readonly List<AnimeList> animeList = new List<AnimeList>();

        public DBDataService()
        {
            sqlConnection = new SqlConnection(connectionString);
            //sqlConnection.Open();
        }
        public void AddAnimeBasedOnEmoji(string emoji, string anime)
        {
            var insertStatement = "INSERT INTO tbl_Emojis VALUES(@LikeEmoji,@HeartEmoji,@LaughEmoji,@WowEmoji,@SadEmoji,@AngryEmoji)";
            SqlCommand insertCommand = new SqlCommand(insertStatement,sqlConnection);

            //having errors on this one
            //var list = animeList[0];
            //insertCommand.Parameters.AddWithValue("@LikeEmoji",list.LikeEmoji);
        }

        public string GetRandomAnimeFromAllEmojis()
        {
            throw new NotImplementedException();
        }

        public void RemoveAnimeBasedOnEmoji(string emoji, string anime)
        {
            throw new NotImplementedException();
        }

        public List<string> ViewAnimeList(string emoji)
        {
            throw new NotImplementedException();
        }
    }
}
