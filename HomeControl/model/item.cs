namespace HomeControl.model;
public class Item
    {
    public int Id {get; set;}
    public string Nome {get; set;}
    public string Quantidade {get; set;}
    public string Validade {get; set;}
    public Categoria Categoria {get; set;}

        public Item(int id, string nome, string quantidade, string validade, Categoria categoria)
        {
            Id = id;
            Nome = nome;
            Quantidade = quantidade;
            Validade = validade;
            Categoria = categoria;
        }
    }
}