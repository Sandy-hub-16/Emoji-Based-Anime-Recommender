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
    
        public DBDataService()
        {
            sqlConnection = new SqlConnection(connectionString);
            //sqlConnection.Open();
        }
        private string GetTableName(string emoji)
        {
            switch (emoji)
            {
                case "A": return "tbl_LikeEmoji";
                case "B": return "tbl_HeartEmoji";
                case "C": return "tbl_LaughEmoji";
                case "D": return "tbl_WowEmoji";
                case "E": return "tbl_SadEmoji";
                case "F": return "tbl_AngryEmoji";
                default: return null;
            }
      
        }

        public void AddAnimeBasedOnEmoji(string emoji, string anime)
        {
            string tbl_Name = GetTableName(emoji);
            
                var insertStatement = $"INSERT INTO {tbl_Name} VALUES(@Anime)";
                SqlCommand insertCommand = new SqlCommand(insertStatement, sqlConnection);

                insertCommand.Parameters.AddWithValue("@Anime", anime);

                sqlConnection.Open();
                insertCommand.ExecuteNonQuery();
                sqlConnection.Close();
            
        }
        public void RemoveAnimeBasedOnEmoji(string emoji, string anime)
        {
            string tbl_Name = GetTableName(emoji);

            var deleteStatement = $"DELETE FROM {tbl_Name} WHERE Anime = @Anime";
            SqlCommand deleteCommand = new SqlCommand(deleteStatement, sqlConnection);

            deleteCommand.Parameters.AddWithValue("@Anime", anime);

            sqlConnection.Open();
            deleteCommand.ExecuteNonQuery();
            sqlConnection.Close();
        }

        public List<string> ViewAnimeList(string emoji)
        {
            string tbl_Name = GetTableName(emoji);
            var selectStatement = $"SELECT Anime FROM {tbl_Name}";
            SqlCommand selectCommand = new SqlCommand(selectStatement, sqlConnection);
            sqlConnection.Open();
            SqlDataReader reader = selectCommand.ExecuteReader();
            List<string> animeList = new List<string>();
            while (reader.Read())
            {
                animeList.Add(reader["Anime"].ToString());
            }
            sqlConnection.Close();
            return animeList;
        } // getting errors when getting a random anime

        public string GetRandomAnimeFromAllEmojis()
        {
            var tbl_Names = new List<string> 
            { 
                "tbl_LikeEmoji",
                "tbl_HeartEmoji",
                "tbl_LaughEmoji",
                "tbl_WowEmoji",
                "tbl_SadEmoji",
                "tbl_AngryEmoji"
            };

            var allAnime = new List<string>();

            sqlConnection.Open();
            foreach (var tbl_Name in tbl_Names)
            {
                var selectStatement = $"SELECT Anime FROM {tbl_Name}";
                SqlCommand selectCommand = new SqlCommand(selectStatement, sqlConnection);
                SqlDataReader reader = selectCommand.ExecuteReader();

                while (reader.Read()) 
                {
                    allAnime.Add(reader["Anime"].ToString());
                }
                reader.Close();
            }
            sqlConnection.Close();

            Random random = new Random();
            int i = random.Next(allAnime.Count);
            return allAnime[i];
        }

        public List<AnimeList> GetAnimeList()
        {
            throw new NotImplementedException();
        } // For EBAR Desktop
    }
}
