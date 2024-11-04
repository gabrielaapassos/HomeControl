using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CreateDataBase

{
    public class CreateDataBase
    {
        private readonly SqliteConnection _connection;
        public CreateDataBase()
        {
            _connection = new SqliteConnection("Data Source=utfpr_poo.db;");


        }

        public void CreateTableItem(string tableName, string key, string value)
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
            using (var _command = new SqLiteCommand(commandText, _connection))
            {
                _command.Parameters.AddWithValue("@tableName", TableName);
                int count = Convert.ToInt16(_command.ExecuteScalar());
                return count > 0;
            }
        }

        public bool IsTableExists(string TableName)
        {
            string commandText = "SELECT count(*) FROM sqlite_master WHERE type = 'table' AND name=@tableName";
            using(var _command = new SqLiteCommand(commandText,_connection))
            {
                _command.Parameters.AddWithValue("@tableName", TableName);
                int count = Convert.ToInt16( _command.ExecuteScalar());
                return count > 0;
            }
        }
    }
}
