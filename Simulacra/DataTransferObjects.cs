using System.ComponentModel.DataAnnotations;
using System.Text.Json.Serialization;

using ToF.WebApi.Simulacra.SimulacraTables;

namespace ToF.WebApi.DataTransferObjects;

public class ShortSimulacraDTO
{
    public Guid SimulacraId { get; set; }
    public string Name { get; set; } 
}

public class GetSimulacraDTO
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

public class CreateSimulacraDTO
{
    /// <summary>Simulacra name.</summary>
    /// <example>Samir</example>
    public string Name { get; set; } 
    /// <summary>Weapon name.</summary>
    /// <example>Dual EM Stars</example>
    public string WeponName { get; set; }
    /// <summary>The path to the avatars folder.</summary>
    /// <example>/simulacra/samir.webp</example>
    public string Avatar { get; set; }
    /// <summary>The path to the weapon avatars folder.</summary>
    /// <example>/weapon/dual_em_stars.webp</example>
    public string WeaponAvatar { get; set; }
    /// <summary>Rarity.</summary>
    /// <example>SSR</example>
    public string Rarity { get; set; }
    /// <summary>Resonance type.</summary>
    /// <example>DPS</example>
    public string Resonance { get; set; }
    /// <summary>Element type.</summary>
    /// <example>Volt</example>
    public string Element { get; set; }
    /// <summary>Shatter rate.</summary>
    /// <example>6</example>
    public float ShatterRate { get; set; }
    /// <summary>Shatter score.</summary>
    /// <example>B</example>
    public string ShatterScore { get; set; }
    /// <summary>Charge rate.</summary>
    /// <example>10.70</example>
    public float ChargeRate { get; set; }
    /// <summary>Charge score.</summary>
    /// <example>S</example>
    public string ChargeScore { get; set; }
    /// <summary>Second stat.</summary>
    /// <example>Health</example>
    public string SecondStat { get; set; }
    /// <summary>Third stat.</summary>
    /// <example>Crit</example>
    public string ThirdStat { get; set; }
    /// <summary>First material.</summary>
    /// <example>Red</example>
    public string FirstUpgradeMaterial { get; set; }
    /// <summary>Second material.</summary>
    /// <example>Black</example>
    public string SecondUpgradeMaterial { get; set; }
    /// <summary>First trait.</summary>
    /// <example>Grant 1 stack of Concentration for every 4 seconds when Samir receives no damage. Each stack increases damage dealt by 3%, and can stack up to 4 times. After being hit, Samir loses 1 stack of Concentration, up to 1 stack per 1 second.</example>
    public string FirstTrait { get; set; }
    /// <summary>Second trait.</summary>
    /// <example>Grant 1 stack of Concentration for every 4 seconds when Samir receives no damage. Each stack increases damage dealt by 4%, and can stack up to 5 times. After being hit, Samir loses 1 stack of Concentration, up to 1 stack per 2 second.</example>
    public string SecondTrait { get; set; }

    public virtual ICollection<WeaponEffect> WeaponEffects { get; set; }
    public virtual ICollection<Advancement> Advancements { get; set; }
    public virtual ICollection<Ability> Abilities { get; set; }
    public virtual ICollection<RecomendedMatrice> RecomendedMatrices { get; set; }
    public virtual ICollection<FavoriteGift> FavoriteGifts { get; set; }
}


public class UpdateSimulacraDTO
{
    /// <summary>Simulacra name.</summary>
    /// <example>Samir</example>
    public string Name { get; set; } 
    /// <summary>Weapon name.</summary>
    /// <example>Dual EM Stars</example>
    public string WeponName { get; set; }
    /// <summary>The path to the avatars folder.</summary>
    /// <example>/simulacra/samir.webp</example>
    public string Avatar { get; set; }
    /// <summary>The path to the weapon avatars folder.</summary>
    /// <example>/weapon/dual_em_stars.webp</example>
    public string WeaponAvatar { get; set; }
    /// <summary>Rarity.</summary>
    /// <example>SSR</example>
    public string Rarity { get; set; }
    /// <summary>Resonance type.</summary>
    /// <example>DPS</example>
    public string Resonance { get; set; }
    /// <summary>Element type.</summary>
    /// <example>Volt</example>
    public string Element { get; set; }
    /// <summary>Shatter rate.</summary>
    /// <example>6</example>
    public float ShatterRate { get; set; }
    /// <summary>Shatter score.</summary>
    /// <example>B</example>
    public string ShatterScore { get; set; }
    /// <summary>Charge rate.</summary>
    /// <example>10.70</example>
    public float ChargeRate { get; set; }
    /// <summary>Charge score.</summary>
    /// <example>S</example>
    public string ChargeScore { get; set; }
    /// <summary>Second stat.</summary>
    /// <example>Health</example>
    public string SecondStat { get; set; }
    /// <summary>Third stat.</summary>
    /// <example>Crit</example>
    public string ThirdStat { get; set; }
    /// <summary>First material.</summary>
    /// <example>Red</example>
    public string FirstUpgradeMaterial { get; set; }
    /// <summary>Second material.</summary>
    /// <example>Black</example>
    public string SecondUpgradeMaterial { get; set; }
    /// <summary>First trait.</summary>
    /// <example>Grant 1 stack of Concentration for every 4 seconds when Samir receives no damage. Each stack increases damage dealt by 3%, and can stack up to 4 times. After being hit, Samir loses 1 stack of Concentration, up to 1 stack per 1 second.</example>
    public string FirstTrait { get; set; }
    /// <summary>Second trait.</summary>
    /// <example>Grant 1 stack of Concentration for every 4 seconds when Samir receives no damage. Each stack increases damage dealt by 4%, and can stack up to 5 times. After being hit, Samir loses 1 stack of Concentration, up to 1 stack per 2 second.</example>
    public string SecondTrait { get; set; }
    
    public virtual ICollection<WeaponEffect> WeaponEffects { get; set; }
    public virtual ICollection<Advancement> Advancements { get; set; }
    public virtual ICollection<Ability> Abilities { get; set; }
    public virtual ICollection<RecomendedMatrice> RecomendedMatrices { get; set; }
    public virtual ICollection<FavoriteGift> FavoriteGifts { get; set; }
}
