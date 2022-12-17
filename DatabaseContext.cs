using System.Reflection;

using Microsoft.EntityFrameworkCore;

using ToF.WebApi.Simulacra.SimulacraTables;

namespace ToF.WebApi;

public class DatabaseContext : DbContext
{
    public DbSet<SimulacraEntity> Simulacra { get; set; }
    public DbSet<WeaponEffect> WeaponEffects { get; set; }
    public DbSet<RecomendedMatrice> RecomendedMatrices { get; set; }
    public DbSet<FavoriteGift> FavoriteGifts { get; set; }
    public DbSet<Advancement> Advancements { get; set; }
    public DbSet<Ability> Abilities { get; set; }

    public DatabaseContext(DbContextOptions<DatabaseContext> options)
        : base(options) { }
    
    protected override void OnModelCreating(ModelBuilder modelBuilder) =>
        modelBuilder.ApplyConfigurationsFromAssembly(Assembly.GetExecutingAssembly());

    protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder) =>
        optionsBuilder.UseLazyLoadingProxies();
}
