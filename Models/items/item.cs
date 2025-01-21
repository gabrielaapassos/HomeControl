using System.ComponentModel.DataAnnotations.Schema;

namespace Models.models;
[Table("tb_items")]
public class Item
{
    [key]
    public int Id { get; set; }
    public string Nome { get; set; }
    public int Quantidade { get; set; }
    public string Validade { get; set; }
    public Categoria? Categoria { get; set; }

    public override string ToString()
    {
        return $"{Id},{Nome}, {Quantidade}, {Validade}";
    }
}

internal class keyAttribute : Attribute
{
}