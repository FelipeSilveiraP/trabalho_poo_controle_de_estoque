using System;

namespace trabalho_poo.Models;

public class Operacao
{
    public Guid Id { get; set; } = Guid.NewGuid();
    public DateTime DataHora { get; set; } = DateTime.Now;
    public int Quantidade { get; set; }
    public decimal ValorUnitario { get; set; }
    
    public decimal ValorTotal => Quantidade * ValorUnitario;
}
