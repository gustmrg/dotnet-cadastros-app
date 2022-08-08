using System.ComponentModel.DataAnnotations;

namespace Cadastros.Web.Models;

public class Cliente
{
    public int Id { get; set; }
    
    [Required, StringLength(100), Display(Name = "Nome Completo")]
    public string NomeCompleto { get; set; }
    
    [Required, StringLength(40)]
    [EmailAddress]
    public string Email { get; set; }
    
    [Required, StringLength(13)]
    public string Telefone { get; set; }
    
    [DataType(DataType.Date), Display(Name = "Data de Cadastro")]
    public DateTime DataCadastro { get; set; }

    public List<Contato> Contatos { get; set; } = new();
}