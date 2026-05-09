namespace trabalho_poo.Models;

public class Usuario
{
    public string Username { get; set; } = string.Empty;
    public string Senha { get; set; } = string.Empty;

    // Método EfetuarLogin
    public bool EfetuarLogin(string usernameInput, string senhaInput)
    {
        return usernameInput == "admin" && senhaInput == "admin";
    }
}
