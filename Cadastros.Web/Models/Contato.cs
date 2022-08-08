using System.ComponentModel.DataAnnotations;

namespace Cadastros.Web.Models;

public class Contato
{
    public int Id { get; set; }
    
    [Required, StringLength(100)]
    public string NomeCompleto { get; set; }
    
    [Required, StringLength(40)]
    public string Email { get; set; }
    
    [Required, StringLength(13)]
    public string Telefone { get; set; }
    
    [Required]
    public int ClienteId { get; set; }

    public Cliente Cliente { get; set; } = null!;
}