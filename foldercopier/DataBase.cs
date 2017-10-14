using System;
using System.Collections.Generic;
using System.Data.SQLite;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace foldercopier
{
    class DataBase
    {
        private SQLiteConnection sqlConnection;
        public DataBase()
        {
            sqlConnection = new SQLiteConnection(@"Data Source=" + Properties.Settings.Default.db_file +  ";Version=3;");
            sqlConnection.Open();
        }

        public void add(FilePath item)
        {
            String sql = string.Format("INSERT INTO files (file,shard) VALUES ('{0}' , '{1}')", item.file, item.shard);
            SQLiteCommand command = new SQLiteCommand(sql, sqlConnection);
            command.ExecuteNonQuery();
            

        }

        public List<FileResult> getFiles(int shardNumber)
        {
            String sql = string.Format("SELECT * from files WHERE shard = '{0}' and done = 0 LIMIT 100", shardNumber);
            SQLiteCommand command = new SQLiteCommand(sql, sqlConnection);
            SQLiteDataReader reader = command.ExecuteReader();
            List<FileResult> fileResults = new List<FileResult>();
            while (reader.Read())
            {
                FileResult fileResult = new FileResult(reader["file"].ToString(), reader["id"].ToString());
                fileResults.Add(fileResult);
            }
            reader.Close();
            foreach (FileResult fileResult in fileResults)
            {
                String sqlUpdate = string.Format("update files set done = 1 where id = {0}", fileResult.id);
                SQLiteCommand command2 = new SQLiteCommand(sqlUpdate, sqlConnection);
                command2.ExecuteNonQuery();
            }
            
            return fileResults;
        }

        public String getDone()
        {
            String sql = "SELECT count(id) FROM files WHERE done =1";
            SQLiteCommand command = new SQLiteCommand(sql, sqlConnection);
            var reader = command.ExecuteScalar();
            return reader.ToString();
        }

        public string getError()
        {
            String sql = "SELECT count(id) FROM files WHERE error =1";
            SQLiteCommand command = new SQLiteCommand(sql, sqlConnection);
            var reader = command.ExecuteScalar();
            return reader.ToString();

        }

        internal static string GetStringSha256Hash(string text)
        {
            if (String.IsNullOrEmpty(text))
                return String.Empty;

            using (var sha = new System.Security.Cryptography.SHA256Managed())
            {
                byte[] textData = System.Text.Encoding.UTF8.GetBytes(text);
                byte[] hash = sha.ComputeHash(textData);
                return BitConverter.ToString(hash).Replace("-", String.Empty);
            }
        }
    }
}
