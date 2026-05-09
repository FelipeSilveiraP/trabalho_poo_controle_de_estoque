namespace trabalho_poo.Models;

public class AlertaCritico : Alerta
{
    public override string Exibir()
    {
        return $"CRÍTICO: O estoque de {ProdutoReferencia?.Descricao} atingiu 10% ou menos da capacidade! Por favor, reponha urgentemente.";
    }
}
