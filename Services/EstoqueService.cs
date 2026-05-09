using System;
using System.Collections.Generic;
using trabalho_poo.Models;

namespace trabalho_poo.Services;

public class EstoqueService
{
    // Armazenamento em memória dos produtos
    public List<Produto> Produtos { get; set; } = new List<Produto>();
    
    // Estado do usuário
    public bool IsLogado { get; set; } = false;
    public Usuario UsuarioLogado { get; set; } = new Usuario();

    // Controle de alertas críticos já reconhecidos (não repete popup)
    public HashSet<Guid> AlertasCriticosReconhecidos { get; set; } = new HashSet<Guid>();

    public EstoqueService()
    {
        // Produtos MOCK para testar as listagens de cara se necessário, 
        // mas vamos deixar vazio para o usuário cadastrar e ver a lógica.
    }
}
