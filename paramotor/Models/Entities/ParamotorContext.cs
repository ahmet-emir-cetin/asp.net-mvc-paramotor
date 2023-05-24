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

    public virtual DbSet<About>? Abouts { get; set; }

    public virtual DbSet<Portfolio>? Portfolios { get; set; }

    public virtual DbSet<Site>? Sites { get; set; }

    public virtual DbSet<Slide>? Slides { get; set; }

    public virtual DbSet<Team>? Teams { get; set; }

    protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        => optionsBuilder.UseMySql("server=localhost;port=3306;user=root;database=paramotor", Microsoft.EntityFrameworkCore.ServerVersion.Parse("10.4.27-mariadb"));

    protected override void OnModelCreating(ModelBuilder modelBuilder)
    {
        modelBuilder
            .UseCollation("utf8_turkish_ci")
            .HasCharSet("utf8");

        modelBuilder.Entity<About>(entity =>
        {
            entity.HasKey(e => e.Id).HasName("PRIMARY");

            entity.ToTable("about");

            entity.Property(e => e.Id)
                .HasColumnType("int(11)")
                .HasColumnName("id");
            entity.Property(e => e.Detail)
                .HasMaxLength(500)
                .HasColumnName("detail");
            entity.Property(e => e.Image)
                .HasMaxLength(250)
                .HasColumnName("image");
            entity.Property(e => e.Isview).HasColumnName("isview");
            entity.Property(e => e.Order)
                .HasColumnType("int(11)")
                .HasColumnName("order");
            entity.Property(e => e.Subtitle)
                .HasMaxLength(250)
                .HasColumnName("subtitle");
            entity.Property(e => e.Title)
                .HasMaxLength(250)
                .HasColumnName("title");
        });

        modelBuilder.Entity<Portfolio>(entity =>
        {
            entity.HasKey(e => e.Id).HasName("PRIMARY");

            entity.ToTable("portfolio");

            entity.Property(e => e.Id)
                .HasColumnType("int(11)")
                .HasColumnName("id");
            entity.Property(e => e.Client)
                .HasMaxLength(50)
                .HasColumnName("client");
            entity.Property(e => e.Complated)
                .HasMaxLength(250)
                .HasColumnName("complated");
            entity.Property(e => e.Detail)
                .HasMaxLength(250)
                .HasColumnName("detail");
            entity.Property(e => e.Facebook)
                .HasMaxLength(250)
                .HasColumnName("facebook");
            entity.Property(e => e.Image)
                .HasMaxLength(250)
                .HasColumnName("image");
            entity.Property(e => e.Instagram)
                .HasMaxLength(250)
                .HasColumnName("instagram");
            entity.Property(e => e.Isview).HasColumnName("isview");
            entity.Property(e => e.Linkedin)
                .HasMaxLength(250)
                .HasColumnName("linkedin");
            entity.Property(e => e.Order)
                .HasColumnType("int(11)")
                .HasColumnName("order");
            entity.Property(e => e.Rating)
                .HasColumnType("int(5)")
                .HasColumnName("rating");
            entity.Property(e => e.Subtitle)
                .HasMaxLength(250)
                .HasColumnName("subtitle");
            entity.Property(e => e.Title)
                .HasMaxLength(50)
                .HasColumnName("title");
            entity.Property(e => e.Twitter)
                .HasMaxLength(250)
                .HasColumnName("twitter");
            entity.Property(e => e.Type)
                .HasMaxLength(50)
                .HasColumnName("type");
            entity.Property(e => e.Website)
                .HasMaxLength(250)
                .HasColumnName("website");
        });

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

        modelBuilder.Entity<Slide>(entity =>
        {
            entity.HasKey(e => e.Id).HasName("PRIMARY");

            entity.ToTable("slide");

            entity.Property(e => e.Id)
                .HasColumnType("int(11)")
                .HasColumnName("id");
            entity.Property(e => e.Image)
                .HasMaxLength(250)
                .HasColumnName("image");
            entity.Property(e => e.IsTarget)
                .HasMaxLength(50)
                .HasColumnName("isTarget");
            entity.Property(e => e.IsView)
                .HasDefaultValueSql("'0'")
                .HasColumnName("isView");
            entity.Property(e => e.Order)
                .HasColumnType("int(11)")
                .HasColumnName("order");
            entity.Property(e => e.Subtitle)
                .HasColumnType("text")
                .HasColumnName("subtitle");
            entity.Property(e => e.Title)
                .HasMaxLength(250)
                .HasColumnName("title");
            entity.Property(e => e.Url)
                .HasMaxLength(250)
                .HasColumnName("url");
            entity.Property(e => e.Urltext)
                .HasMaxLength(250)
                .HasColumnName("urltext");
        });

        modelBuilder.Entity<Team>(entity =>
        {
            entity.HasKey(e => e.Id).HasName("PRIMARY");

            entity.ToTable("team");

            entity.Property(e => e.Id)
                .HasColumnType("int(11)")
                .HasColumnName("id");
            entity.Property(e => e.Facebook)
                .HasMaxLength(250)
                .HasColumnName("facebook");
            entity.Property(e => e.Image)
                .HasMaxLength(250)
                .HasColumnName("image");
            entity.Property(e => e.Instagram)
                .HasMaxLength(250)
                .HasColumnName("instagram");
            entity.Property(e => e.Isview).HasColumnName("isview");
            entity.Property(e => e.Linkedin)
                .HasMaxLength(250)
                .HasColumnName("linkedin");
            entity.Property(e => e.Order)
                .HasColumnType("int(11)")
                .HasColumnName("order");
            entity.Property(e => e.Subtitle)
                .HasMaxLength(250)
                .HasColumnName("subtitle");
            entity.Property(e => e.Title)
                .HasMaxLength(250)
                .HasColumnName("title");
            entity.Property(e => e.Twitter)
                .HasMaxLength(250)
                .HasColumnName("twitter");
            entity.Property(e => e.Youtube)
                .HasMaxLength(250)
                .HasColumnName("youtube");
        });

        OnModelCreatingPartial(modelBuilder);
    }

    partial void OnModelCreatingPartial(ModelBuilder modelBuilder);
}
