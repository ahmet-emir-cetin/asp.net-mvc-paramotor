using System;
using System.Collections.Generic;
using Microsoft.EntityFrameworkCore;

namespace paramotor.Models.Entities;

public partial class ParamotorContext : DbContext
{
    public ParamotorContext()
    {
    }

    public ParamotorContext(DbContextOptions<ParamotorContext> options)
        : base(options)
    {
    }

    public virtual DbSet<Site>? Sites { get; set; }

    protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        => optionsBuilder.UseMySql("server=localhost;port=3306;user=root;database=paramotor", Microsoft.EntityFrameworkCore.ServerVersion.Parse("10.4.27-mariadb"));

    protected override void OnModelCreating(ModelBuilder modelBuilder)
    {
        modelBuilder
            .UseCollation("utf8_turkish_ci")
            .HasCharSet("utf8");

        modelBuilder.Entity<Site>(entity =>
        {
            entity.HasKey(e => e.Id).HasName("PRIMARY");

            entity.ToTable("site");

            entity.Property(e => e.Id)
                .HasColumnType("int(11)")
                .HasColumnName("id");
            entity.Property(e => e.Description).HasColumnName("description");
            entity.Property(e => e.Email)
                .HasMaxLength(250)
                .HasColumnName("email");
            entity.Property(e => e.Facebook)
                .HasMaxLength(250)
                .HasColumnName("facebook");
            entity.Property(e => e.Favicon)
                .HasMaxLength(250)
                .HasColumnName("favicon");
            entity.Property(e => e.Instagram)
                .HasMaxLength(250)
                .HasColumnName("instagram");
            entity.Property(e => e.LogoImage)
                .HasMaxLength(250)
                .HasColumnName("logoImage");
            entity.Property(e => e.Title)
                .HasMaxLength(250)
                .HasColumnName("title");
            entity.Property(e => e.Twitter)
                .HasMaxLength(250)
                .HasColumnName("twitter");
            entity.Property(e => e.Url)
                .HasMaxLength(250)
                .HasColumnName("url");
            entity.Property(e => e.Youtube)
                .HasMaxLength(250)
                .HasColumnName("youtube");
        });

        OnModelCreatingPartial(modelBuilder);
    }

    partial void OnModelCreatingPartial(ModelBuilder modelBuilder);
}
