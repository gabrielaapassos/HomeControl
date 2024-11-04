using Microsoft.Data.Sqlite;

namespace Database
{
    public class Database
    {
        private readonly SqliteConnection _connection;
        public Database() {
            _connection = new SqliteConnection("Data Source=utfpr_poo.db;Version=3;");
            var DatabaseCreate = new CreateDataBase();
            if (DatabaseCreate.IsTableExists("tb_item"){ 
                DatabaseCreate.CreateTableItem
            }

            
        }

        public void Create(Item item){

            string commandText = @"
                INSERT INTO tb_item(nome,quantidade,validade,categoria)
                VALUES(@nome,@quantidade,@validade,@categoria)
            ";//tem que ajeitar o foreing key
            using (var _command = new SqLiteCommand(commandText, _connection))
            {
                _command.Parameters.AddWithValue("@nome", Nome);
                _command.Parameters.AddWithValue("@quantidade", quantidade);
                _command.Parameters.AddWithValue("@validade", validade);
                _command.Parameters.AddWithValue("@categoria", categoria);
            }
            _connection.Open();
            _connection.Close();
        }
    }
}
