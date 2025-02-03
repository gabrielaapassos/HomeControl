using System.ComponentModel.DataAnnotations.Schema;
using System.ComponentModel.DataAnnotations;

namespace Models.Items;
public class ItemEstoque
{
    [Key]
    public int Id { get; set; }
    public string Nome { get; set; }
    public int Quantidade { get; set; }
    public DateTime? Validade { get; set; }
    [ForeignKey("IdCategoria")]
    public Categoria Categoria { get; set; }
    public int IdCategoria { get; set; } 
    public DateTime DataAdicao { get; set; }
    public String UnidadeMedida { get; set; }

    public override string ToString()
    {
        return $"{Id},{Nome}, {Quantidade}, {Validade}, {Categoria}, {DataAdicao}, {UnidadeMedida}";
    }
}