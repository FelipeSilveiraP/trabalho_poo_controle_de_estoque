using System;
using System.Collections.Generic;
using System.Linq;

namespace trabalho_poo.Models;

public class Produto
{
    public Guid Id { get; set; } = Guid.NewGuid();
    public string Descricao { get; set; } = string.Empty;
    public string Tipo { get; set; } = string.Empty;
    public string UltimoFornecedor { get; set; } = string.Empty;
    public string UltimoFornecedorCNPJ { get; set; } = string.Empty;
    
    public int Quantidade { get; set; }
    public int TetoPermitido { get; set; }
    
    public decimal CustoMedioAtual { get; set; }
    
    public List<Operacao> HistoricoOperacoes { get; set; } = new List<Operacao>();

    public decimal ValorTotalEstoque => Quantidade * CustoMedioAtual;

    public Produto() { }

    // Calcular Custo Medio based on past operations
    public void CalcularCustoMedio()
    {
        var compras = HistoricoOperacoes.OfType<Compra>().ToList();
        if (compras.Count == 0)
        {
            CustoMedioAtual = 0;
            return;
        }

        decimal valorTotalCompras = compras.Sum(c => c.ValorTotal);
        int qtdTotalCompras = compras.Sum(c => c.Quantidade);

        if (qtdTotalCompras > 0)
        {
            CustoMedioAtual = valorTotalCompras / qtdTotalCompras;
        }
    }

    public string ValidarEstoque()
    {
        if (TetoPermitido == 0) return "NORMAL";
        
        double percentual = (double)Quantidade / TetoPermitido;
        
        if (percentual <= 0.10) return "CRITICO";
        if (percentual <= 0.40) return "AVISO";
        
        return "NORMAL";
    }

    // Método Virtual (Instanciação de novo Produto na lista)
    public virtual void Salvar(List<Produto> bancoDeDados)
    {
        bancoDeDados.Add(this);
    }
}
