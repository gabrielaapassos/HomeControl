namespace Models.Items
{
    public class Inventario
    {
        public int Id { get; set; }
        public Usuario Usuario { get; set; }
        public List<ItemEstoque> Itens { get; set; }

        public Inventario(int id, Usuario usuario)
        {
            Id = id;
            Usuario = usuario;
            Itens = new List<ItemEstoque>();
        }
    }
}