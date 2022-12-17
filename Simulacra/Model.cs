using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

using ToF.WebApi.Simulacra.SimulacraTables;

namespace ToF.WebApi;

public class SimulacraEntity
{
    public Guid SimulacraId { get; set; }
    public string Name { get; set; }
    public string WeponName { get; set; }
    public string Avatar { get; set; }
    public string WeaponAvatar { get; set; }
    public string Rarity { get; set; }
    public string Resonance { get; set; }
    public string Element { get; set; }
    public float ShatterRate { get; set; }
    public string ShatterScore { get; set; }
    public float ChargeRate { get; set; }
    public string ChargeScore { get; set; }
    public string SecondStat { get; set; }
    public string ThirdStat { get; set; }
    public string FirstUpgradeMaterial { get; set; }
    public string SecondUpgradeMaterial { get; set; }
    public string FirstTrait { get; set; }
    public string SecondTrait { get; set; }

    public virtual ICollection<WeaponEffect> WeaponEffects { get; set; }
    public virtual ICollection<Advancement> Advancements { get; set; }
    public virtual ICollection<Ability> Abilities { get; set; }
    public virtual ICollection<RecomendedMatrice> RecomendedMatrices { get; set; }
    public virtual ICollection<FavoriteGift> FavoriteGifts { get; set; }
}

internal class SimulacraEntityTypeConfiguration : IEntityTypeConfiguration<SimulacraEntity>
{
    public void Configure(EntityTypeBuilder<SimulacraEntity> entity)
    {
        entity.ToTable("simulacra");

        entity
            .HasKey(simulacra => simulacra.SimulacraId)
            .HasName("pk_simulacra");

        entity
            .Property(simulacra => simulacra.SimulacraId)
            .HasColumnName("id");
        
        entity
            .Property(simulacra => simulacra.Name)
            .HasColumnName("name");
        
        entity
            .Property(simulacra => simulacra.WeponName)
            .HasColumnName("weapon_name");
        
        entity
            .Property(simulacra => simulacra.Avatar)
            .HasColumnName("avatar");
        
        entity
            .Property(simulacra => simulacra.WeaponAvatar)
            .HasColumnName("weapon_avatar");
        
        entity
            .Property(simulacra => simulacra.Rarity)
            .HasColumnName("rarity");
                
        entity
            .Property(simulacra => simulacra.Resonance)
            .HasColumnName("resonance");
        
        entity
            .Property(simulacra => simulacra.Element)
            .HasColumnName("element");
        
        entity
            .Property(simulacra => simulacra.ShatterScore)
            .HasColumnName("shatter_score");
        
        entity
            .Property(simulacra => simulacra.ShatterRate)
            .HasColumnName("shatter_rate");
        
        entity
            .Property(simulacra => simulacra.ChargeScore)
            .HasColumnName("charge_score");
        
        entity
            .Property(simulacra => simulacra.ChargeRate)
            .HasColumnName("charge_rate");
        
        entity
            .Property(simulacra => simulacra.SecondStat)
            .HasColumnName("second_stat");
        
        entity
            .Property(simulacra => simulacra.ThirdStat)
            .HasColumnName("third_stat");

        entity
            .Property(simulacra => simulacra.FirstTrait)
            .HasColumnName("first_trait");
        
        entity
            .Property(simulacra => simulacra.SecondTrait)
            .HasColumnName("second_trait");
        
        entity
            .Property(simulacra => simulacra.FirstUpgradeMaterial)
            .HasColumnName("first_upgrade_material");
        
        entity
            .Property(simulacra => simulacra.SecondUpgradeMaterial)
            .HasColumnName("second_upgrade_material");
        
        entity
            .HasMany(simulacra => simulacra.WeaponEffects)
            .WithOne(weaponEffect => weaponEffect.SimulacraEntity)
            .HasForeignKey(weaponEffect => weaponEffect.SimulacraId)
            .HasConstraintName("simulacra_id");

        entity
            .HasMany(simulacra => simulacra.Advancements)
            .WithOne(advancement => advancement.SimulacraEntity)
            .HasForeignKey(advancement => advancement.SimulacraId)
            .HasConstraintName("simulacra_id");

        entity
            .HasMany(simulacra => simulacra.Abilities)
            .WithOne(ability => ability.SimulacraEntity)
            .HasForeignKey(ability => ability.SimulacraId)
            .HasConstraintName("simulacra_id");

        entity
            .HasMany(simulacra => simulacra.RecomendedMatrices)
            .WithOne(recomendedMatrice => recomendedMatrice.SimulacraEntity)
            .HasForeignKey(recomendedMatrice => recomendedMatrice.SimulacraId)
            .HasConstraintName("simulacra_id");
        
        entity
            .HasMany(simulacra => simulacra.FavoriteGifts)
            .WithOne(recomendedMatrice => recomendedMatrice.SimulacraEntity)
            .HasForeignKey(recomendedMatrice => recomendedMatrice.SimulacraId)
            .HasConstraintName("simulacra_id");
    }
}
