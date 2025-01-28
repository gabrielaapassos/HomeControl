using System.ComponentModel.DataAnnotations.Schema;

namespace Models.Items;

public class Categoria
{
    [key]
    public int Id { get; private set; }
    public string Nome { get; set; }
    public string Descricao { get; set; }

    public override string ToString()
    {
        return $"{Id}{Nome}{Descricao}";
    }
}
