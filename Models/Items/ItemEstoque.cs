using System.ComponentModel.DataAnnotations.Schema;

namespace Models.Items;
[Table("tb_items")]
public class ItemEstoque
{
    [key]
    public int Id { get; set; }
    public string Nome { get; set; }
    public int Quantidade { get; set; }
    public DateTime? Validade { get; set; }
    public string? Categoria { get; set; }
    public DateTime DataAdicao { get; set; }
    public string UnidadeMedida { get; set; }

    public override string ToString()
    {
        return $"{Id},{Nome}, {Quantidade}, {Validade}, {Categoria}, {DataAdicao}, {UnidadeMedida}";
    }
}

internal class keyAttribute : Attribute
{
}