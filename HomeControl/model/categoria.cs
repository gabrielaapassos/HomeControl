namespace HomeControl.model
{
    public class Categoria
    {
        public int Id { get; private set; }
        public string Nome { get; set; }
        public string Descricao { get; set; }
        public List<Item> Itens { get; private set; }

        public Categoria(int id, string nome, string descricao)
        {
            Id = id;
            Nome = nome;
            Descricao = descricao;
            Itens = new List<Item>();
        }
    }
}
