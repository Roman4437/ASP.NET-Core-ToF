// <auto-generated />
using System;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Migrations;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;
using Npgsql.EntityFrameworkCore.PostgreSQL.Metadata;
using ToF.WebApi;

#nullable disable

namespace ToF.WebApi.Migrations
{
    [DbContext(typeof(DatabaseContext))]
    [Migration("20221212125105_ExtendBD")]
    partial class ExtendBD
    {
        /// <inheritdoc />
        protected override void BuildTargetModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .HasAnnotation("ProductVersion", "7.0.0")
                .HasAnnotation("Proxies:ChangeTracking", false)
                .HasAnnotation("Proxies:CheckEquality", false)
                .HasAnnotation("Proxies:LazyLoading", true)
                .HasAnnotation("Relational:MaxIdentifierLength", 63);

            NpgsqlModelBuilderExtensions.UseIdentityByDefaultColumns(modelBuilder);

            modelBuilder.Entity("ToF.WebApi.Simulacra.SimulacraTables.Ability", b =>
                {
                    b.Property<Guid>("AbilityId")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("uuid")
                        .HasColumnName("id");

                    b.Property<string>("Description")
                        .IsRequired()
                        .HasColumnType("text")
                        .HasColumnName("description");

                    b.Property<string>("Name")
                        .IsRequired()
                        .HasColumnType("text")
                        .HasColumnName("name");

                    b.Property<string>("Pattern")
                        .HasColumnType("text")
                        .HasColumnName("pattern");

                    b.Property<Guid>("SimulacraId")
                        .HasColumnType("uuid")
                        .HasColumnName("simulacra_id");

                    b.Property<string>("Type")
                        .IsRequired()
                        .HasColumnType("text")
                        .HasColumnName("type");

                    b.HasKey("AbilityId")
                        .HasName("pk_ability");

                    b.HasIndex("SimulacraId")
                        .HasDatabaseName("ix_ability_simulacra_id");

                    b.ToTable("ability", (string)null);
                });

            modelBuilder.Entity("ToF.WebApi.Simulacra.SimulacraTables.Advancement", b =>
                {
                    b.Property<Guid>("AdvancementId")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("uuid")
                        .HasColumnName("id");

                    b.Property<string>("Description")
                        .IsRequired()
                        .HasColumnType("text")
                        .HasColumnName("description");

                    b.Property<Guid>("SimulacraId")
                        .HasColumnType("uuid")
                        .HasColumnName("simulacra_id");

                    b.HasKey("AdvancementId")
                        .HasName("pk_advancement");

                    b.HasIndex("SimulacraId")
                        .HasDatabaseName("ix_advancement_simulacra_id");

                    b.ToTable("advancement", (string)null);
                });

            modelBuilder.Entity("ToF.WebApi.Simulacra.SimulacraTables.FavoriteGift", b =>
                {
                    b.Property<Guid>("FavoriteGiftId")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("uuid")
                        .HasColumnName("id");

                    b.Property<string>("GiftName")
                        .IsRequired()
                        .HasColumnType("text")
                        .HasColumnName("gift_name");

                    b.Property<Guid>("SimulacraId")
                        .HasColumnType("uuid")
                        .HasColumnName("simulacra_id");

                    b.HasKey("FavoriteGiftId")
                        .HasName("pk_favorite_gift");

                    b.HasIndex("SimulacraId")
                        .HasDatabaseName("ix_favorite_gift_id");

                    b.ToTable("favorite_gift", (string)null);
                });

            modelBuilder.Entity("ToF.WebApi.Simulacra.SimulacraTables.RecomendedMatrice", b =>
                {
                    b.Property<Guid>("RecomendedMatriceId")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("uuid")
                        .HasColumnName("id");

                    b.Property<string>("Description")
                        .IsRequired()
                        .HasColumnType("text")
                        .HasColumnName("description");

                    b.Property<string>("Name")
                        .IsRequired()
                        .HasColumnType("text")
                        .HasColumnName("name");

                    b.Property<int>("Required")
                        .HasColumnType("integer")
                        .HasColumnName("required");

                    b.Property<Guid>("SimulacraId")
                        .HasColumnType("uuid")
                        .HasColumnName("simulacra_id");

                    b.HasKey("RecomendedMatriceId")
                        .HasName("pk_recomended_matrice");

                    b.HasIndex("SimulacraId")
                        .HasDatabaseName("ix_recomended_matrice_simulacra_id");

                    b.ToTable("recomended_matrice", (string)null);
                });

            modelBuilder.Entity("ToF.WebApi.Simulacra.SimulacraTables.WeaponEffect", b =>
                {
                    b.Property<Guid>("WeaponEffectId")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("uuid")
                        .HasColumnName("id");

                    b.Property<string>("Description")
                        .IsRequired()
                        .HasColumnType("text")
                        .HasColumnName("description");

                    b.Property<string>("Name")
                        .IsRequired()
                        .HasColumnType("text")
                        .HasColumnName("name");

                    b.Property<Guid>("SimulacraId")
                        .HasColumnType("uuid")
                        .HasColumnName("simulacra_id");

                    b.HasKey("WeaponEffectId")
                        .HasName("pk_weapon_effect");

                    b.HasIndex("SimulacraId")
                        .HasDatabaseName("ix_weapon_effect_simulacra_id");

                    b.ToTable("weapon_effect", (string)null);
                });

            modelBuilder.Entity("ToF.WebApi.SimulacraEntity", b =>
                {
                    b.Property<Guid>("SimulacraId")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("uuid")
                        .HasColumnName("id");

                    b.Property<string>("Avatar")
                        .IsRequired()
                        .HasColumnType("text")
                        .HasColumnName("avatar");

                    b.Property<float>("ChargeRate")
                        .HasColumnType("real")
                        .HasColumnName("charge_rate");

                    b.Property<string>("ChargeScore")
                        .IsRequired()
                        .HasColumnType("text")
                        .HasColumnName("charge_score");

                    b.Property<string>("Element")
                        .IsRequired()
                        .HasColumnType("text")
                        .HasColumnName("element");

                    b.Property<string>("FirstTrait")
                        .IsRequired()
                        .HasColumnType("text")
                        .HasColumnName("first_trait");

                    b.Property<string>("FirstUpgradeMaterial")
                        .IsRequired()
                        .HasColumnType("text")
                        .HasColumnName("first_upgrade_materia;");

                    b.Property<string>("Name")
                        .IsRequired()
                        .HasColumnType("text")
                        .HasColumnName("name");

                    b.Property<string>("Rarity")
                        .IsRequired()
                        .HasColumnType("text")
                        .HasColumnName("rarity");

                    b.Property<string>("Resonance")
                        .IsRequired()
                        .HasColumnType("text")
                        .HasColumnName("resonance");

                    b.Property<string>("SecondStat")
                        .IsRequired()
                        .HasColumnType("text")
                        .HasColumnName("second_stat");

                    b.Property<string>("SecondTrait")
                        .IsRequired()
                        .HasColumnType("text")
                        .HasColumnName("second_trait");

                    b.Property<string>("SecondUpgradeMaterial")
                        .IsRequired()
                        .HasColumnType("text")
                        .HasColumnName("second_upgrade_materia;");

                    b.Property<float>("ShatterRate")
                        .HasColumnType("real")
                        .HasColumnName("shatter_rate");

                    b.Property<string>("ShatterScore")
                        .IsRequired()
                        .HasColumnType("text")
                        .HasColumnName("shatter_score");

                    b.Property<string>("ThirdStat")
                        .IsRequired()
                        .HasColumnType("text")
                        .HasColumnName("third_stat");

                    b.Property<string>("WeaponAvatar")
                        .IsRequired()
                        .HasColumnType("text")
                        .HasColumnName("weapon_avatar");

                    b.Property<string>("WeponName")
                        .IsRequired()
                        .HasColumnType("text")
                        .HasColumnName("weapon_name");

                    b.HasKey("SimulacraId")
                        .HasName("pk_simulacra");

                    b.ToTable("simulacra", (string)null);
                });

            modelBuilder.Entity("ToF.WebApi.Simulacra.SimulacraTables.Ability", b =>
                {
                    b.HasOne("ToF.WebApi.SimulacraEntity", "SimulacraEntity")
                        .WithMany("Abilities")
                        .HasForeignKey("SimulacraId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired()
                        .HasConstraintName("simulacra_id");

                    b.Navigation("SimulacraEntity");
                });

            modelBuilder.Entity("ToF.WebApi.Simulacra.SimulacraTables.Advancement", b =>
                {
                    b.HasOne("ToF.WebApi.SimulacraEntity", "SimulacraEntity")
                        .WithMany("Advancements")
                        .HasForeignKey("SimulacraId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired()
                        .HasConstraintName("simulacra_id");

                    b.Navigation("SimulacraEntity");
                });

            modelBuilder.Entity("ToF.WebApi.Simulacra.SimulacraTables.FavoriteGift", b =>
                {
                    b.HasOne("ToF.WebApi.SimulacraEntity", "SimulacraEntity")
                        .WithMany("FavoriteGifts")
                        .HasForeignKey("SimulacraId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired()
                        .HasConstraintName("simulacra_id");

                    b.Navigation("SimulacraEntity");
                });

            modelBuilder.Entity("ToF.WebApi.Simulacra.SimulacraTables.RecomendedMatrice", b =>
                {
                    b.HasOne("ToF.WebApi.SimulacraEntity", "SimulacraEntity")
                        .WithMany("RecomendedMatrices")
                        .HasForeignKey("SimulacraId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired()
                        .HasConstraintName("simulacra_id");

                    b.Navigation("SimulacraEntity");
                });

            modelBuilder.Entity("ToF.WebApi.Simulacra.SimulacraTables.WeaponEffect", b =>
                {
                    b.HasOne("ToF.WebApi.SimulacraEntity", "SimulacraEntity")
                        .WithMany("WeaponEffects")
                        .HasForeignKey("SimulacraId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired()
                        .HasConstraintName("simulacra_id");

                    b.Navigation("SimulacraEntity");
                });

            modelBuilder.Entity("ToF.WebApi.SimulacraEntity", b =>
                {
                    b.Navigation("Abilities");

                    b.Navigation("Advancements");

                    b.Navigation("FavoriteGifts");

                    b.Navigation("RecomendedMatrices");

                    b.Navigation("WeaponEffects");
                });
#pragma warning restore 612, 618
        }
    }
}
