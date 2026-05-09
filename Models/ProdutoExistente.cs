using System.Collections.Generic;
using System.Linq;

namespace trabalho_poo.Models;

public class ProdutoExistente : Produto
{
    // Sobrescrita de Metodos (Override)
    public override void Salvar(List<Produto> bancoDeDados)
    {
        var produtoReal = bancoDeDados.FirstOrDefault(p => p.Id == this.Id);
        if (produtoReal != null)
        {
            // RN08: Caso o produto esteja em 100% da capacidade, não será permitido incluir mais compras para este.
            // Lógica tratada na tela, aqui apenas atualiza
            
            produtoReal.Quantidade += this.Quantidade;
            
            if (!string.IsNullOrEmpty(this.UltimoFornecedor))
            {
                produtoReal.UltimoFornecedor = this.UltimoFornecedor;
                produtoReal.UltimoFornecedorCNPJ = this.UltimoFornecedorCNPJ;
            }

            // Adiciona as operacoes feitas e recalcula custo medio
            foreach (var op in this.HistoricoOperacoes)
            {
                produtoReal.HistoricoOperacoes.Add(op);
            }
            
            produtoReal.CalcularCustoMedio();
        }
    }
}
