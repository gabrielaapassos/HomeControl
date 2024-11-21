using Microsoft.Data.Sqlite;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Database

{
    public class createDataBase
    {
        private readonly SqliteConnection _connection;
        public createDataBase()
        {
            _connection = new SqliteConnection("Data Source=utfpr_poo.db;");
        }
        public bool CreateTableItem(string tableName)
        {
            string commandText = @"
                CREATE TABLE IF NOT EXISTS tb_usuario(
                    id int primary key autoincrement,
                    Nome varchar(100) NOT NULL,
                    Quantidade int not null,
                    Validade varchar(20) not null,
                    Categoria int foreing key not null
                )    
            ";//tem que ajeitar o foreing key
            using (var _command = new SqliteCommand(commandText, _connection))
            {
                _command.Parameters.AddWithValue("@tableName", tableName);
                int count = Convert.ToInt16(_command.ExecuteScalar());
                return count > 0;
            }
        }

        public bool IsTableExists(string TableName)
        {
            string commandText = "SELECT count(*) FROM sqlite_master WHERE type = 'table' AND name=@tableName";
            using (var _command = new SqliteCommand(commandText, _connection))
            {
                _command.Parameters.AddWithValue("@tableName", TableName);
                int count = Convert.ToInt16(_command.ExecuteScalar());
                return count > 0;
            }
        }
    }
}
