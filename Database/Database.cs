using Microsoft.Data.Sqlite;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using CreateDataBase;
using Models.models;

namespace Database
{
    public class Database
    {
        private readonly SqliteConnection _connection;
        public Database() {
            _connection = new SqliteConnection("Data Source=utfpr_poo.db;");
            var DatabaseCreate = new createDataBase();
            if (DatabaseCreate.IsTableExists("tb_item")){
                DatabaseCreate.CreateTableItem("tb_item");
            }

            
        }

        public void Create(Item item){

            string commandText = @"
                INSERT INTO tb_item(nome,quantidade,validade,categoria)
                VALUES(@nome,@quantidade,@validade,@categoria)
            ";
            using (var _command = new SqliteCommand(commandText, _connection))
            {
                _command.Parameters.AddWithValue("@nome", item.Nome);
                _command.Parameters.AddWithValue("@quantidade", item.Quantidade);
                _command.Parameters.AddWithValue("@validade", item.Validade);
                _command.Parameters.AddWithValue("@categoria", item.Categoria);
            }
            _connection.Open();
            _connection.Close();
        }
    }
}
