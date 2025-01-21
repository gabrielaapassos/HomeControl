namespace Models.models
{
    public class Inventario
    {
        public int Id { get; set; }
        public Usuario Usuario { get; set; }
        public List<Item> Itens { get; set; }

        public Inventario(int id, Usuario usuario)
        {
            Id = id;
            Usuario = usuario;
            Itens = new List<Item>();
        }
    }
}