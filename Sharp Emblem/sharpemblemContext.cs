using System;
using System.Collections.Generic;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata;

namespace Sharp_Emblem
{
    public partial class sharpemblemContext : DbContext
    {
        public sharpemblemContext()
        {
        }

        public sharpemblemContext(DbContextOptions<sharpemblemContext> options)
            : base(options)
        {
        }

        public virtual DbSet<TAskill> TAskills { get; set; } = null!;
        public virtual DbSet<TBeweging> TBewegings { get; set; } = null!;
        public virtual DbSet<TBskill> TBskills { get; set; } = null!;
        public virtual DbSet<TCskill> TCskills { get; set; } = null!;
        public virtual DbSet<TKarakter> TKarakters { get; set; } = null!;
        public virtual DbSet<TSpeciaal> TSpeciaals { get; set; } = null!;
        public virtual DbSet<TTussenkara> TTussenkaras { get; set; } = null!;
        public virtual DbSet<TTussenkarb> TTussenkarbs { get; set; } = null!;
        public virtual DbSet<TTussenkarc> TTussenkarcs { get; set; } = null!;
        public virtual DbSet<TTussenkarmov> TTussenkarmovs { get; set; } = null!;
        public virtual DbSet<TTussenkarspec> TTussenkarspecs { get; set; } = null!;
        public virtual DbSet<TTussenkarwapen> TTussenkarwapens { get; set; } = null!;
        public virtual DbSet<TWapen> TWapens { get; set; } = null!;

        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            if (!optionsBuilder.IsConfigured)
            {
                optionsBuilder.UseMySql("server=localhost;database=sharpemblem;user=root", Microsoft.EntityFrameworkCore.ServerVersion.Parse("10.4.24-mariadb"));
            }
        }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.UseCollation("utf8mb4_general_ci")
                .HasCharSet("utf8mb4");

            modelBuilder.Entity<TAskill>(entity =>
            {
                entity.HasKey(e => e.ASkillId)
                    .HasName("PRIMARY");

                entity.ToTable("t_askill");

                entity.HasIndex(e => e.DNaam, "d_naam")
                    .IsUnique();

                entity.Property(e => e.ASkillId)
                    .HasColumnType("int(45)")
                    .HasColumnName("aSkillID");

                entity.Property(e => e.DNaam).HasColumnName("d_naam");
            });

            modelBuilder.Entity<TBeweging>(entity =>
            {
                entity.HasKey(e => e.MovementId)
                    .HasName("PRIMARY");

                entity.ToTable("t_beweging");

                entity.Property(e => e.MovementId)
                    .HasColumnType("int(45)")
                    .HasColumnName("movementID");

                entity.Property(e => e.DCav).HasColumnName("d_cav");

                entity.Property(e => e.DFly).HasColumnName("d_fly");

                entity.Property(e => e.DMov)
                    .HasColumnType("int(45)")
                    .HasColumnName("d_mov");

                entity.Property(e => e.DNaam)
                    .HasMaxLength(255)
                    .HasColumnName("d_naam");
            });

            modelBuilder.Entity<TBskill>(entity =>
            {
                entity.HasKey(e => e.BSkillId)
                    .HasName("PRIMARY");

                entity.ToTable("t_bskill");

                entity.HasIndex(e => e.DNaam, "d_naam")
                    .IsUnique();

                entity.Property(e => e.BSkillId)
                    .HasColumnType("int(45)")
                    .HasColumnName("bSkillID");

                entity.Property(e => e.DNaam).HasColumnName("d_naam");
            });

            modelBuilder.Entity<TCskill>(entity =>
            {
                entity.HasKey(e => e.CSkillId)
                    .HasName("PRIMARY");

                entity.ToTable("t_cskill");

                entity.HasIndex(e => e.DNaam, "d_naam")
                    .IsUnique();

                entity.Property(e => e.CSkillId)
                    .HasColumnType("int(45)")
                    .HasColumnName("cSkillID");

                entity.Property(e => e.DNaam).HasColumnName("d_naam");
            });

            modelBuilder.Entity<TKarakter>(entity =>
            {
                entity.HasKey(e => e.CharId)
                    .HasName("PRIMARY");

                entity.ToTable("t_karakter");

                entity.Property(e => e.CharId)
                    .HasColumnType("int(45)")
                    .HasColumnName("charID");

                entity.Property(e => e.DAtk)
                    .HasColumnType("int(45)")
                    .HasColumnName("d_atk");

                entity.Property(e => e.DDef)
                    .HasColumnType("int(45)")
                    .HasColumnName("d_def");

                entity.Property(e => e.DHp)
                    .HasColumnType("int(45)")
                    .HasColumnName("d_hp");

                entity.Property(e => e.DNaam)
                    .HasMaxLength(255)
                    .HasColumnName("d_naam");

                entity.Property(e => e.DRes)
                    .HasColumnType("int(45)")
                    .HasColumnName("d_res");

                entity.Property(e => e.DSpd)
                    .HasColumnType("int(45)")
                    .HasColumnName("d_spd");
            });

            modelBuilder.Entity<TSpeciaal>(entity =>
            {
                entity.HasKey(e => e.SpecialId)
                    .HasName("PRIMARY");

                entity.ToTable("t_speciaal");

                entity.HasIndex(e => e.DNaam, "d_naam")
                    .IsUnique();

                entity.Property(e => e.SpecialId)
                    .HasColumnType("int(11)")
                    .HasColumnName("specialID");

                entity.Property(e => e.DAtkInc)
                    .HasColumnType("int(11)")
                    .HasColumnName("d_atkInc");

                entity.Property(e => e.DCooldown)
                    .HasColumnType("int(11)")
                    .HasColumnName("d_cooldown");

                entity.Property(e => e.DDefIng)
                    .HasColumnType("int(11)")
                    .HasColumnName("d_defIng");

                entity.Property(e => e.DDmgIncre)
                    .HasColumnType("int(45)")
                    .HasColumnName("d_dmgIncre");

                entity.Property(e => e.DDmgReduc)
                    .HasColumnType("int(11)")
                    .HasColumnName("d_dmgReduc");

                entity.Property(e => e.DHealForDmg)
                    .HasColumnType("int(11)")
                    .HasColumnName("d_healForDmg");

                entity.Property(e => e.DNaam).HasColumnName("d_naam");

                entity.Property(e => e.DProOfDef)
                    .HasColumnType("int(11)")
                    .HasColumnName("d_proOfDef");

                entity.Property(e => e.DProOfMissHp)
                    .HasColumnType("int(11)")
                    .HasColumnName("d_proOfMissHP");

                entity.Property(e => e.DProOfRes)
                    .HasColumnType("int(11)")
                    .HasColumnName("d_proOfRes");
            });

            modelBuilder.Entity<TTussenkara>(entity =>
            {
                entity.HasKey(e => e.KarAid)
                    .HasName("PRIMARY");

                entity.ToTable("t_tussenkara");

                entity.HasIndex(e => e.ASkillId, "aSkillID");

                entity.HasIndex(e => e.CharId, "charID");

                entity.Property(e => e.KarAid)
                    .HasColumnType("int(11)")
                    .HasColumnName("karAID");

                entity.Property(e => e.ASkillId)
                    .HasColumnType("int(11)")
                    .HasColumnName("aSkillID");

                entity.Property(e => e.CharId)
                    .HasColumnType("int(11)")
                    .HasColumnName("charID");

                entity.HasOne(d => d.ASkill)
                    .WithMany(p => p.TTussenkaras)
                    .HasForeignKey(d => d.ASkillId)
                    .HasConstraintName("t_tussenkara_ibfk_2");

                entity.HasOne(d => d.Char)
                    .WithMany(p => p.TTussenkaras)
                    .HasForeignKey(d => d.CharId)
                    .HasConstraintName("t_tussenkara_ibfk_1");
            });

            modelBuilder.Entity<TTussenkarb>(entity =>
            {
                entity.HasKey(e => e.KarBid)
                    .HasName("PRIMARY");

                entity.ToTable("t_tussenkarb");

                entity.HasIndex(e => e.BSkillId, "bSkillID");

                entity.HasIndex(e => e.CharId, "charID");

                entity.Property(e => e.KarBid)
                    .HasColumnType("int(11)")
                    .HasColumnName("karBID");

                entity.Property(e => e.BSkillId)
                    .HasColumnType("int(11)")
                    .HasColumnName("bSkillID");

                entity.Property(e => e.CharId)
                    .HasColumnType("int(11)")
                    .HasColumnName("charID");

                entity.HasOne(d => d.BSkill)
                    .WithMany(p => p.TTussenkarbs)
                    .HasForeignKey(d => d.BSkillId)
                    .HasConstraintName("t_tussenkarb_ibfk_2");

                entity.HasOne(d => d.Char)
                    .WithMany(p => p.TTussenkarbs)
                    .HasForeignKey(d => d.CharId)
                    .HasConstraintName("t_tussenkarb_ibfk_1");
            });

            modelBuilder.Entity<TTussenkarc>(entity =>
            {
                entity.HasKey(e => e.KarCid)
                    .HasName("PRIMARY");

                entity.ToTable("t_tussenkarc");

                entity.HasIndex(e => e.CSkillId, "cSkillID");

                entity.HasIndex(e => e.CharId, "charID");

                entity.Property(e => e.KarCid)
                    .HasColumnType("int(11)")
                    .HasColumnName("karCID");

                entity.Property(e => e.CSkillId)
                    .HasColumnType("int(11)")
                    .HasColumnName("cSkillID");

                entity.Property(e => e.CharId)
                    .HasColumnType("int(11)")
                    .HasColumnName("charID");

                entity.HasOne(d => d.CSkill)
                    .WithMany(p => p.TTussenkarcs)
                    .HasForeignKey(d => d.CSkillId)
                    .HasConstraintName("t_tussenkarc_ibfk_2");

                entity.HasOne(d => d.Char)
                    .WithMany(p => p.TTussenkarcs)
                    .HasForeignKey(d => d.CharId)
                    .HasConstraintName("t_tussenkarc_ibfk_1");
            });

            modelBuilder.Entity<TTussenkarmov>(entity =>
            {
                entity.HasKey(e => e.KarMovId)
                    .HasName("PRIMARY");

                entity.ToTable("t_tussenkarmov");

                entity.HasIndex(e => e.CharId, "charID");

                entity.HasIndex(e => e.MovementId, "movementID");

                entity.Property(e => e.KarMovId)
                    .HasColumnType("int(11)")
                    .HasColumnName("karMovID");

                entity.Property(e => e.CharId)
                    .HasColumnType("int(11)")
                    .HasColumnName("charID");

                entity.Property(e => e.MovementId)
                    .HasColumnType("int(11)")
                    .HasColumnName("movementID");

                entity.HasOne(d => d.Char)
                    .WithMany(p => p.TTussenkarmovs)
                    .HasForeignKey(d => d.CharId)
                    .HasConstraintName("t_tussenkarmov_ibfk_1");

                entity.HasOne(d => d.Movement)
                    .WithMany(p => p.TTussenkarmovs)
                    .HasForeignKey(d => d.MovementId)
                    .HasConstraintName("t_tussenkarmov_ibfk_2");
            });

            modelBuilder.Entity<TTussenkarspec>(entity =>
            {
                entity.HasKey(e => e.KarSpecId)
                    .HasName("PRIMARY");

                entity.ToTable("t_tussenkarspec");

                entity.HasIndex(e => e.CharId, "charID");

                entity.HasIndex(e => e.SpecialId, "specialID");

                entity.Property(e => e.KarSpecId)
                    .HasColumnType("int(11)")
                    .HasColumnName("karSpecID");

                entity.Property(e => e.CharId)
                    .HasColumnType("int(11)")
                    .HasColumnName("charID");

                entity.Property(e => e.SpecialId)
                    .HasColumnType("int(11)")
                    .HasColumnName("specialID");

                entity.HasOne(d => d.Char)
                    .WithMany(p => p.TTussenkarspecs)
                    .HasForeignKey(d => d.CharId)
                    .HasConstraintName("t_tussenkarspec_ibfk_1");

                entity.HasOne(d => d.Special)
                    .WithMany(p => p.TTussenkarspecs)
                    .HasForeignKey(d => d.SpecialId)
                    .HasConstraintName("t_tussenkarspec_ibfk_2");
            });

            modelBuilder.Entity<TTussenkarwapen>(entity =>
            {
                entity.HasKey(e => e.KarWapenId)
                    .HasName("PRIMARY");

                entity.ToTable("t_tussenkarwapen");

                entity.HasIndex(e => e.CharId, "charID");

                entity.HasIndex(e => e.WeaponId, "weaponID");

                entity.Property(e => e.KarWapenId)
                    .HasColumnType("int(11)")
                    .HasColumnName("karWapenID");

                entity.Property(e => e.CharId)
                    .HasColumnType("int(11)")
                    .HasColumnName("charID");

                entity.Property(e => e.WeaponId)
                    .HasColumnType("int(11)")
                    .HasColumnName("weaponID");

                entity.HasOne(d => d.Char)
                    .WithMany(p => p.TTussenkarwapens)
                    .HasForeignKey(d => d.CharId)
                    .HasConstraintName("t_tussenkarwapen_ibfk_1");

                entity.HasOne(d => d.Weapon)
                    .WithMany(p => p.TTussenkarwapens)
                    .HasForeignKey(d => d.WeaponId)
                    .HasConstraintName("t_tussenkarwapen_ibfk_2");
            });

            modelBuilder.Entity<TWapen>(entity =>
            {
                entity.HasKey(e => e.WeaponId)
                    .HasName("PRIMARY");

                entity.ToTable("t_wapen");

                entity.HasIndex(e => e.WeaponId, "weaponID")
                    .IsUnique();

                entity.Property(e => e.WeaponId)
                    .HasColumnType("int(10)")
                    .HasColumnName("weaponID");

                entity.Property(e => e.DArmorEffect)
                    .HasColumnName("d_armorEffect")
                    .HasDefaultValueSql("'0'");

                entity.Property(e => e.DBladetome)
                    .HasColumnName("d_bladetome")
                    .HasDefaultValueSql("'0'");

                entity.Property(e => e.DBrave)
                    .HasColumnName("d_brave")
                    .HasDefaultValueSql("'0'");

                entity.Property(e => e.DCavEffect)
                    .HasColumnName("d_cavEffect")
                    .HasDefaultValueSql("'0'");

                entity.Property(e => e.DColorEffect)
                    .HasColumnName("d_colorEffect")
                    .HasDefaultValueSql("'0'");

                entity.Property(e => e.DCooldownEffect)
                    .HasColumnType("int(11)")
                    .HasColumnName("d_cooldownEffect");

                entity.Property(e => e.DDc)
                    .HasColumnName("d_dc")
                    .HasDefaultValueSql("'0'");

                entity.Property(e => e.DDraEffect)
                    .HasColumnName("d_draEffect")
                    .HasDefaultValueSql("'0'");

                entity.Property(e => e.DFlyEffect)
                    .HasColumnName("d_flyEffect")
                    .HasDefaultValueSql("'0'");

                entity.Property(e => e.DGem)
                    .HasColumnName("d_gem")
                    .HasDefaultValueSql("'0'");

                entity.Property(e => e.DInfEffect)
                    .HasColumnName("d_infEffect")
                    .HasDefaultValueSql("'0'");

                entity.Property(e => e.DKiller)
                    .HasColumnName("d_killer")
                    .HasDefaultValueSql("'0'");

                entity.Property(e => e.DKleur)
                    .HasMaxLength(45)
                    .HasColumnName("d_kleur");

                entity.Property(e => e.DKracht)
                    .HasColumnType("int(45)")
                    .HasColumnName("d_kracht");

                entity.Property(e => e.DNaam)
                    .HasMaxLength(255)
                    .HasColumnName("d_naam");

                entity.Property(e => e.DType)
                    .HasMaxLength(45)
                    .HasColumnName("d_type");
            });

            OnModelCreatingPartial(modelBuilder);
        }

        partial void OnModelCreatingPartial(ModelBuilder modelBuilder);
    }
}
