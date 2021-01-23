using System;
using System.Collections.Generic;
using System.Data.SQLite;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace skaki.lib
{
    class Game
    {
        private String black_player;
        private String white_player;

        public Game(string white_player,string black_player)
        {
            this.white_player = white_player;
            this.black_player = black_player;
        }

        public void saveToDB()
        {
            SQLiteConnection conn = new SQLiteConnection(Constants.connectionstring);
            conn.Open();
            SQLiteCommand sqlite_cmd;
            sqlite_cmd = conn.CreateCommand();
            string insertQuery = "Insert into chess_table (black_player,white_player) Values('" + black_player + "','" + white_player + "'  )";
            sqlite_cmd.CommandText = insertQuery;

            sqlite_cmd.ExecuteNonQuery();
            conn.Close();

        }
    }
}
