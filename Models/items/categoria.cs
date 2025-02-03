using System.ComponentModel.DataAnnotations;

namespace Models.Items;

public class Categoria
{
    [Key]
    public int Id { get; private set; }
    public string Nome { get; set; }
    public string Descricao { get; set; }

    public override string ToString()
    {
        return $"{Id}{Nome}{Descricao}";
    }
}