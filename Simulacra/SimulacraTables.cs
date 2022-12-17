using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Text.Json.Serialization;

using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using Microsoft.EntityFrameworkCore.Query;

namespace ToF.WebApi.Simulacra.SimulacraTables;

public class WeaponEffect
{
    [JsonIgnore]
    public Guid WeaponEffectId { get; set; }
    /// <summary>The effect name.</summary>
    /// <example>Volt</example>
    public string Name { get; set; }
    /// <summary>Effect description.</summary>
    /// <example>When the weapon is fully charged, the next attack will paralyze targets for 1 second and electrify them for 6 seconds, negating all buffs and dealing damage equal to 144.00% of ATK. Targets cant receive any buffs for the next 6 seconds.</example>
    public string Description { get; set; }
    [JsonIgnore]
    public Guid SimulacraId { get; set; }
    [JsonIgnore]
    public virtual SimulacraEntity? SimulacraEntity { get; set; }
}

public class RecomendedMatrice
{
    [JsonIgnore]
    public Guid RecomendedMatriceId { get; set; }
    /// <summary>The set name.</summary>
    /// <example>Samir</example>
    public string Name { get; set; }
    /// <summary>The amount of matrices.</summary>
    /// <example>2</example>
    public int Required { get; set; }
    /// <summary>The description of useability.</summary>
    /// <example>With its high rate of fire, Dual EM stars can easily maintain 100% uptime on the buff.</example>
    public string Description { get; set; }
    [JsonIgnore]
    public Guid SimulacraId { get; set; }
    [JsonIgnore]
    public virtual SimulacraEntity? SimulacraEntity { get; set; }
}

public class Advancement
{
    [JsonIgnore]
    public Guid AdvancementId { get; set; }
    /// <summary>Advancement order.</summary>
    /// <example>1</example>
    public int Order { get; set; }
    /// <summary>Advancement description.</summary>
    /// <example>Trigger an electrical explosion on the target after landing a critical hit, dealing additional damage equal to 30% of ATK to the target and nearby enemies. Cooldown: 0.2 seconds.</example>
    public string Description { get; set; }
    [JsonIgnore]
    public Guid SimulacraId { get; set; }
    [JsonIgnore]
    public virtual SimulacraEntity? SimulacraEntity { get; set; }
}

public class Ability
{
    [JsonIgnore]
    public Guid AbilityId { get; set; }
    /// <summary>Ability name.</summary>
    /// <example>Dual Fire</example>
    public string Name { get; set; }
    /// <summary>Ability type.</summary>
    /// <example>Normal</example>
    public string Type { get; set; }
    /// <summary>Attack pattern.</summary>
    /// <example>Attack x5</example>
    public string? Pattern { get; set; }
    /// <summary>Ability description</summary>
    /// <example>While on the ground, tap normal attack to attack 5 times in a row. \nDeal total damage equal to 47.1% of ATK + 2.\nDeal total damage equal to 35.8% of ATK + 2.\nDeal total damage equal to 119.7% of ATK + 6.\nDeal total damage equal to 113.1% of ATK + 6.\nDeal total damage equal to 154% of ATK + 8 and launch the target.</example>
    public string Description { get; set; }
    [JsonIgnore]
    public Guid SimulacraId { get; set; }
    [JsonIgnore]
    public virtual SimulacraEntity? SimulacraEntity { get; set; }
}

public class FavoriteGift
{
    [JsonIgnore]
    public Guid FavoriteGiftId { set; get; }
    /// <summary>Favorite gifts.</summary>
    /// <example>Games</example>
    public string GiftName { set; get; }
    [JsonIgnore]
    public Guid SimulacraId { get; set; }
    [JsonIgnore]
    public virtual SimulacraEntity? SimulacraEntity { get; set; }
}

internal class WeaponEffectTypeConfiguration : IEntityTypeConfiguration<WeaponEffect>
{
    public void Configure(EntityTypeBuilder<WeaponEffect> entity)
    {
        entity.ToTable("weapon_effect");

        entity
            .HasKey(weaponEffect => weaponEffect.WeaponEffectId)
            .HasName("pk_weapon_effect");
        
        entity
            .Property(weaponEffect => weaponEffect.WeaponEffectId)
            .HasColumnName("id");

        entity
            .HasIndex(weaponEffect => weaponEffect.SimulacraId)
            .HasDatabaseName("ix_weapon_effect_simulacra_id");
        
        entity
            .Property(weaponEffect => weaponEffect.Name)
            .HasColumnName("name");
        
        entity
            .Property(weaponEffect => weaponEffect.Description)
            .HasColumnName("description");
        
        entity
            .Property(weaponEffect => weaponEffect.SimulacraId)
            .HasColumnName("simulacra_id");
    }
}

internal class RecomendedMatriceTypeConfiguration : IEntityTypeConfiguration<RecomendedMatrice>
{
    public void Configure(EntityTypeBuilder<RecomendedMatrice> entity)
    {
        entity.ToTable("recomended_matrice");

        entity
            .HasKey(recomendedMatrice => recomendedMatrice.RecomendedMatriceId)
            .HasName("pk_recomended_matrice");
        
        entity
            .Property(recomendedMatrice => recomendedMatrice.RecomendedMatriceId)
            .HasColumnName("id");
        
        entity
            .HasIndex(recomendedMatrice => recomendedMatrice.SimulacraId)
            .HasDatabaseName("ix_recomended_matrice_simulacra_id");
        
        entity
            .Property(recomendedMatrice => recomendedMatrice.Name)
            .HasColumnName("name");
        
        entity
            .Property(recomendedMatrice => recomendedMatrice.Description)
            .HasColumnName("description");
        
        entity
            .Property(recomendedMatrice => recomendedMatrice.Required)
            .HasColumnName("required");
        
        entity
            .Property(recomendedMatrice => recomendedMatrice.SimulacraId)
            .HasColumnName("simulacra_id");
    }
}

internal class AdvancementTypeConfiguration : IEntityTypeConfiguration<Advancement>
{
    public void Configure(EntityTypeBuilder<Advancement> entity)
    {
        entity.ToTable("advancement");
        
        entity
            .HasKey(advancement => advancement.AdvancementId)
            .HasName("pk_advancement");
        
        entity
            .Property(advancement => advancement.AdvancementId)
            .HasColumnName("id");
        
        entity
            .HasIndex(advancement => advancement.SimulacraId)
            .HasDatabaseName("ix_advancement_simulacra_id");

        entity
            .Property(advancement => advancement.Order)
            .HasColumnName("order");
        
        entity
            .Property(advancement => advancement.Description)
            .HasColumnName("description");
        
        entity
            .Property(advancement => advancement.SimulacraId)
            .HasColumnName("simulacra_id");
    }
}

internal class AbilityTypeConfiguration : IEntityTypeConfiguration<Ability>
{
    public void Configure(EntityTypeBuilder<Ability> entity)
    {
        entity.ToTable("ability");

        entity
            .HasKey(ability => ability.AbilityId)
            .HasName("pk_ability");
        
        entity
            .Property(ability => ability.AbilityId)
            .HasColumnName("id");
        
        entity
            .HasIndex(ability => ability.SimulacraId)
            .HasDatabaseName("ix_ability_simulacra_id");

        entity
            .Property(ability => ability.Description)
            .HasColumnName("description");
        
        entity
            .Property(ability => ability.Name)
            .HasColumnName("name");
        
        entity
            .Property(ability => ability.Type)
            .HasColumnName("type");
        
        entity
            .Property(ability => ability.Pattern)
            .HasColumnName("pattern");
        
        entity
            .Property(ability => ability.SimulacraId)
            .HasColumnName("simulacra_id");
    }
}

internal class FavoriteGiftTypeConfiguration : IEntityTypeConfiguration<FavoriteGift>
{
    public void Configure(EntityTypeBuilder<FavoriteGift> entity)
    {
        entity.ToTable("favorite_gift");
        
        entity
            .HasKey(advancement => advancement.FavoriteGiftId)
            .HasName("pk_favorite_gift");
        
        entity
            .Property(advancement => advancement.FavoriteGiftId)
            .HasColumnName("id");
        
        entity
            .HasIndex(advancement => advancement.SimulacraId)
            .HasDatabaseName("ix_favorite_gift_id");

        entity
            .Property(advancement => advancement.GiftName)
            .HasColumnName("gift_name");
        
        entity
            .Property(advancement => advancement.SimulacraId)
            .HasColumnName("simulacra_id");
    }
}