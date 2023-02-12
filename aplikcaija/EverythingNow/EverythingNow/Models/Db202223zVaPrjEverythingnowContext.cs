using System;
using System.Collections.Generic;
using Microsoft.EntityFrameworkCore;

namespace EverythingNow.Models;

public partial class Db202223zVaPrjEverythingnowContext : DbContext
{
    public Db202223zVaPrjEverythingnowContext()
    {
    }

    public Db202223zVaPrjEverythingnowContext(DbContextOptions<Db202223zVaPrjEverythingnowContext> options)
        : base(options)
    {
    }

    public virtual DbSet<Admin> Admins { get; set; }

    public virtual DbSet<Apteki> Aptekis { get; set; }

    public virtual DbSet<Apteki1> Aptekis1 { get; set; }

    public virtual DbSet<AptekiLokacii> AptekiLokaciis { get; set; }

    public virtual DbSet<AptekiLokacii1> AptekiLokaciis1 { get; set; }

    public virtual DbSet<Dogovori> Dogovoris { get; set; }

    public virtual DbSet<Dogovori1> Dogovoris1 { get; set; }

    public virtual DbSet<Doktori> Doktoris { get; set; }

    public virtual DbSet<Doktori1> Doktoris1 { get; set; }

    public virtual DbSet<Farmakomi> Farmakomis { get; set; }

    public virtual DbSet<Farmakomi1> Farmakomis1 { get; set; }

    public virtual DbSet<FarmakomiBroevi> FarmakomiBroevis { get; set; }

    public virtual DbSet<FarmakomiBroevi1> FarmakomiBroevis1 { get; set; }

    public virtual DbSet<Igrach> Igraches { get; set; }

    public virtual DbSet<Lekovi> Lekovis { get; set; }

    public virtual DbSet<Lekovi1> Lekovis1 { get; set; }

    public virtual DbSet<Lugje> Lugjes { get; set; }

    public virtual DbSet<Lugje1> Lugjes1 { get; set; }

    public virtual DbSet<MatichenNa> MatichenNas { get; set; }

    public virtual DbSet<MatichenNa1> MatichenNas1 { get; set; }

    public virtual DbSet<Natprevar> Natprevars { get; set; }

    public virtual DbSet<Pacienti> Pacientis { get; set; }

    public virtual DbSet<Pacienti1> Pacientis1 { get; set; }

    public virtual DbSet<Pogodoci> Pogodocis { get; set; }

    public virtual DbSet<Posetitel> Posetitels { get; set; }

    public virtual DbSet<Prodava> Prodavas { get; set; }

    public virtual DbSet<Prodava1> Prodavas1 { get; set; }

    public virtual DbSet<Recepti> Receptis { get; set; }

    public virtual DbSet<Recepti1> Receptis1 { get; set; }

    public virtual DbSet<Reprezentacii> Reprezentaciis { get; set; }

    public virtual DbSet<Rezultat> Rezultats { get; set; }

    public virtual DbSet<Sedistum> Sedista { get; set; }

    public virtual DbSet<Stadion> Stadions { get; set; }

    public virtual DbSet<SudiNa> SudiNas { get; set; }

    public virtual DbSet<Sudii> Sudiis { get; set; }

    public virtual DbSet<Supervizori> Supervizoris { get; set; }

    public virtual DbSet<Supervizori1> Supervizoris1 { get; set; }

    public virtual DbSet<Tiket> Tikets { get; set; }

    public virtual DbSet<TituliReprezentacii> TituliReprezentaciis { get; set; }

    public virtual DbSet<Trener> Treners { get; set; }

    public virtual DbSet<Igra> Igras { get; set; }


    protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
#warning To protect potentially sensitive information in your connection string, you should move it out of source code. You can avoid scaffolding the connection string by using the Name= syntax to read it from configuration - see https://go.microsoft.com/fwlink/?linkid=2131148. For more guidance on storing connection strings, see http://go.microsoft.com/fwlink/?LinkId=723263.
        => optionsBuilder.UseNpgsql("Host=localhost;port=9999;Database=db_202223z_va_prj_everythingnow;Username=db_202223z_va_prj_everythingnow_owner;Password=738d0e43ea47");

    protected override void OnModelCreating(ModelBuilder modelBuilder)
    {
        modelBuilder.Entity<Admin>(entity =>
        {
            entity.HasKey(e => e.Username).HasName("admin_pkey");

            entity.ToTable("admin", "project");

            entity.Property(e => e.Username)
                .HasMaxLength(200)
                .HasColumnName("username");
            entity.Property(e => e.Password)
                .HasMaxLength(200)
                .HasColumnName("password");
        });

        modelBuilder.Entity<Apteki>(entity =>
        {
            entity.HasKey(e => e.AId).HasName("apteki_pkey");

            entity.ToTable("apteki", "IND0_173172");

            entity.Property(e => e.AId)
                .ValueGeneratedNever()
                .HasColumnName("a_id");
            entity.Property(e => e.Aime)
                .HasMaxLength(200)
                .HasColumnName("aime");
        });

        modelBuilder.Entity<Apteki1>(entity =>
        {
            entity.HasKey(e => e.AId).HasName("apteki_pkey");

            entity.ToTable("apteki", "IND0_132025");

            entity.Property(e => e.AId)
                .ValueGeneratedNever()
                .HasColumnName("a_id");
            entity.Property(e => e.Aime)
                .HasMaxLength(200)
                .HasColumnName("aime");
        });

        modelBuilder.Entity<AptekiLokacii>(entity =>
        {
            entity.HasKey(e => new { e.AId, e.ARedenBr }).HasName("pk_apteki_lokacii");

            entity.ToTable("apteki_lokacii", "IND0_173172");

            entity.Property(e => e.AId).HasColumnName("a_id");
            entity.Property(e => e.ARedenBr).HasColumnName("a_reden_br");
            entity.Property(e => e.Adresa)
                .HasMaxLength(255)
                .HasColumnName("adresa");
            entity.Property(e => e.TelBroj)
                .HasMaxLength(255)
                .HasColumnName("tel_broj");

            entity.HasOne(d => d.AIdNavigation).WithMany(p => p.AptekiLokaciis)
                .HasForeignKey(d => d.AId)
                .OnDelete(DeleteBehavior.ClientSetNull)
                .HasConstraintName("apteki_lokacii_a_id_fkey");
        });

        modelBuilder.Entity<AptekiLokacii1>(entity =>
        {
            entity.HasKey(e => new { e.AId, e.ARedenBr }).HasName("pk_apteki_lokacii");

            entity.ToTable("apteki_lokacii", "IND0_132025");

            entity.Property(e => e.AId).HasColumnName("a_id");
            entity.Property(e => e.ARedenBr).HasColumnName("a_reden_br");
            entity.Property(e => e.Adresa)
                .HasMaxLength(255)
                .HasColumnName("adresa");
            entity.Property(e => e.TelBroj)
                .HasMaxLength(255)
                .HasColumnName("tel_broj");

            entity.HasOne(d => d.AIdNavigation).WithMany(p => p.AptekiLokacii1s)
                .HasForeignKey(d => d.AId)
                .OnDelete(DeleteBehavior.ClientSetNull)
                .HasConstraintName("apteki_lokacii_a_id_fkey");
        });

        modelBuilder.Entity<Dogovori>(entity =>
        {
            entity.HasKey(e => new { e.FkId, e.AId, e.DatumSkl }).HasName("pk_dogovori");

            entity.ToTable("dogovori", "IND0_132025");

            entity.Property(e => e.FkId).HasColumnName("fk_id");
            entity.Property(e => e.AId).HasColumnName("a_id");
            entity.Property(e => e.DatumSkl).HasColumnName("datum_skl");
            entity.Property(e => e.DatumIst).HasColumnName("datum_ist");
            entity.Property(e => e.LIdSupervizor).HasColumnName("l_id_supervizor");
            entity.Property(e => e.Sodrzhina)
                .HasMaxLength(20000)
                .HasColumnName("sodrzhina");

            entity.HasOne(d => d.AIdNavigation).WithMany(p => p.Dogovoris)
                .HasForeignKey(d => d.AId)
                .OnDelete(DeleteBehavior.ClientSetNull)
                .HasConstraintName("dogovori_a_id_fkey");

            entity.HasOne(d => d.Fk).WithMany(p => p.Dogovoris)
                .HasForeignKey(d => d.FkId)
                .OnDelete(DeleteBehavior.ClientSetNull)
                .HasConstraintName("dogovori_fk_id_fkey");

            entity.HasOne(d => d.LIdSupervizorNavigation).WithMany(p => p.Dogovoris)
                .HasForeignKey(d => d.LIdSupervizor)
                .OnDelete(DeleteBehavior.ClientSetNull)
                .HasConstraintName("dogovori_l_id_supervizor_fkey");
        });

        modelBuilder.Entity<Dogovori1>(entity =>
        {
            entity.HasKey(e => new { e.FkId, e.AId, e.DatumSkl }).HasName("pk_dogovori");

            entity.ToTable("dogovori", "IND0_173172");

            entity.Property(e => e.FkId).HasColumnName("fk_id");
            entity.Property(e => e.AId).HasColumnName("a_id");
            entity.Property(e => e.DatumSkl).HasColumnName("datum_skl");
            entity.Property(e => e.DatumIst).HasColumnName("datum_ist");
            entity.Property(e => e.LIdSupervizor).HasColumnName("l_id_supervizor");
            entity.Property(e => e.Sodrzhina)
                .HasMaxLength(20000)
                .HasColumnName("sodrzhina");

            entity.HasOne(d => d.AIdNavigation).WithMany(p => p.Dogovori1s)
                .HasForeignKey(d => d.AId)
                .OnDelete(DeleteBehavior.ClientSetNull)
                .HasConstraintName("dogovori_a_id_fkey");

            entity.HasOne(d => d.Fk).WithMany(p => p.Dogovori1s)
                .HasForeignKey(d => d.FkId)
                .OnDelete(DeleteBehavior.ClientSetNull)
                .HasConstraintName("dogovori_fk_id_fkey");

            entity.HasOne(d => d.LIdSupervizorNavigation).WithMany(p => p.Dogovori1s)
                .HasForeignKey(d => d.LIdSupervizor)
                .OnDelete(DeleteBehavior.ClientSetNull)
                .HasConstraintName("dogovori_l_id_supervizor_fkey");
        });

        modelBuilder.Entity<Doktori>(entity =>
        {
            entity.HasKey(e => e.LId).HasName("doktori_pkey");

            entity.ToTable("doktori", "IND0_173172");

            entity.Property(e => e.LId)
                .ValueGeneratedNever()
                .HasColumnName("l_id");
            entity.Property(e => e.RabIskustvo).HasColumnName("rab_iskustvo");
            entity.Property(e => e.Specijalnost)
                .HasMaxLength(255)
                .HasColumnName("specijalnost");

            entity.HasOne(d => d.LIdNavigation).WithOne(p => p.Doktori)
                .HasForeignKey<Doktori>(d => d.LId)
                .OnDelete(DeleteBehavior.ClientSetNull)
                .HasConstraintName("doktori_l_id_fkey");
        });

        modelBuilder.Entity<Doktori1>(entity =>
        {
            entity.HasKey(e => e.LId).HasName("doktori_pkey");

            entity.ToTable("doktori", "IND0_132025");

            entity.Property(e => e.LId)
                .ValueGeneratedNever()
                .HasColumnName("l_id");
            entity.Property(e => e.RabIskustvo).HasColumnName("rab_iskustvo");
            entity.Property(e => e.Specijalnost)
                .HasMaxLength(255)
                .HasColumnName("specijalnost");

            entity.HasOne(d => d.LIdNavigation).WithOne(p => p.Doktori1)
                .HasForeignKey<Doktori1>(d => d.LId)
                .OnDelete(DeleteBehavior.ClientSetNull)
                .HasConstraintName("doktori_l_id_fkey");
        });

        modelBuilder.Entity<Farmakomi>(entity =>
        {
            entity.HasKey(e => e.FkId).HasName("farmakomi_pkey");

            entity.ToTable("farmakomi", "IND0_173172");

            entity.Property(e => e.FkId)
                .ValueGeneratedNever()
                .HasColumnName("fk_id");
            entity.Property(e => e.FkIme)
                .HasMaxLength(200)
                .HasColumnName("fk_ime");
        });

        modelBuilder.Entity<Farmakomi1>(entity =>
        {
            entity.HasKey(e => e.FkId).HasName("farmakomi_pkey");

            entity.ToTable("farmakomi", "IND0_132025");

            entity.Property(e => e.FkId)
                .ValueGeneratedNever()
                .HasColumnName("fk_id");
            entity.Property(e => e.FkIme)
                .HasMaxLength(200)
                .HasColumnName("fk_ime");
        });

        modelBuilder.Entity<FarmakomiBroevi>(entity =>
        {
            entity.HasKey(e => new { e.FkId, e.FkRedenBr }).HasName("pk_farmakomi_broevi");

            entity.ToTable("farmakomi_broevi", "IND0_173172");

            entity.Property(e => e.FkId).HasColumnName("fk_id");
            entity.Property(e => e.FkRedenBr).HasColumnName("fk_reden_br");
            entity.Property(e => e.TelBroj)
                .HasMaxLength(255)
                .HasColumnName("tel_broj");

            entity.HasOne(d => d.Fk).WithMany(p => p.FarmakomiBroevis)
                .HasForeignKey(d => d.FkId)
                .OnDelete(DeleteBehavior.ClientSetNull)
                .HasConstraintName("farmakomi_broevi_fk_id_fkey");
        });

        modelBuilder.Entity<FarmakomiBroevi1>(entity =>
        {
            entity.HasKey(e => new { e.FkId, e.FkRedenBr }).HasName("pk_farmakomi_broevi");

            entity.ToTable("farmakomi_broevi", "IND0_132025");

            entity.Property(e => e.FkId).HasColumnName("fk_id");
            entity.Property(e => e.FkRedenBr).HasColumnName("fk_reden_br");
            entity.Property(e => e.TelBroj)
                .HasMaxLength(255)
                .HasColumnName("tel_broj");

            entity.HasOne(d => d.Fk).WithMany(p => p.FarmakomiBroevi1s)
                .HasForeignKey(d => d.FkId)
                .OnDelete(DeleteBehavior.ClientSetNull)
                .HasConstraintName("farmakomi_broevi_fk_id_fkey");
        });

        modelBuilder.Entity<Igrach>(entity =>
        {
            entity.HasKey(e => e.EmbgIgrach).HasName("pk_igrach");

            entity.ToTable("igrach", "project");

            entity.Property(e => e.EmbgIgrach)
                .HasMaxLength(13)
                .IsFixedLength()
                .HasColumnName("embg_igrach");
            entity.Property(e => e.Drzhava)
                .HasMaxLength(200)
                .HasColumnName("drzhava");
            entity.Property(e => e.ImeIgrach)
                .HasMaxLength(200)
                .HasColumnName("ime_igrach");
            entity.Property(e => e.Pozicija)
                .HasMaxLength(200)
                .HasColumnName("pozicija");
            entity.Property(e => e.Tim)
                .HasMaxLength(200)
                .HasColumnName("tim");

            entity.HasOne(d => d.DrzhavaNavigation).WithMany(p => p.Igraches)
                .HasForeignKey(d => d.Drzhava)
                .HasConstraintName("fk_igrach_drzhava");
        });

        modelBuilder.Entity<Lekovi>(entity =>
        {
            entity.HasKey(e => new { e.FkId, e.ProdId }).HasName("pk_lekovi");

            entity.ToTable("lekovi", "IND0_173172");

            entity.Property(e => e.FkId).HasColumnName("fk_id");
            entity.Property(e => e.ProdId).HasColumnName("prod_id");
            entity.Property(e => e.LIme)
                .HasMaxLength(200)
                .HasColumnName("l_ime");
            entity.Property(e => e.Sostav)
                .HasMaxLength(20000)
                .HasColumnName("sostav");

            entity.HasOne(d => d.Fk).WithMany(p => p.Lekovis)
                .HasForeignKey(d => d.FkId)
                .OnDelete(DeleteBehavior.ClientSetNull)
                .HasConstraintName("lekovi_fk_id_fkey");
        });

        modelBuilder.Entity<Lekovi1>(entity =>
        {
            entity.HasKey(e => new { e.FkId, e.ProdId }).HasName("pk_lekovi");

            entity.ToTable("lekovi", "IND0_132025");

            entity.Property(e => e.FkId).HasColumnName("fk_id");
            entity.Property(e => e.ProdId).HasColumnName("prod_id");
            entity.Property(e => e.LIme)
                .HasMaxLength(200)
                .HasColumnName("l_ime");
            entity.Property(e => e.Sostav)
                .HasMaxLength(20000)
                .HasColumnName("sostav");

            entity.HasOne(d => d.Fk).WithMany(p => p.Lekovi1s)
                .HasForeignKey(d => d.FkId)
                .OnDelete(DeleteBehavior.ClientSetNull)
                .HasConstraintName("lekovi_fk_id_fkey");
        });

        modelBuilder.Entity<Lugje>(entity =>
        {
            entity.HasKey(e => e.LId).HasName("lugje_pkey");

            entity.ToTable("lugje", "IND0_173172");

            entity.HasIndex(e => e.Embg, "lugje_embg_key").IsUnique();

            entity.Property(e => e.LId)
                .ValueGeneratedNever()
                .HasColumnName("l_id");
            entity.Property(e => e.DatumRagj).HasColumnName("datum_ragj");
            entity.Property(e => e.Embg)
                .HasMaxLength(13)
                .IsFixedLength()
                .HasColumnName("embg");
            entity.Property(e => e.Ime)
                .HasMaxLength(200)
                .HasColumnName("ime");
            entity.Property(e => e.Prezime)
                .HasMaxLength(200)
                .HasColumnName("prezime");
        });

        modelBuilder.Entity<Lugje1>(entity =>
        {
            entity.HasKey(e => e.LId).HasName("lugje_pkey");

            entity.ToTable("lugje", "IND0_132025");

            entity.HasIndex(e => e.Embg, "lugje_embg_key").IsUnique();

            entity.Property(e => e.LId)
                .ValueGeneratedNever()
                .HasColumnName("l_id");
            entity.Property(e => e.DatumRagj).HasColumnName("datum_ragj");
            entity.Property(e => e.Embg)
                .HasMaxLength(13)
                .IsFixedLength()
                .HasColumnName("embg");
            entity.Property(e => e.Ime)
                .HasMaxLength(200)
                .HasColumnName("ime");
            entity.Property(e => e.Prezime)
                .HasMaxLength(200)
                .HasColumnName("prezime");
        });

        modelBuilder.Entity<MatichenNa>(entity =>
        {
            entity.HasKey(e => new { e.PLId, e.MDatumPoch }).HasName("pk_matichen_na");

            entity.ToTable("matichen_na", "IND0_173172");

            entity.Property(e => e.PLId).HasColumnName("p_l_id");
            entity.Property(e => e.MDatumPoch).HasColumnName("m_datum_poch");
            entity.Property(e => e.DLId).HasColumnName("d_l_id");
            entity.Property(e => e.MDatumKraj).HasColumnName("m_datum_kraj");

            entity.HasOne(d => d.DL).WithMany(p => p.MatichenNas)
                .HasForeignKey(d => d.DLId)
                .OnDelete(DeleteBehavior.ClientSetNull)
                .HasConstraintName("matichen_na_d_l_id_fkey");

            entity.HasOne(d => d.PL).WithMany(p => p.MatichenNas)
                .HasForeignKey(d => d.PLId)
                .OnDelete(DeleteBehavior.ClientSetNull)
                .HasConstraintName("matichen_na_p_l_id_fkey");
        });

        modelBuilder.Entity<MatichenNa1>(entity =>
        {
            entity.HasKey(e => new { e.PLId, e.MDatumPoch }).HasName("pk_matichen_na");

            entity.ToTable("matichen_na", "IND0_132025");

            entity.Property(e => e.PLId).HasColumnName("p_l_id");
            entity.Property(e => e.MDatumPoch).HasColumnName("m_datum_poch");
            entity.Property(e => e.DLId).HasColumnName("d_l_id");
            entity.Property(e => e.MDatumKraj).HasColumnName("m_datum_kraj");

            entity.HasOne(d => d.DL).WithMany(p => p.MatichenNa1s)
                .HasForeignKey(d => d.DLId)
                .OnDelete(DeleteBehavior.ClientSetNull)
                .HasConstraintName("matichen_na_d_l_id_fkey");

            entity.HasOne(d => d.PL).WithMany(p => p.MatichenNa1s)
                .HasForeignKey(d => d.PLId)
                .OnDelete(DeleteBehavior.ClientSetNull)
                .HasConstraintName("matichen_na_p_l_id_fkey");
        });

        modelBuilder.Entity<Natprevar>(entity =>
        {
            entity.HasKey(e => e.IdNatprevar).HasName("pk_id_natprevar");

            entity.ToTable("natprevar", "project");

            entity.Property(e => e.IdNatprevar)
                .ValueGeneratedNever()
                .HasColumnName("id_natprevar");
            entity.Property(e => e.Chas).HasColumnName("chas");
            entity.Property(e => e.Data).HasColumnName("data");
            entity.Property(e => e.Faza)
                .HasColumnType("character varying")
                .HasColumnName("faza");
            entity.Property(e => e.IdRezultat).HasColumnName("id_rezultat");
            entity.Property(e => e.IdStadion).HasColumnName("id_stadion");
            entity.Property(e => e.Username)
                .HasMaxLength(200)
                .HasColumnName("username");

            entity.Property(e => e.drzhavadomakjin)
               .HasMaxLength(200)
               .HasColumnName("drzhavadomakjin");

            entity.Property(e => e.drzhavagostin)
              .HasMaxLength(200)
              .HasColumnName("drzhavagostin");

            entity.HasOne(d => d.IdRezultatNavigation).WithMany(p => p.Natprevars)
                .HasForeignKey(d => d.IdRezultat)
                .HasConstraintName("fk_natprevar_rezultat");

            entity.HasOne(d => d.IdStadionNavigation).WithMany(p => p.Natprevars)
                .HasForeignKey(d => d.IdStadion)
                .HasConstraintName("fk_natprevar_id_stadion");

            entity.HasOne(d => d.UsernameNavigation).WithMany(p => p.Natprevars)
                .HasForeignKey(d => d.Username)
                .HasConstraintName("fk_natprevar_admin");

            entity.HasOne(d => d.DrzhavaNavigation).WithMany(p => p.Natprevars)
               .HasForeignKey(d => d.drzhavadomakjin)
               .HasConstraintName("fk_drzhava_domakjin");

            entity.HasOne(d => d.DrzhavaNavigation).WithMany(p => p.Natprevars)
              .HasForeignKey(d => d.drzhavagostin)
              .HasConstraintName("fk_drzhava_gostin");
        });


        modelBuilder.Entity<Pacienti>(entity =>
        {
            entity.HasKey(e => e.LId).HasName("pacienti_pkey");

            entity.ToTable("pacienti", "IND0_173172");

            entity.Property(e => e.LId)
                .ValueGeneratedNever()
                .HasColumnName("l_id");
            entity.Property(e => e.PAdresa)
                .HasMaxLength(255)
                .HasColumnName("p_adresa");

            entity.HasOne(d => d.LIdNavigation).WithOne(p => p.Pacienti)
                .HasForeignKey<Pacienti>(d => d.LId)
                .OnDelete(DeleteBehavior.ClientSetNull)
                .HasConstraintName("pacienti_l_id_fkey");
        });

        modelBuilder.Entity<Pacienti1>(entity =>
        {
            entity.HasKey(e => e.LId).HasName("pacienti_pkey");

            entity.ToTable("pacienti", "IND0_132025");

            entity.Property(e => e.LId)
                .ValueGeneratedNever()
                .HasColumnName("l_id");
            entity.Property(e => e.PAdresa)
                .HasMaxLength(255)
                .HasColumnName("p_adresa");

            entity.HasOne(d => d.LIdNavigation).WithOne(p => p.Pacienti1)
                .HasForeignKey<Pacienti1>(d => d.LId)
                .OnDelete(DeleteBehavior.ClientSetNull)
                .HasConstraintName("pacienti_l_id_fkey");
        });

        modelBuilder.Entity<Pogodoci>(entity =>
        {
            entity.HasKey(e => e.IdPogodoci).HasName("pk_pogodoci");

            entity.ToTable("pogodoci", "project");

            entity.Property(e => e.IdPogodoci)
                .ValueGeneratedNever()
                .HasColumnName("id_pogodoci");
            entity.Property(e => e.Asistencii).HasColumnName("asistencii");
            entity.Property(e => e.CrveniKartoni).HasColumnName("crveni_kartoni");
            entity.Property(e => e.Drzhava)
                .HasColumnType("character varying")
                .HasColumnName("drzhava");
            entity.Property(e => e.EmbgIgrach)
                .HasMaxLength(13)
                .IsFixedLength()
                .HasColumnName("embg_igrach");
            entity.Property(e => e.Golovi).HasColumnName("golovi");
            entity.Property(e => e.IdNatprevar).HasColumnName("id_natprevar");
            entity.Property(e => e.Korneri).HasColumnName("korneri");
            entity.Property(e => e.Vreme).HasColumnName("vreme");
            entity.Property(e => e.ZoltiKartoni).HasColumnName("zolti_kartoni");

            entity.HasOne(d => d.DrzhavaNavigation).WithMany(p => p.Pogodocis)
                .HasForeignKey(d => d.Drzhava)
                .HasConstraintName("fk_pogodoci_drzhava");

            entity.HasOne(d => d.EmbgIgrachNavigation).WithMany(p => p.Pogodocis)
                .HasForeignKey(d => d.EmbgIgrach)
                .HasConstraintName("fk_pogodoci_embg_igrach");

            entity.HasOne(d => d.IdNatprevarNavigation).WithMany(p => p.Pogodocis)
                .HasForeignKey(d => d.IdNatprevar)
                .HasConstraintName("fk_pogodoci_id_natprevar");
        });

        modelBuilder.Entity<Posetitel>(entity =>
        {
            entity.HasKey(e => e.Emailaddress).HasName("posetitel_pkey");

            entity.ToTable("posetitel", "project");

            entity.Property(e => e.Emailaddress)
                .HasMaxLength(200)
                .HasColumnName("emailaddress");
            entity.Property(e => e.ImePosetitel)
                .HasMaxLength(200)
                .HasColumnName("ime_posetitel");
            entity.Property(e => e.PasswordPosetitel)
                .HasMaxLength(200)
                .HasColumnName("password_posetitel");
            entity.Property(e => e.UsernamePosetitel)
                .HasMaxLength(200)
                .HasColumnName("username_posetitel");
        });

        modelBuilder.Entity<Prodava>(entity =>
        {
            entity.HasKey(e => new { e.FkId, e.ProdId, e.AId }).HasName("pk_prodava");

            entity.ToTable("prodava", "IND0_132025");

            entity.Property(e => e.FkId).HasColumnName("fk_id");
            entity.Property(e => e.ProdId).HasColumnName("prod_id");
            entity.Property(e => e.AId).HasColumnName("a_id");
            entity.Property(e => e.Cena)
                .HasPrecision(6, 2)
                .HasColumnName("cena");

            entity.HasOne(d => d.AIdNavigation).WithMany(p => p.Prodavas)
                .HasForeignKey(d => d.AId)
                .OnDelete(DeleteBehavior.ClientSetNull)
                .HasConstraintName("prodava_a_id_fkey");

            entity.HasOne(d => d.Lekovi1).WithMany(p => p.Prodavas)
                .HasForeignKey(d => new { d.FkId, d.ProdId })
                .OnDelete(DeleteBehavior.ClientSetNull)
                .HasConstraintName("prodava_kon_lekovi");
        });

        modelBuilder.Entity<Prodava1>(entity =>
        {
            entity.HasKey(e => new { e.FkId, e.ProdId, e.AId }).HasName("pk_prodava");

            entity.ToTable("prodava", "IND0_173172");

            entity.Property(e => e.FkId).HasColumnName("fk_id");
            entity.Property(e => e.ProdId).HasColumnName("prod_id");
            entity.Property(e => e.AId).HasColumnName("a_id");
            entity.Property(e => e.Cena)
                .HasPrecision(6, 2)
                .HasColumnName("cena");

            entity.HasOne(d => d.AIdNavigation).WithMany(p => p.Prodava1s)
                .HasForeignKey(d => d.AId)
                .OnDelete(DeleteBehavior.ClientSetNull)
                .HasConstraintName("prodava_a_id_fkey");

            entity.HasOne(d => d.Lekovi).WithMany(p => p.Prodava1s)
                .HasForeignKey(d => new { d.FkId, d.ProdId })
                .OnDelete(DeleteBehavior.ClientSetNull)
                .HasConstraintName("prodava_kon_lekovi");
        });

        modelBuilder.Entity<Recepti>(entity =>
        {
            entity.HasKey(e => new { e.PLId, e.DLId, e.DatumIzd, e.FkId, e.ProdId }).HasName("pk_recepti");

            entity.ToTable("recepti", "IND0_132025");

            entity.Property(e => e.PLId).HasColumnName("p_l_id");
            entity.Property(e => e.DLId).HasColumnName("d_l_id");
            entity.Property(e => e.DatumIzd).HasColumnName("datum_izd");
            entity.Property(e => e.FkId).HasColumnName("fk_id");
            entity.Property(e => e.ProdId).HasColumnName("prod_id");
            entity.Property(e => e.Doza)
                .HasMaxLength(255)
                .HasColumnName("doza");

            entity.HasOne(d => d.DL).WithMany(p => p.Receptis)
                .HasForeignKey(d => d.DLId)
                .OnDelete(DeleteBehavior.ClientSetNull)
                .HasConstraintName("recepti_d_l_id_fkey");

            entity.HasOne(d => d.PL).WithMany(p => p.Receptis)
                .HasForeignKey(d => d.PLId)
                .OnDelete(DeleteBehavior.ClientSetNull)
                .HasConstraintName("recepti_p_l_id_fkey");

            entity.HasOne(d => d.Lekovi1).WithMany(p => p.Receptis)
                .HasForeignKey(d => new { d.FkId, d.ProdId })
                .OnDelete(DeleteBehavior.ClientSetNull)
                .HasConstraintName("fk_recepti_kon_lekovi");
        });

        modelBuilder.Entity<Recepti1>(entity =>
        {
            entity.HasKey(e => new { e.PLId, e.DLId, e.DatumIzd, e.FkId, e.ProdId }).HasName("pk_recepti");

            entity.ToTable("recepti", "IND0_173172");

            entity.Property(e => e.PLId).HasColumnName("p_l_id");
            entity.Property(e => e.DLId).HasColumnName("d_l_id");
            entity.Property(e => e.DatumIzd).HasColumnName("datum_izd");
            entity.Property(e => e.FkId).HasColumnName("fk_id");
            entity.Property(e => e.ProdId).HasColumnName("prod_id");
            entity.Property(e => e.Doza)
                .HasMaxLength(255)
                .HasColumnName("doza");

            entity.HasOne(d => d.DL).WithMany(p => p.Recepti1s)
                .HasForeignKey(d => d.DLId)
                .OnDelete(DeleteBehavior.ClientSetNull)
                .HasConstraintName("recepti_d_l_id_fkey");

            entity.HasOne(d => d.PL).WithMany(p => p.Recepti1s)
                .HasForeignKey(d => d.PLId)
                .OnDelete(DeleteBehavior.ClientSetNull)
                .HasConstraintName("recepti_p_l_id_fkey");

            entity.HasOne(d => d.Lekovi).WithMany(p => p.Recepti1s)
                .HasForeignKey(d => new { d.FkId, d.ProdId })
                .OnDelete(DeleteBehavior.ClientSetNull)
                .HasConstraintName("fk_recepti_kon_lekovi");
        });

        modelBuilder.Entity<Reprezentacii>(entity =>
        {
            entity.HasKey(e => e.Drzhava).HasName("pk_reprezentacii");

            entity.ToTable("reprezentacii", "project");

            entity.Property(e => e.Drzhava)
                .HasMaxLength(200)
                .HasColumnName("drzhava");
            entity.Property(e => e.ImeReprezentacii)
                .HasMaxLength(200)
                .HasColumnName("ime_reprezentacii");
            entity.Property(e => e.Username)
                .HasMaxLength(200)
                .HasColumnName("username");

            entity.HasOne(d => d.UsernameNavigation).WithMany(p => p.Reprezentaciis)
                .HasForeignKey(d => d.Username)
                .HasConstraintName("reprezentacii_username_fkey");

            entity.HasMany(d => d.IdNatprevars).WithMany(p => p.Drzhavas)
                .UsingEntity<Dictionary<string, object>>(
                    "Igra",
                    r => r.HasOne<Natprevar>().WithMany()
                        .HasForeignKey("IdNatprevar")
                        .OnDelete(DeleteBehavior.ClientSetNull)
                        .HasConstraintName("fk_igra_id_natprevar"),
                    l => l.HasOne<Reprezentacii>().WithMany()
                        .HasForeignKey("Drzhava")
                        .OnDelete(DeleteBehavior.ClientSetNull)
                        .HasConstraintName("fk_igra_drzhava"),
                    j =>
                    {
                        j.HasKey("Drzhava", "IdNatprevar").HasName("pk_igra");
                        j.ToTable("igra", "project");
                    });
        });

        modelBuilder.Entity<Rezultat>(entity =>
        {
            entity.HasKey(e => e.IdRezultat).HasName("pk_rezultat");

            entity.ToTable("rezultat", "project");

            entity.Property(e => e.IdRezultat)
                .ValueGeneratedNever()
                .HasColumnName("id_rezultat");
            entity.Property(e => e.Domakjin).HasColumnName("domakjin");
            entity.Property(e => e.Gostin).HasColumnName("gostin");
            entity.Property(e => e.KonecenRezultat)
                .HasColumnType("character varying")
                .HasColumnName("konecen_rezultat");
            entity.Property(e => e.Username)
                .HasMaxLength(200)
                .HasColumnName("username");

            entity.HasOne(d => d.UsernameNavigation).WithMany(p => p.Rezultats)
                .HasForeignKey(d => d.Username)
                .HasConstraintName("fk_rezultat_admin");
        });

        modelBuilder.Entity<Sedistum>(entity =>
        {
            entity.HasKey(e => e.Broj).HasName("sedista_pkey");

            entity.ToTable("sedista", "project");

            entity.Property(e => e.Broj)
                .ValueGeneratedNever()
                .HasColumnName("broj");
            entity.Property(e => e.IdStadion).HasColumnName("id_stadion");
            entity.Property(e => e.Slobodno).HasColumnName("slobodno");
            entity.Property(e => e.Cena).HasColumnName("cena");

            entity.HasOne(d => d.IdStadionNavigation).WithMany(p => p.Sedista)
                .HasForeignKey(d => d.IdStadion)
                .HasConstraintName("sedista_id_stadion_fkey");
        });

        modelBuilder.Entity<Stadion>(entity =>
        {
            entity.HasKey(e => e.IdStadion).HasName("stadion_pkey");

            entity.ToTable("stadion", "project");

            entity.Property(e => e.IdStadion)
                .ValueGeneratedNever()
                .HasColumnName("id_stadion");
            entity.Property(e => e.CelosenKapacitet).HasColumnName("celosen_kapacitet");
            entity.Property(e => e.Grad)
                .HasMaxLength(200)
                .HasColumnName("grad");
            entity.Property(e => e.ImeStadion)
                .HasMaxLength(200)
                .HasColumnName("ime_stadion");
            entity.Property(e => e.Koordinati)
                .HasMaxLength(200)
                .HasColumnName("koordinati");
            entity.Property(e => e.Slobodno).HasColumnName("slobodno");
        });

        modelBuilder.Entity<SudiNa>(entity =>
        {
            entity.HasKey(e => new { e.IdNatprevar, e.EmbgSudii }).HasName("pk_sudi_na");

            entity.ToTable("sudi_na", "project");

            entity.Property(e => e.IdNatprevar).HasColumnName("id_natprevar");
            entity.Property(e => e.EmbgSudii)
                .HasMaxLength(13)
                .IsFixedLength()
                .HasColumnName("embg_sudii");
            entity.Property(e => e.Uloga)
                .HasMaxLength(200)
                .HasColumnName("uloga");

            entity.HasOne(d => d.EmbgSudiiNavigation).WithMany(p => p.SudiNas)
                .HasForeignKey(d => d.EmbgSudii)
                .OnDelete(DeleteBehavior.ClientSetNull)
                .HasConstraintName("fk_sudi_na_id_embg_sudii");

            entity.HasOne(d => d.IdNatprevarNavigation).WithMany(p => p.SudiNas)
                .HasForeignKey(d => d.IdNatprevar)
                .OnDelete(DeleteBehavior.ClientSetNull)
                .HasConstraintName("fk_sudi_na_id_natprevar");
        });

        modelBuilder.Entity<Sudii>(entity =>
        {
            entity.HasKey(e => e.EmbgSudii).HasName("sudii_pkey");

            entity.ToTable("sudii", "project");

            entity.Property(e => e.EmbgSudii)
                .HasMaxLength(13)
                .IsFixedLength()
                .HasColumnName("embg_sudii");
            entity.Property(e => e.Drzavjanstvo)
                .HasMaxLength(200)
                .HasColumnName("drzavjanstvo");
            entity.Property(e => e.ImeSudii)
                .HasMaxLength(200)
                .HasColumnName("ime_sudii");
        });

        modelBuilder.Entity<Supervizori>(entity =>
        {
            entity.HasKey(e => e.LId).HasName("supervizori_pkey");

            entity.ToTable("supervizori", "IND0_173172");

            entity.Property(e => e.LId)
                .ValueGeneratedNever()
                .HasColumnName("l_id");

            entity.HasOne(d => d.LIdNavigation).WithOne(p => p.Supervizori)
                .HasForeignKey<Supervizori>(d => d.LId)
                .OnDelete(DeleteBehavior.ClientSetNull)
                .HasConstraintName("supervizori_l_id_fkey");
        });

        modelBuilder.Entity<Supervizori1>(entity =>
        {
            entity.HasKey(e => e.LId).HasName("supervizori_pkey");

            entity.ToTable("supervizori", "IND0_132025");

            entity.Property(e => e.LId)
                .ValueGeneratedNever()
                .HasColumnName("l_id");

            entity.HasOne(d => d.LIdNavigation).WithOne(p => p.Supervizori1)
                .HasForeignKey<Supervizori1>(d => d.LId)
                .OnDelete(DeleteBehavior.ClientSetNull)
                .HasConstraintName("supervizori_l_id_fkey");
        });

        modelBuilder.Entity<Tiket>(entity =>
        {
            entity.HasKey(e => new { e.Sediste, e.IdNatprevar }).HasName("pk_sediste");

            entity.ToTable("tiket", "project");

            entity.Property(e => e.Sediste)
                .ValueGeneratedNever()
                .HasColumnName("sediste");
            entity.Property(e => e.Cena).HasColumnName("cena");
            entity.Property(e => e.Emailaddress)
                .HasColumnType("character varying")
                .HasColumnName("emailaddress");
            entity.Property(e => e.IdNatprevar).HasColumnName("id_natprevar");
            entity.Property(e => e.Username)
                .HasMaxLength(200)
                .HasColumnName("username");

            entity.HasOne(d => d.EmailaddressNavigation).WithMany(p => p.Tikets)
                .HasForeignKey(d => d.Emailaddress)
                .HasConstraintName("fk_tiket_posetitel");

            entity.HasOne(d => d.IdNatprevarNavigation).WithMany(p => p.Tikets)
                .HasForeignKey(d => d.IdNatprevar)
                .HasConstraintName("fk_tiket_natprevar");

            entity.HasOne(d => d.SedisteNavigation).WithOne(p => p.Tiket)
                .HasForeignKey<Tiket>(d => d.Sediste)
                .OnDelete(DeleteBehavior.ClientSetNull)
                .HasConstraintName("tiket_sediste_fkey");

            entity.HasOne(d => d.UsernameNavigation).WithMany(p => p.Tikets)
                .HasForeignKey(d => d.Username)
                .HasConstraintName("fk_tiket_admin");
        });

        modelBuilder.Entity<TituliReprezentacii>(entity =>
        {
            entity.HasKey(e => new { e.Drzhava, e.Tituli }).HasName("pk_tituli");

            entity.ToTable("tituli_reprezentacii", "project");

            entity.Property(e => e.Drzhava)
                .HasMaxLength(200)
                .HasColumnName("drzhava");
            entity.Property(e => e.Tituli).HasColumnName("tituli");

            entity.HasOne(d => d.DrzhavaNavigation).WithMany(p => p.TituliReprezentaciis)
                .HasForeignKey(d => d.Drzhava)
                .OnDelete(DeleteBehavior.ClientSetNull)
                .HasConstraintName("tituli_reprezentacii_drzhava_fkey");
        });

        modelBuilder.Entity<Trener>(entity =>
        {
            entity.HasKey(e => e.EmbgTrener).HasName("trener_pkey");

            entity.ToTable("trener", "project");

            entity.Property(e => e.EmbgTrener)
                .HasMaxLength(13)
                .IsFixedLength()
                .HasColumnName("embg_trener");
            entity.Property(e => e.ImeTrener)
                .HasMaxLength(200)
                .HasColumnName("ime_trener");
        });

        modelBuilder.Entity<Igra>(entity =>
        {




            entity.ToTable("igra")
            .HasKey(e => new { e.Drzhava, e.IdNatprevar }).HasName("pk_igra");

            entity.Property(e => e.Drzhava)
                  .HasMaxLength(250)
                  .HasColumnName("drzhava");

            entity.Property(e => e.IdNatprevar)
                .HasColumnName("id_natprevar");


            entity.HasOne(p => p.DrzhavaNavigation)
            .WithMany(p => p.Igras)
            .HasForeignKey(p => p.Drzhava)
             .HasConstraintName("fk_igra_drzhava");

            entity.HasOne(d => d.IdNatprevarNavigation)
                .WithMany(p => p.Igras)
                .HasForeignKey(d => d.IdNatprevar)
                .HasConstraintName("fk_igra_id_natprevar");
        });
    }

    partial void OnModelCreatingPartial(ModelBuilder modelBuilder);
}
