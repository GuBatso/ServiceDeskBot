using Microsoft.EntityFrameworkCore;
using ServiceDeskBot.Domain.Entidades;

namespace ServiceDeskBot.Infrastructure.Persistence
{
    public class AppDbContext : DbContext
    {
        public AppDbContext(DbContextOptions<AppDbContext> options) : base(options)
    {
    }
    public DbSet<Local> Locais { get; set; }
    public DbSet<Setor> Setores { get; set; }
    public DbSet<Categoria> Categorias { get; set; }
    public DbSet<Chamado> Chamados { get; set; }
    public DbSet<Equipamento> Equipamentos { get; set; }
    public DbSet<HistoricoChamado> HistoricosChamados { get; set; }
    public DbSet<InteracaoChatBot> InteracoesChatbot { get; set; }
    public DbSet<Usuario> Usuarios { get; set; }
    public DbSet<Tecnico> Tecnicos { get; set; }
    public DbSet<SubCategoria> SubCategorias { get; set; }
    }
}