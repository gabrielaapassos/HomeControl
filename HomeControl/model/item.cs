namespace HomeControl.model;
public class Item
{
    public int Id { get; set; }
    public string Nome { get; set; }
    public int Quantidade { get; set; }
    public string Validade { get; set; }
    public Categoria? Categoria { get; set; }

    public Item(int id, string nome, int quantidade, string validade) //Categoria categoria)
    {
        Id = id;
        Nome = nome;
        Quantidade = quantidade;
        Validade = validade;
        //Categoria = categoria;
    }
    public override string ToString()
    {
        return $"{Id},{Nome}, {Quantidade}, {Validade}";
    }
}
