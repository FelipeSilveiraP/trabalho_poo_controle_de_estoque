namespace trabalho_poo.Models;

// Classe Abstrata (modelo que não vira objeto)
public abstract class Alerta
{
    public Produto? ProdutoReferencia { get; set; }
    public string Mensagem { get; set; } = string.Empty;

    // Metodo abstrato (Ação obrigatória sem lógica)
    public abstract string Exibir();
}
