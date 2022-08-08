using Cadastros.Web.Models;
using Microsoft.EntityFrameworkCore;

namespace Cadastros.Web.Data;

public class ApplicationDbContext : DbContext
{
    public ApplicationDbContext(DbContextOptions<ApplicationDbContext> options) : base(options)
    {
        
    }

    public DbSet<Cliente> Clientes { get; set; }
    public DbSet<Contato> Contatos { get; set; }
}