using System.ComponentModel.DataAnnotations;

namespace Cadastros.Web.Models;

public class Cliente
{
    public int Id { get; set; }
    
    [Required, StringLength(100)]
    public string NomeCompleto { get; set; }
    
    [Required, StringLength(40)]
    public string Email { get; set; }
    
    [Required, StringLength(13)]
    public string Telefone { get; set; }
    
    [DataType(DataType.Date)]
    public DateTime DataCadastro { get; set; }

    public List<Contato> Contatos { get; set; } = new();
}