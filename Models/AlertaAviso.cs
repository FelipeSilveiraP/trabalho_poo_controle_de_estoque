namespace trabalho_poo.Models;

public class AlertaAviso : Alerta
{
    public override string Exibir()
    {
        return $"AVISO: Seu estoque de {ProdutoReferencia?.Descricao} está abaixo do nível (40%). Entre em contato com seu fornecedor e reponha o estoque.";
    }

    
}
