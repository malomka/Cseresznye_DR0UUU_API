using System;
using System.Collections.Generic;
using Microsoft.EntityFrameworkCore;

namespace Cseresznye_DR0UUU_API.LibraryModels;

public partial class LibraryDatabaseContext : DbContext
{
    public LibraryDatabaseContext()
    {
    }

    public LibraryDatabaseContext(DbContextOptions<LibraryDatabaseContext> options)
        : base(options)
    {
    }

    public virtual DbSet<Kategorium> Kategoria { get; set; }

    public virtual DbSet<Kolcsonze> Kolcsonzes { get; set; }

    public virtual DbSet<Konyv> Konyvs { get; set; }

    public virtual DbSet<Szerzo> Szerzos { get; set; }

    public virtual DbSet<Tag> Tags { get; set; }

    protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
#warning To protect potentially sensitive information in your connection string, you should move it out of source code. You can avoid scaffolding the connection string by using the Name= syntax to read it from configuration - see https://go.microsoft.com/fwlink/?linkid=2131148. For more guidance on storing connection strings, see http://go.microsoft.com/fwlink/?LinkId=723263.
        => optionsBuilder.UseSqlServer("Data Source=software2.database.windows.net;Initial Catalog=LibraryDatabase;User ID=hallgato;Password=majomkenyerfa123!!!;Encrypt=False");

    protected override void OnModelCreating(ModelBuilder modelBuilder)
    {
        modelBuilder.Entity<Kategorium>(entity =>
        {
            entity.HasKey(e => e.KategoriaId).HasName("PK__KATEGORI__37D210EC2A0CD36A");

            entity.ToTable("KATEGORIA");

            entity.HasIndex(e => e.Nev, "UK_KATEGORIA_Nev").IsUnique();

            entity.Property(e => e.KategoriaId).HasColumnName("KategoriaID");
            entity.Property(e => e.Leiras).HasMaxLength(255);
            entity.Property(e => e.Nev).HasMaxLength(50);
        });

        modelBuilder.Entity<Kolcsonze>(entity =>
        {
            entity.HasKey(e => e.KolcsonzesId).HasName("PK__KOLCSONZ__179580FD19E1A6D5");

            entity.ToTable("KOLCSONZES");

            entity.Property(e => e.KolcsonzesId).HasColumnName("KolcsonzesID");
            entity.Property(e => e.KolcsonzesDatum).HasColumnType("datetime");
            entity.Property(e => e.KonyvId).HasColumnName("KonyvID");
            entity.Property(e => e.Statusz).HasMaxLength(20);
            entity.Property(e => e.TagId).HasColumnName("TagID");
            entity.Property(e => e.VisszahozasDatum).HasColumnType("datetime");

            entity.HasOne(d => d.Konyv).WithMany(p => p.Kolcsonzes)
                .HasForeignKey(d => d.KonyvId)
                .OnDelete(DeleteBehavior.ClientSetNull)
                .HasConstraintName("FK__KOLCSONZE__Konyv__02084FDA");

            entity.HasOne(d => d.Tag).WithMany(p => p.Kolcsonzes)
                .HasForeignKey(d => d.TagId)
                .OnDelete(DeleteBehavior.ClientSetNull)
                .HasConstraintName("FK__KOLCSONZE__TagID__01142BA1");
        });

        modelBuilder.Entity<Konyv>(entity =>
        {
            entity.HasKey(e => e.KonyvId).HasName("PK__KONYV__8D2196043AE773D2");

            entity.ToTable("KONYV");

            entity.HasIndex(e => e.Isbn, "UQ__KONYV__447D36EA7AACDFAE").IsUnique();

            entity.Property(e => e.KonyvId).HasColumnName("KonyvID");
            entity.Property(e => e.Cim).HasMaxLength(150);
            entity.Property(e => e.Isbn)
                .HasMaxLength(20)
                .HasColumnName("ISBN");
            entity.Property(e => e.KategoriaId).HasColumnName("KategoriaID");
            entity.Property(e => e.SzerzoId).HasColumnName("SzerzoID");

            entity.HasOne(d => d.Kategoria).WithMany(p => p.Konyvs)
                .HasForeignKey(d => d.KategoriaId)
                .OnDelete(DeleteBehavior.ClientSetNull)
                .HasConstraintName("FK__KONYV__Kategoria__7D439ABD");

            entity.HasOne(d => d.Szerzo).WithMany(p => p.Konyvs)
                .HasForeignKey(d => d.SzerzoId)
                .OnDelete(DeleteBehavior.ClientSetNull)
                .HasConstraintName("FK__KONYV__SzerzoID__7C4F7684");
        });

        modelBuilder.Entity<Szerzo>(entity =>
        {
            entity.HasKey(e => e.SzerzoId).HasName("PK__SZERZO__BAFD3A001669EDBC");

            entity.ToTable("SZERZO");

            entity.Property(e => e.SzerzoId).HasColumnName("SzerzoID");
            entity.Property(e => e.Bemutatas).HasMaxLength(255);
            entity.Property(e => e.Nev).HasMaxLength(100);
        });

        modelBuilder.Entity<Tag>(entity =>
        {
            entity.HasKey(e => e.TagId).HasName("PK__TAG__657CFA4C591199EE");

            entity.ToTable("TAG");

            entity.HasIndex(e => e.TagsagiSzam, "UQ__TAG__54D75752225D2304").IsUnique();

            entity.HasIndex(e => e.Email, "UQ__TAG__A9D10534A622DF95").IsUnique();

            entity.Property(e => e.TagId).HasColumnName("TagID");
            entity.Property(e => e.Email).HasMaxLength(100);
            entity.Property(e => e.Nev).HasMaxLength(100);
            entity.Property(e => e.TagsagiDatum).HasColumnType("datetime");
            entity.Property(e => e.TagsagiSzam).HasMaxLength(20);
            entity.Property(e => e.Telefonszam).HasMaxLength(15);
        });

        OnModelCreatingPartial(modelBuilder);
    }

    partial void OnModelCreatingPartial(ModelBuilder modelBuilder);
}
