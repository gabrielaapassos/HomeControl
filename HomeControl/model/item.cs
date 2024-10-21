namespace HomeControl.model;
public class Item{
    public string Id {get; set;}
    public string Nome {get; set;}
    public string Quantidade {get; set;}
    public string Validade {get; set;}
    public string Categoria {get; set;}

    public override string ToString()
    {
        return $"{Nome}, {Quantidade}, {Validade}, {Categoria}";
    }
}