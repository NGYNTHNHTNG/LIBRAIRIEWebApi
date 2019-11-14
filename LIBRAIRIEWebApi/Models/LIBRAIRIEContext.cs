using Microsoft.EntityFrameworkCore;

namespace LIBRAIRIEWebApi.Models
{
    public partial class LIBRAIRIEContext : DbContext
    {
        public LIBRAIRIEContext()
        {
        }

        public LIBRAIRIEContext(DbContextOptions<LIBRAIRIEContext> options)
            : base(options)
        {
        }

        public virtual DbSet<Adresse> Adresse { get; set; }
        public virtual DbSet<Appliquer> Appliquer { get; set; }
        public virtual DbSet<Auteur> Auteur { get; set; }
        public virtual DbSet<Client> Client { get; set; }
        public virtual DbSet<Coecrire> Coecrire { get; set; }
        public virtual DbSet<Commande> Commande { get; set; }
        public virtual DbSet<Commentaires> Commentaires { get; set; }
        public virtual DbSet<Composer> Composer { get; set; }
        public virtual DbSet<Declencher> Declencher { get; set; }
        public virtual DbSet<Editeur> Editeur { get; set; }
        public virtual DbSet<Editeurcollection> Editeurcollection { get; set; }
        public virtual DbSet<Employes> Employes { get; set; }
        public virtual DbSet<Evenement> Evenement { get; set; }
        public virtual DbSet<Format> Format { get; set; }
        public virtual DbSet<Grille> Grille { get; set; }
        public virtual DbSet<Inclure> Inclure { get; set; }
        public virtual DbSet<Lier> Lier { get; set; }
        public virtual DbSet<Lignecmd> Lignecmd { get; set; }
        public virtual DbSet<Livre> Livre { get; set; }
        public virtual DbSet<Livrevolume> Livrevolume { get; set; }
        public virtual DbSet<Motclef> Motclef { get; set; }
        public virtual DbSet<Panier> Panier { get; set; }
        public virtual DbSet<Pays> Pays { get; set; }
        public virtual DbSet<Posseder> Posseder { get; set; }
        public virtual DbSet<Societe> Societe { get; set; }
        public virtual DbSet<Status> Status { get; set; }
        public virtual DbSet<Theme> Theme { get; set; }
        public virtual DbSet<Transporteur> Transporteur { get; set; }
        public virtual DbSet<Tva> Tva { get; set; }

        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            if (!optionsBuilder.IsConfigured)
            {
#warning To protect potentially sensitive information in your connection string, you should move it out of source code. See http://go.microsoft.com/fwlink/?LinkId=723263 for guidance on storing connection strings.
                optionsBuilder.UseSqlServer("Server=.;Database=LIBRAIRIE;Trusted_Connection=True;");
            }
        }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.Entity<Adresse>(entity =>
            {
                entity.HasKey(e => e.Addressid);

                entity.ToTable("ADRESSE");

                entity.HasIndex(e => e.CliCustomerid)
                    .HasName("ASSOCIATION_38_FK");

                entity.HasIndex(e => e.Countryid)
                    .HasName("ASSOCIATION_26_FK");

                entity.HasIndex(e => e.Customerid)
                    .HasName("ASSOCIATION_37_FK");

                entity.HasIndex(e => e.Publisherid)
                    .HasName("ASSOCIATION_25_FK");

                entity.Property(e => e.Addressid).HasColumnName("ADDRESSID");

                entity.Property(e => e.Addressactive).HasColumnName("ADDRESSACTIVE");

                entity.Property(e => e.Addresschangedate2)
                    .HasColumnName("ADDRESSCHANGEDATE2")
                    .HasColumnType("datetime");

                entity.Property(e => e.Addresschangedate3)
                    .HasColumnName("ADDRESSCHANGEDATE3")
                    .HasColumnType("datetime");

                entity.Property(e => e.Addresscity)
                    .IsRequired()
                    .HasColumnName("ADDRESSCITY")
                    .HasMaxLength(100)
                    .IsUnicode(false);

                entity.Property(e => e.Addressinvoiceendofvaliddate)
                    .HasColumnName("ADDRESSINVOICEENDOFVALIDDATE")
                    .HasColumnType("datetime");

                entity.Property(e => e.Addressmore)
                    .HasColumnName("ADDRESSMORE")
                    .HasMaxLength(30)
                    .IsUnicode(false);

                entity.Property(e => e.Addressname)
                    .HasColumnName("ADDRESSNAME")
                    .HasMaxLength(150)
                    .IsUnicode(false);

                entity.Property(e => e.Addressnumber)
                    .HasColumnName("ADDRESSNUMBER")
                    .HasMaxLength(10)
                    .IsUnicode(false);

                entity.Property(e => e.Addresspostalcode)
                    .IsRequired()
                    .HasColumnName("ADDRESSPOSTALCODE")
                    .HasMaxLength(5)
                    .IsUnicode(false);

                entity.Property(e => e.Addressstreetname)
                    .IsRequired()
                    .HasColumnName("ADDRESSSTREETNAME")
                    .HasMaxLength(100)
                    .IsUnicode(false);

                entity.Property(e => e.Addressstreettype)
                    .IsRequired()
                    .HasColumnName("ADDRESSSTREETTYPE")
                    .HasMaxLength(20)
                    .IsUnicode(false);

                entity.Property(e => e.CliCustomerid).HasColumnName("CLI_CUSTOMERID");

                entity.Property(e => e.Countryid).HasColumnName("COUNTRYID");

                entity.Property(e => e.Customerid).HasColumnName("CUSTOMERID");

                entity.Property(e => e.Publisherid).HasColumnName("PUBLISHERID");

                entity.HasOne(d => d.CliCustomer)
                    .WithMany(p => p.AdresseCliCustomer)
                    .HasForeignKey(d => d.CliCustomerid)
                    .HasConstraintName("FK_ADRESSE_LIV_CLIENT");

                entity.HasOne(d => d.Country)
                    .WithMany(p => p.Adresse)
                    .HasForeignKey(d => d.Countryid)
                    .HasConstraintName("FK_ADRESSE_ASSOCIATI_PAYS");

                entity.HasOne(d => d.Customer)
                    .WithMany(p => p.AdresseCustomer)
                    .HasForeignKey(d => d.Customerid)
                    .OnDelete(DeleteBehavior.Cascade)
                    .HasConstraintName("FK_ADRESSE_FACT_CLIENT");

                entity.HasOne(d => d.Publisher)
                    .WithMany(p => p.Adresse)
                    .HasForeignKey(d => d.Publisherid)
                    .OnDelete(DeleteBehavior.Cascade)
                    .HasConstraintName("FK_ADRESSE_ASSOCIATI_EDITEUR");
            });

            modelBuilder.Entity<Appliquer>(entity =>
            {
                entity.HasKey(e => new { e.Bookisbn13, e.Vatid });

                entity.ToTable("APPLIQUER");

                entity.HasIndex(e => e.Bookisbn13)
                    .HasName("APPLIQUER2_FK");

                entity.HasIndex(e => e.Vatid)
                    .HasName("APPLIQUER_FK");

                entity.Property(e => e.Bookisbn13)
                    .HasColumnName("BOOKISBN13")
                    .HasMaxLength(15)
                    .IsUnicode(false);

                entity.Property(e => e.Vatid).HasColumnName("VATID");

                entity.HasOne(d => d.Bookisbn13Navigation)
                    .WithMany(p => p.Appliquer)
                    .HasForeignKey(d => d.Bookisbn13)
                    .HasConstraintName("FK_APPLIQUE_APPLIQUER_LIVRE");

                entity.HasOne(d => d.Vat)
                    .WithMany(p => p.Appliquer)
                    .HasForeignKey(d => d.Vatid)
                    .HasConstraintName("FK_APPLIQUE_APPLIQUER_TVA");
            });

            modelBuilder.Entity<Auteur>(entity =>
            {
                entity.HasKey(e => e.Authorid);

                entity.ToTable("AUTEUR");

                entity.HasIndex(e => e.Statusid)
                    .HasName("ASSOCIATION_45_FK");

                entity.Property(e => e.Authorid).HasColumnName("AUTHORID");

                entity.Property(e => e.Authorbio)
                    .HasColumnName("AUTHORBIO")
                    .HasMaxLength(1024)
                    .IsUnicode(false);

                entity.Property(e => e.Authorfirstname)
                    .IsRequired()
                    .HasColumnName("AUTHORFIRSTNAME")
                    .HasMaxLength(150)
                    .IsUnicode(false);

                entity.Property(e => e.Authorlastname)
                    .IsRequired()
                    .HasColumnName("AUTHORLASTNAME")
                    .HasMaxLength(150)
                    .IsUnicode(false);

                entity.Property(e => e.Authornotes)
                    .HasColumnName("AUTHORNOTES")
                    .HasMaxLength(500)
                    .IsUnicode(false);

                entity.Property(e => e.Authorpicture)
                    .HasColumnName("AUTHORPICTURE")
                    .HasColumnType("image");

                entity.Property(e => e.Statauthcomment)
                    .HasColumnName("STATAUTHCOMMENT")
                    .HasMaxLength(200)
                    .IsUnicode(false);

                entity.Property(e => e.Statauthdate)
                    .HasColumnName("STATAUTHDATE")
                    .HasColumnType("datetime");

                entity.Property(e => e.Statusid).HasColumnName("STATUSID");

                entity.HasOne(d => d.Status)
                    .WithMany(p => p.Auteur)
                    .HasForeignKey(d => d.Statusid)
                    .HasConstraintName("FK_AUTEUR_ASSOCIATI_STATUS");
            });

            modelBuilder.Entity<Client>(entity =>
            {
                entity.HasKey(e => e.Customerid);

                entity.ToTable("CLIENT");

                entity.HasIndex(e => e.Statusid)
                    .HasName("ASSOCIATION_47_FK");

                entity.Property(e => e.Customerid).HasColumnName("CUSTOMERID");

                entity.Property(e => e.Customerbirthdate)
                    .HasColumnName("CUSTOMERBIRTHDATE")
                    .HasColumnType("date");

                entity.Property(e => e.Customerfirstname)
                    .IsRequired()
                    .HasColumnName("CUSTOMERFIRSTNAME")
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.Customerlastname)
                    .IsRequired()
                    .HasColumnName("CUSTOMERLASTNAME")
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.Customermail)
                    .IsRequired()
                    .HasColumnName("CUSTOMERMAIL")
                    .HasMaxLength(100)
                    .IsUnicode(false);

                entity.Property(e => e.Customernotes)
                    .HasColumnName("CUSTOMERNOTES")
                    .HasMaxLength(5000)
                    .IsUnicode(false);

                entity.Property(e => e.Customerphone)
                    .HasColumnName("CUSTOMERPHONE")
                    .HasMaxLength(100)
                    .IsUnicode(false);

                entity.Property(e => e.Customerregistrationdate)
                    .HasColumnName("CUSTOMERREGISTRATIONDATE")
                    .HasColumnType("datetime");

                entity.Property(e => e.Password)
                    .HasColumnName("PASSWORD")
                    .HasMaxLength(200)
                    .IsUnicode(false);

                entity.Property(e => e.Statcustcomment)
                    .HasColumnName("STATCUSTCOMMENT")
                    .HasMaxLength(200)
                    .IsUnicode(false);

                entity.Property(e => e.Statcustdate)
                    .HasColumnName("STATCUSTDATE")
                    .HasColumnType("datetime");

                entity.Property(e => e.Statusid).HasColumnName("STATUSID");
            });

            modelBuilder.Entity<Coecrire>(entity =>
            {
                entity.HasKey(e => new { e.Authorid, e.Bookisbn13 });

                entity.ToTable("COECRIRE");

                entity.HasIndex(e => e.Authorid)
                    .HasName("ASSOCIATION_28_FK");

                entity.HasIndex(e => e.Bookisbn13)
                    .HasName("ASSOCIATION_24_FK");

                entity.Property(e => e.Authorid).HasColumnName("AUTHORID");

                entity.Property(e => e.Bookisbn13)
                    .HasColumnName("BOOKISBN13")
                    .HasMaxLength(15)
                    .IsUnicode(false);

                entity.HasOne(d => d.Author)
                    .WithMany(p => p.Coecrire)
                    .HasForeignKey(d => d.Authorid)
                    .HasConstraintName("FK_COECRIRE_ASSOCIATI_AUTEUR");

                entity.HasOne(d => d.Bookisbn13Navigation)
                    .WithMany(p => p.Coecrire)
                    .HasForeignKey(d => d.Bookisbn13)
                    .HasConstraintName("FK_ASSOCIAT_COECRIRE_LIVRE");
            });

            modelBuilder.Entity<Commande>(entity =>
            {
                entity.HasKey(e => e.Orderid);

                entity.ToTable("COMMANDE");

                entity.HasIndex(e => e.Addressinvoiceid)
                    .HasName("ASSOCIATION_39_FK");

                entity.HasIndex(e => e.Addressshippid)
                    .HasName("ASSOCIATION_40_FK");

                entity.HasIndex(e => e.Customerid)
                    .HasName("VALIDER_FK");

                entity.HasIndex(e => e.Shippingid)
                    .HasName("ASSOCIATION_31_FK");

                entity.HasIndex(e => e.Statusid)
                    .HasName("ASSOCIATION_51_FK");

                entity.Property(e => e.Orderid).HasColumnName("ORDERID");

                entity.Property(e => e.Addressinvoiceid).HasColumnName("ADDRESSINVOICEID");

                entity.Property(e => e.Addressshippid).HasColumnName("ADDRESSSHIPPID");

                entity.Property(e => e.Customerid).HasColumnName("CUSTOMERID");

                entity.Property(e => e.Ordercustomeripaddress)
                    .HasColumnName("ORDERCUSTOMERIPADDRESS")
                    .HasMaxLength(40)
                    .IsUnicode(false);

                entity.Property(e => e.Orderdate)
                    .HasColumnName("ORDERDATE")
                    .HasColumnType("datetime");

                entity.Property(e => e.Orderglobalamount).HasColumnName("ORDERGLOBALAMOUNT");

                entity.Property(e => e.Ordernotes)
                    .HasColumnName("ORDERNOTES")
                    .HasMaxLength(5000)
                    .IsUnicode(false);

                entity.Property(e => e.Orderpaymentamount).HasColumnName("ORDERPAYMENTAMOUNT");

                entity.Property(e => e.Orderpaymentcount).HasColumnName("ORDERPAYMENTCOUNT");

                entity.Property(e => e.Orderpaymentdate)
                    .HasColumnName("ORDERPAYMENTDATE")
                    .HasColumnType("datetime");

                entity.Property(e => e.Ordershippingdate)
                    .HasColumnName("ORDERSHIPPINGDATE")
                    .HasColumnType("datetime");

                entity.Property(e => e.Ordershippingfees).HasColumnName("ORDERSHIPPINGFEES");

                entity.Property(e => e.Ordershippnumber)
                    .HasColumnName("ORDERSHIPPNUMBER")
                    .HasMaxLength(20)
                    .IsUnicode(false);

                entity.Property(e => e.Ordershippstat)
                    .HasColumnName("ORDERSHIPPSTAT")
                    .HasMaxLength(100)
                    .IsUnicode(false);

                entity.Property(e => e.Shippingid).HasColumnName("SHIPPINGID");

                entity.Property(e => e.Statordercomment)
                    .HasColumnName("STATORDERCOMMENT")
                    .HasMaxLength(200)
                    .IsUnicode(false);

                entity.Property(e => e.Statorderdate)
                    .HasColumnName("STATORDERDATE")
                    .HasColumnType("datetime");

                entity.Property(e => e.Statusid).HasColumnName("STATUSID");

                entity.HasOne(d => d.Addressinvoice)
                    .WithMany(p => p.CommandeAddressinvoice)
                    .HasForeignKey(d => d.Addressinvoiceid)
                    .HasConstraintName("FK_COMMANDE_FACT_ADRESSE");

                entity.HasOne(d => d.Addressshipp)
                    .WithMany(p => p.CommandeAddressshipp)
                    .HasForeignKey(d => d.Addressshippid)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK_COMMANDE_LIV_ADRESSE");

                entity.HasOne(d => d.Customer)
                    .WithMany(p => p.Commande)
                    .HasForeignKey(d => d.Customerid)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK_COMMANDE_VALIDER_CLIENT");

                entity.HasOne(d => d.Shipping)
                    .WithMany(p => p.Commande)
                    .HasForeignKey(d => d.Shippingid)
                    .HasConstraintName("FK_COMMANDE_ASSOCIATI_TRANSPOR");

                entity.HasOne(d => d.Status)
                    .WithMany(p => p.Commande)
                    .HasForeignKey(d => d.Statusid)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK_COMMANDE_ASSOCIATI_STATUS");
            });

            modelBuilder.Entity<Commentaires>(entity =>
            {
                entity.HasKey(e => e.Commentid);

                entity.ToTable("COMMENTAIRES");

                entity.HasIndex(e => e.Bookisbn13)
                    .HasName("ASSOCIATION_27_FK");

                entity.HasIndex(e => e.Customerid)
                    .HasName("COMMENTER_FK");

                entity.HasIndex(e => e.Emploginid)
                    .HasName("ASSOCIATION_41_FK");

                entity.HasIndex(e => e.LigLineid)
                    .HasName("ASSOCIER_FK");

                entity.HasIndex(e => e.Statusid)
                    .HasName("ASSOCIATION_43_FK");

                entity.Property(e => e.Commentid).HasColumnName("COMMENTID");

                entity.Property(e => e.Bookisbn13)
                    .IsRequired()
                    .HasColumnName("BOOKISBN13")
                    .HasMaxLength(15)
                    .IsUnicode(false);

                entity.Property(e => e.Commentdate)
                    .HasColumnName("COMMENTDATE")
                    .HasColumnType("datetime");

                entity.Property(e => e.Commenteval).HasColumnName("COMMENTEVAL");

                entity.Property(e => e.Commentipaddress)
                    .HasColumnName("COMMENTIPADDRESS")
                    .HasMaxLength(40)
                    .IsUnicode(false);

                entity.Property(e => e.Commentnocount).HasColumnName("COMMENTNOCOUNT");

                entity.Property(e => e.Commentnotes)
                    .HasColumnName("COMMENTNOTES")
                    .HasMaxLength(5000)
                    .IsUnicode(false);

                entity.Property(e => e.Commentyescount).HasColumnName("COMMENTYESCOUNT");

                entity.Property(e => e.Customerid).HasColumnName("CUSTOMERID");

                entity.Property(e => e.Emploginid).HasColumnName("EMPLOGINID");

                entity.Property(e => e.LigLineid).HasColumnName("LIG_LINEID");

                entity.Property(e => e.Statcommentcomment)
                    .HasColumnName("STATCOMMENTCOMMENT")
                    .HasMaxLength(200)
                    .IsUnicode(false);

                entity.Property(e => e.Statcommentdate)
                    .HasColumnName("STATCOMMENTDATE")
                    .HasColumnType("datetime");

                entity.Property(e => e.Statusid).HasColumnName("STATUSID");

                entity.HasOne(d => d.Bookisbn13Navigation)
                    .WithMany(p => p.Commentaires)
                    .HasForeignKey(d => d.Bookisbn13)
                    .HasConstraintName("FK_COMMENTA_ASSOCIATI_LIVRE");

                entity.HasOne(d => d.Customer)
                    .WithMany(p => p.Commentaires)
                    .HasForeignKey(d => d.Customerid)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK_COMMENTA_COMMENTER_CLIENT");

                entity.HasOne(d => d.Emplogin)
                    .WithMany(p => p.Commentaires)
                    .HasForeignKey(d => d.Emploginid)
                    .OnDelete(DeleteBehavior.Cascade)
                    .HasConstraintName("FK_COMMENTA_ASSOCIATI_EMPLOYES");

                entity.HasOne(d => d.LigLine)
                    .WithMany(p => p.Commentaires)
                    .HasForeignKey(d => d.LigLineid)
                    .HasConstraintName("FK_COMMENTA_ASSOCIER_LIGNECMD");

                entity.HasOne(d => d.Status)
                    .WithMany(p => p.Commentaires)
                    .HasForeignKey(d => d.Statusid)
                    .HasConstraintName("FK_COMMENTA_ASSOCIATI_STATUS");
            });

            modelBuilder.Entity<Composer>(entity =>
            {
                entity.HasKey(e => new { e.Cartid, e.Bookisbn13 });

                entity.ToTable("COMPOSER");

                entity.HasIndex(e => e.Bookisbn13)
                    .HasName("ASSOCIATION_35_FK");

                entity.HasIndex(e => e.Cartid)
                    .HasName("ASSOCIATION_54_FK");

                entity.Property(e => e.Cartid).HasColumnName("CARTID");

                entity.Property(e => e.Bookisbn13)
                    .HasColumnName("BOOKISBN13")
                    .HasMaxLength(15)
                    .IsUnicode(false);

                entity.Property(e => e.Cartbookamount).HasColumnName("CARTBOOKAMOUNT");

                entity.Property(e => e.Cartbookcount).HasColumnName("CARTBOOKCOUNT");

                entity.Property(e => e.Cartbookglobalamount).HasColumnName("CARTBOOKGLOBALAMOUNT");

                entity.HasOne(d => d.Bookisbn13Navigation)
                    .WithMany(p => p.Composer)
                    .HasForeignKey(d => d.Bookisbn13)
                    .HasConstraintName("FK_ASSOCIAT_COMPOSER_LIVRE");

                entity.HasOne(d => d.Cart)
                    .WithMany(p => p.Composer)
                    .HasForeignKey(d => d.Cartid)
                    .HasConstraintName("FK_COMPOSER_ASSOCIATI_PANIER");
            });

            modelBuilder.Entity<Declencher>(entity =>
            {
                entity.HasKey(e => new { e.Bookisbn13, e.Eventid });

                entity.ToTable("DECLENCHER");

                entity.HasIndex(e => e.Bookisbn13)
                    .HasName("ASSOCIATION_15_FK");

                entity.HasIndex(e => e.Eventid)
                    .HasName("ASSOCIATION_12_FK");

                entity.Property(e => e.Bookisbn13)
                    .HasColumnName("BOOKISBN13")
                    .HasMaxLength(15)
                    .IsUnicode(false);

                entity.Property(e => e.Eventid).HasColumnName("EVENTID");

                entity.HasOne(d => d.Bookisbn13Navigation)
                    .WithMany(p => p.Declencher)
                    .HasForeignKey(d => d.Bookisbn13)
                    .HasConstraintName("FK_ASSOCIAT_DECL_LIVRE");

                entity.HasOne(d => d.Event)
                    .WithMany(p => p.Declencher)
                    .HasForeignKey(d => d.Eventid)
                    .HasConstraintName("FK_DECLENCH_DECLENCHE_EVENEMEN");
            });

            modelBuilder.Entity<Editeur>(entity =>
            {
                entity.HasKey(e => e.Publisherid);

                entity.ToTable("EDITEUR");

                entity.HasIndex(e => e.Statusid)
                    .HasName("ASSOCIATION_46_FK");

                entity.Property(e => e.Publisherid).HasColumnName("PUBLISHERID");

                entity.Property(e => e.EditeurNom)
                    .IsRequired()
                    .HasColumnName("EDITEUR_NOM")
                    .HasMaxLength(150)
                    .IsUnicode(false);

                entity.Property(e => e.Publishermail)
                    .HasColumnName("PUBLISHERMAIL")
                    .HasMaxLength(100)
                    .IsUnicode(false);

                entity.Property(e => e.Publishernotes)
                    .HasColumnName("PUBLISHERNOTES")
                    .HasMaxLength(5000)
                    .IsUnicode(false);

                entity.Property(e => e.Publisherphone)
                    .HasColumnName("PUBLISHERPHONE")
                    .HasMaxLength(15)
                    .IsUnicode(false);

                entity.Property(e => e.Stateditcomment)
                    .HasColumnName("STATEDITCOMMENT")
                    .HasMaxLength(200)
                    .IsUnicode(false);

                entity.Property(e => e.Stateditdate)
                    .HasColumnName("STATEDITDATE")
                    .HasColumnType("datetime");

                entity.Property(e => e.Statusid).HasColumnName("STATUSID");

                entity.HasOne(d => d.Status)
                    .WithMany(p => p.Editeur)
                    .HasForeignKey(d => d.Statusid)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK_EDITEUR_ASSOCIATI_STATUS");
            });

            modelBuilder.Entity<Editeurcollection>(entity =>
            {
                entity.HasKey(e => e.Publishercollid);

                entity.ToTable("EDITEURCOLLECTION");

                entity.HasIndex(e => e.Publisherid)
                    .HasName("CREER_FK");

                entity.Property(e => e.Publishercollid).HasColumnName("PUBLISHERCOLLID");

                entity.Property(e => e.Publishercollname)
                    .IsRequired()
                    .HasColumnName("PUBLISHERCOLLNAME")
                    .HasMaxLength(150)
                    .IsUnicode(false);

                entity.Property(e => e.Publisherid).HasColumnName("PUBLISHERID");

                entity.HasOne(d => d.Publisher)
                    .WithMany(p => p.Editeurcollection)
                    .HasForeignKey(d => d.Publisherid)
                    .HasConstraintName("FK_EDITEURC_CREER_EDITEUR");
            });

            modelBuilder.Entity<Employes>(entity =>
            {
                entity.HasKey(e => e.Emploginid);

                entity.ToTable("EMPLOYES");

                entity.HasIndex(e => e.Statusid)
                    .HasName("ASSOCIATION_48_FK");

                entity.Property(e => e.Emploginid).HasColumnName("EMPLOGINID");

                entity.Property(e => e.Authornotes)
                    .HasColumnName("AUTHORNOTES")
                    .HasMaxLength(500)
                    .IsUnicode(false);

                entity.Property(e => e.Commentstatusdate)
                    .HasColumnName("COMMENTSTATUSDATE")
                    .HasColumnType("datetime");

                entity.Property(e => e.Commentstatutchangecomment)
                    .HasColumnName("COMMENTSTATUTCHANGECOMMENT")
                    .HasMaxLength(500)
                    .IsUnicode(false);

                entity.Property(e => e.Commentstatutchangedate)
                    .HasColumnName("COMMENTSTATUTCHANGEDATE")
                    .HasColumnType("datetime");

                entity.Property(e => e.Empfirstname)
                    .HasColumnName("EMPFIRSTNAME")
                    .HasMaxLength(150)
                    .IsUnicode(false);

                entity.Property(e => e.Emplastname)
                    .HasColumnName("EMPLASTNAME")
                    .HasMaxLength(150)
                    .IsUnicode(false);

                entity.Property(e => e.Emplogin)
                    .HasColumnName("EMPLOGIN")
                    .HasMaxLength(150)
                    .IsUnicode(false);

                entity.Property(e => e.Emppassword)
                    .HasColumnName("EMPPASSWORD")
                    .HasMaxLength(100)
                    .IsUnicode(false);

                entity.Property(e => e.Statemplcomment)
                    .HasColumnName("STATEMPLCOMMENT")
                    .HasMaxLength(200)
                    .IsUnicode(false);

                entity.Property(e => e.Statempldate)
                    .HasColumnName("STATEMPLDATE")
                    .HasColumnType("datetime");

                entity.Property(e => e.Statusid).HasColumnName("STATUSID");
            });

            modelBuilder.Entity<Evenement>(entity =>
            {
                entity.HasKey(e => e.Eventid);

                entity.ToTable("EVENEMENT");

                entity.HasIndex(e => e.Statusid)
                    .HasName("ASSOCIATION_50_FK");

                entity.Property(e => e.Eventid).HasColumnName("EVENTID");

                entity.Property(e => e.Eventdescr)
                    .HasColumnName("EVENTDESCR")
                    .HasMaxLength(1024)
                    .IsUnicode(false);

                entity.Property(e => e.Eventdiscount).HasColumnName("EVENTDISCOUNT");

                entity.Property(e => e.Eventendingdate)
                    .HasColumnName("EVENTENDINGDATE")
                    .HasColumnType("datetime");

                entity.Property(e => e.Eventname)
                    .IsRequired()
                    .HasColumnName("EVENTNAME")
                    .HasMaxLength(150)
                    .IsUnicode(false);

                entity.Property(e => e.Eventnotes)
                    .HasColumnName("EVENTNOTES")
                    .HasMaxLength(5000)
                    .IsUnicode(false);

                entity.Property(e => e.Eventpicture)
                    .HasColumnName("EVENTPICTURE")
                    .HasColumnType("image");

                entity.Property(e => e.Eventstartingdate)
                    .HasColumnName("EVENTSTARTINGDATE")
                    .HasColumnType("datetime");

                entity.Property(e => e.Stateventcomment)
                    .HasColumnName("STATEVENTCOMMENT")
                    .HasMaxLength(200)
                    .IsUnicode(false);

                entity.Property(e => e.Stateventdate)
                    .HasColumnName("STATEVENTDATE")
                    .HasColumnType("datetime");

                entity.Property(e => e.Statusid).HasColumnName("STATUSID");

                entity.HasOne(d => d.Status)
                    .WithMany(p => p.Evenement)
                    .HasForeignKey(d => d.Statusid)
                    .HasConstraintName("FK_EVENEMEN_ASSOCIATI_STATUS");
            });

            modelBuilder.Entity<Format>(entity =>
            {
                entity.ToTable("FORMAT");

                entity.Property(e => e.Formatid).HasColumnName("FORMATID");

                entity.Property(e => e.Formatdesc)
                    .HasColumnName("FORMATDESC")
                    .HasMaxLength(1024)
                    .IsUnicode(false);

                entity.Property(e => e.Formatname)
                    .IsRequired()
                    .HasColumnName("FORMATNAME")
                    .HasMaxLength(150)
                    .IsUnicode(false);
            });

            modelBuilder.Entity<Grille>(entity =>
            {
                entity.HasKey(e => e.Gridid);

                entity.ToTable("GRILLE");

                entity.HasIndex(e => e.Publisherid)
                    .HasName("ASSOCIATION_13_FK");

                entity.Property(e => e.Gridid).HasColumnName("GRIDID");

                entity.Property(e => e.Gridcat)
                    .IsRequired()
                    .HasColumnName("GRIDCAT")
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.Gridprice).HasColumnName("GRIDPRICE");

                entity.Property(e => e.Publisherid).HasColumnName("PUBLISHERID");

                entity.HasOne(d => d.Publisher)
                    .WithMany(p => p.Grille)
                    .HasForeignKey(d => d.Publisherid)
                    .HasConstraintName("FK_GRILLE_ASSOCIATI_EDITEUR");
            });

            modelBuilder.Entity<Inclure>(entity =>
            {
                entity.HasKey(e => new { e.Themeid, e.SousThemeid });

                entity.ToTable("INCLURE");

                entity.HasIndex(e => e.SousThemeid)
                    .HasName("ASSOCIATION_34_FK");

                entity.HasIndex(e => e.Themeid)
                    .HasName("ASSOCIATION_52_FK");

                entity.Property(e => e.Themeid).HasColumnName("THEMEID");

                entity.Property(e => e.SousThemeid).HasColumnName("SOUS_THEMEID");

                entity.HasOne(d => d.SousTheme)
                    .WithMany(p => p.InclureSousTheme)
                    .HasForeignKey(d => d.SousThemeid)
                    .HasConstraintName("FK_ASSOCIAT_SOUSTH_THEME");

                entity.HasOne(d => d.Theme)
                    .WithMany(p => p.InclureTheme)
                    .HasForeignKey(d => d.Themeid)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK_ASSOCIAT_TH_THEME");
            });

            modelBuilder.Entity<Lier>(entity =>
            {
                entity.HasKey(e => new { e.Keywordid, e.Bookisbn13 });

                entity.ToTable("LIER");

                entity.HasIndex(e => e.Bookisbn13)
                    .HasName("ASSOCIATION_33_FK");

                entity.HasIndex(e => e.Keywordid)
                    .HasName("ASSOCIATION_53_FK");

                entity.Property(e => e.Keywordid).HasColumnName("KEYWORDID");

                entity.Property(e => e.Bookisbn13)
                    .HasColumnName("BOOKISBN13")
                    .HasMaxLength(15)
                    .IsUnicode(false);

                entity.HasOne(d => d.Bookisbn13Navigation)
                    .WithMany(p => p.Lier)
                    .HasForeignKey(d => d.Bookisbn13)
                    .HasConstraintName("FK_ASSOCIAT_LIER_LIVRE");

                entity.HasOne(d => d.Keyword)
                    .WithMany(p => p.Lier)
                    .HasForeignKey(d => d.Keywordid)
                    .HasConstraintName("FK_LIER_ASSOCIATI_MOTCLEF");
            });

            modelBuilder.Entity<Lignecmd>(entity =>
            {
                entity.HasKey(e => e.Lineid);

                entity.ToTable("LIGNECMD");

                entity.HasIndex(e => e.Bookisbn13)
                    .HasName("ETRE_CONTENUE_FK");

                entity.HasIndex(e => e.Customerid)
                    .HasName("ASSOCIATION_36_FK");

                entity.HasIndex(e => e.Orderid)
                    .HasName("COMPOSER_FK");

                entity.Property(e => e.Lineid).HasColumnName("LINEID");

                entity.Property(e => e.Bookisbn13)
                    .IsRequired()
                    .HasColumnName("BOOKISBN13")
                    .HasMaxLength(15)
                    .IsUnicode(false);

                entity.Property(e => e.Customerid).HasColumnName("CUSTOMERID");

                entity.Property(e => e.Lineactive).HasColumnName("LINEACTIVE");

                entity.Property(e => e.Linepriceht).HasColumnName("LINEPRICEHT");

                entity.Property(e => e.Linequantity).HasColumnName("LINEQUANTITY");

                entity.Property(e => e.Linevat).HasColumnName("LINEVAT");

                entity.Property(e => e.Orderid).HasColumnName("ORDERID");
            });

            modelBuilder.Entity<Livre>(entity =>
            {
                entity.HasKey(e => e.Bookisbn13);

                entity.ToTable("LIVRE");

                entity.HasIndex(e => e.Authorid)
                    .HasName("ECRIRE_FK");

                entity.HasIndex(e => e.Bookvolid)
                    .HasName("ETRE_DANS_FK");

                entity.HasIndex(e => e.Formatid)
                    .HasName("ETRE_FK");

                entity.HasIndex(e => e.Gridid)
                    .HasName("ASSOCIATION_14_FK");

                entity.HasIndex(e => e.Publishercollid)
                    .HasName("CONTENIR_FK");

                entity.HasIndex(e => e.Statusid)
                    .HasName("ASSOCIATION_44_FK");

                entity.Property(e => e.Bookisbn13)
                    .HasColumnName("BOOKISBN13")
                    .HasMaxLength(15)
                    .IsUnicode(false);

                entity.Property(e => e.Authorid).HasColumnName("AUTHORID");

                entity.Property(e => e.Bookavailablestock).HasColumnName("BOOKAVAILABLESTOCK");

                entity.Property(e => e.Bookisbn10)
                    .IsRequired()
                    .HasColumnName("BOOKISBN10")
                    .HasMaxLength(15)
                    .IsUnicode(false);

                entity.Property(e => e.Booknotes)
                    .HasColumnName("BOOKNOTES")
                    .HasMaxLength(5000)
                    .IsUnicode(false);

                entity.Property(e => e.Bookpaging)
                    .IsRequired()
                    .HasColumnName("BOOKPAGING")
                    .HasMaxLength(5)
                    .IsUnicode(false);

                entity.Property(e => e.Bookpicture)
                    .HasColumnName("BOOKPICTURE")
                    .HasColumnType("image");

                entity.Property(e => e.Bookprice).HasColumnName("BOOKPRICE");

                entity.Property(e => e.Bookreleasedate)
                    .HasColumnName("BOOKRELEASEDATE")
                    .HasColumnType("datetime");

                entity.Property(e => e.Bookseries)
                    .HasColumnName("BOOKSERIES")
                    .HasMaxLength(150)
                    .IsUnicode(false);

                entity.Property(e => e.Booksubtitle)
                    .HasColumnName("BOOKSUBTITLE")
                    .HasMaxLength(300)
                    .IsUnicode(false);

                entity.Property(e => e.Booksynopsis)
                    .HasColumnName("BOOKSYNOPSIS")
                    .HasMaxLength(5000)
                    .IsUnicode(false);

                entity.Property(e => e.Booktitle)
                    .IsRequired()
                    .HasColumnName("BOOKTITLE")
                    .HasMaxLength(150)
                    .IsUnicode(false);

                entity.Property(e => e.Bookvolid).HasColumnName("BOOKVOLID");

                entity.Property(e => e.Formatid).HasColumnName("FORMATID");

                entity.Property(e => e.Gridid).HasColumnName("GRIDID");

                entity.Property(e => e.Publishercollid).HasColumnName("PUBLISHERCOLLID");

                entity.Property(e => e.Statbookcomment)
                    .HasColumnName("STATBOOKCOMMENT")
                    .HasMaxLength(200)
                    .IsUnicode(false);

                entity.Property(e => e.Statbookdate)
                    .HasColumnName("STATBOOKDATE")
                    .HasColumnType("datetime");

                entity.Property(e => e.Statusid).HasColumnName("STATUSID");

                entity.HasOne(d => d.Author)
                    .WithMany(p => p.Livre)
                    .HasForeignKey(d => d.Authorid)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK_LIVRE_ECRIRE_AUTEUR");

                entity.HasOne(d => d.Bookvol)
                    .WithMany(p => p.Livre)
                    .HasForeignKey(d => d.Bookvolid)
                    .OnDelete(DeleteBehavior.Cascade)
                    .HasConstraintName("FK_LIVRE_ETRE_DANS_LIVREVOL");

                entity.HasOne(d => d.Format)
                    .WithMany(p => p.Livre)
                    .HasForeignKey(d => d.Formatid)
                    .HasConstraintName("FK_LIVRE_ETRE_FORMAT");

                entity.HasOne(d => d.Grid)
                    .WithMany(p => p.Livre)
                    .HasForeignKey(d => d.Gridid)
                    .HasConstraintName("FK_LIVRE_ASSOCIATI_GRILLE");

                entity.HasOne(d => d.Publishercoll)
                    .WithMany(p => p.Livre)
                    .HasForeignKey(d => d.Publishercollid)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK_LIVRE_CONTENIR_EDITEURC");

                entity.HasOne(d => d.Status)
                    .WithMany(p => p.Livre)
                    .HasForeignKey(d => d.Statusid)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK_LIVRE_ASSOCIATI_STATUS");
            });

            modelBuilder.Entity<Livrevolume>(entity =>
            {
                entity.HasKey(e => e.Bookvolid);

                entity.ToTable("LIVREVOLUME");

                entity.Property(e => e.Bookvolid).HasColumnName("BOOKVOLID");

                entity.Property(e => e.Bookvolname)
                    .IsRequired()
                    .HasColumnName("BOOKVOLNAME")
                    .HasMaxLength(150)
                    .IsUnicode(false);

                entity.Property(e => e.Bookvolquantity).HasColumnName("BOOKVOLQUANTITY");
            });

            modelBuilder.Entity<Motclef>(entity =>
            {
                entity.HasKey(e => e.Keywordid);

                entity.ToTable("MOTCLEF");

                entity.Property(e => e.Keywordid).HasColumnName("KEYWORDID");

                entity.Property(e => e.Keywordcomment)
                    .HasColumnName("KEYWORDCOMMENT")
                    .HasMaxLength(500)
                    .IsUnicode(false);

                entity.Property(e => e.Keywordname)
                    .HasColumnName("KEYWORDNAME")
                    .HasMaxLength(100)
                    .IsUnicode(false);
            });

            modelBuilder.Entity<Panier>(entity =>
            {
                entity.HasKey(e => e.Cartid);

                entity.ToTable("PANIER");

                entity.HasIndex(e => e.Customerid)
                    .HasName("OUVRIR_FK");

                entity.HasIndex(e => e.Statusid)
                    .HasName("ASSOCIATION_49_FK");

                entity.Property(e => e.Cartid).HasColumnName("CARTID");

                entity.Property(e => e.Cartdate)
                    .HasColumnName("CARTDATE")
                    .HasColumnType("datetime");

                entity.Property(e => e.Cartname)
                    .HasColumnName("CARTNAME")
                    .HasMaxLength(100)
                    .IsUnicode(false);

                entity.Property(e => e.Customerid).HasColumnName("CUSTOMERID");

                entity.Property(e => e.Statcartcomment)
                    .HasColumnName("STATCARTCOMMENT")
                    .HasMaxLength(200)
                    .IsUnicode(false);

                entity.Property(e => e.Statcartdate)
                    .HasColumnName("STATCARTDATE")
                    .HasColumnType("datetime");

                entity.Property(e => e.Statusid).HasColumnName("STATUSID");

                entity.HasOne(d => d.Customer)
                    .WithMany(p => p.Panier)
                    .HasForeignKey(d => d.Customerid)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK_PANIER_OUVRIR_CLIENT");

                entity.HasOne(d => d.Status)
                    .WithMany(p => p.Panier)
                    .HasForeignKey(d => d.Statusid)
                    .HasConstraintName("FK_PANIER_ASSOCIATI_STATUS");
            });

            modelBuilder.Entity<Pays>(entity =>
            {
                entity.HasKey(e => e.Countryid);

                entity.ToTable("PAYS");

                entity.Property(e => e.Countryid).HasColumnName("COUNTRYID");

                entity.Property(e => e.A2)
                    .IsRequired()
                    .HasMaxLength(2)
                    .IsUnicode(false)
                    .IsFixedLength()
                    .HasDefaultValueSql("('')");

                entity.Property(e => e.A3)
                    .IsRequired()
                    .HasMaxLength(3)
                    .IsUnicode(false)
                    .IsFixedLength()
                    .HasDefaultValueSql("('')");

                entity.Property(e => e.Number)
                    .HasColumnType("decimal(3, 0)")
                    .HasDefaultValueSql("('0')");

                entity.Property(e => e.Pays1)
                    .IsRequired()
                    .HasColumnName("Pays")
                    .HasMaxLength(50)
                    .IsUnicode(false)
                    .HasDefaultValueSql("('')");
            });

            modelBuilder.Entity<Posseder>(entity =>
            {
                entity.HasKey(e => new { e.Themeid, e.Bookisbn13 });

                entity.ToTable("POSSEDER");

                entity.HasIndex(e => e.Bookisbn13)
                    .HasName("POSSEDER_FK");

                entity.HasIndex(e => e.Themeid)
                    .HasName("POSSEDER2_FK");

                entity.Property(e => e.Themeid).HasColumnName("THEMEID");

                entity.Property(e => e.Bookisbn13)
                    .HasColumnName("BOOKISBN13")
                    .HasMaxLength(15)
                    .IsUnicode(false);

                entity.HasOne(d => d.Bookisbn13Navigation)
                    .WithMany(p => p.Posseder)
                    .HasForeignKey(d => d.Bookisbn13)
                    .HasConstraintName("FK_POSSEDER_POSSEDER_LIVRE");

                entity.HasOne(d => d.Theme)
                    .WithMany(p => p.Posseder)
                    .HasForeignKey(d => d.Themeid)
                    .HasConstraintName("FK_POSSEDER_POSSEDER2_THEME");
            });

            modelBuilder.Entity<Societe>(entity =>
            {
                entity.HasKey(e => e.Socnom);

                entity.ToTable("SOCIETE");

                entity.HasIndex(e => e.Addressid)
                    .HasName("ASSOCIATION_42_FK");

                entity.Property(e => e.Socnom)
                    .HasColumnName("SOCNOM")
                    .HasMaxLength(150)
                    .IsUnicode(false);

                entity.Property(e => e.Addressid).HasColumnName("ADDRESSID");

                entity.Property(e => e.Socmail)
                    .HasColumnName("SOCMAIL")
                    .HasMaxLength(100)
                    .IsUnicode(false);

                entity.Property(e => e.Socphone)
                    .HasColumnName("SOCPHONE")
                    .HasMaxLength(15)
                    .IsUnicode(false);

                entity.Property(e => e.Socsiren)
                    .HasColumnName("SOCSIREN")
                    .HasMaxLength(15)
                    .IsUnicode(false);

                entity.Property(e => e.Socsiret)
                    .HasColumnName("SOCSIRET")
                    .HasMaxLength(20)
                    .IsUnicode(false);

                entity.HasOne(d => d.Address)
                    .WithMany(p => p.Societe)
                    .HasForeignKey(d => d.Addressid)
                    .OnDelete(DeleteBehavior.Cascade)
                    .HasConstraintName("FK_SOCIETE_ASSOCIATI_ADRESSE");
            });

            modelBuilder.Entity<Status>(entity =>
            {
                entity.ToTable("STATUS");

                entity.Property(e => e.Statusid)
                    .HasColumnName("STATUSID")
                    .ValueGeneratedNever();

                entity.Property(e => e.StatusDescr)
                    .HasColumnName("STATUS_DESCR")
                    .HasMaxLength(1000)
                    .IsUnicode(false);

                entity.Property(e => e.Statusname)
                    .IsRequired()
                    .HasColumnName("STATUSNAME")
                    .HasMaxLength(150)
                    .IsUnicode(false);
            });

            modelBuilder.Entity<Theme>(entity =>
            {
                entity.ToTable("THEME");

                entity.Property(e => e.Themeid).HasColumnName("THEMEID");

                entity.Property(e => e.Themedesc)
                    .HasColumnName("THEMEDESC")
                    .HasMaxLength(150)
                    .IsUnicode(false);

                entity.Property(e => e.Themename)
                    .IsRequired()
                    .HasColumnName("THEMENAME")
                    .HasMaxLength(150)
                    .IsUnicode(false);
            });

            modelBuilder.Entity<Transporteur>(entity =>
            {
                entity.HasKey(e => e.Shippingid);

                entity.ToTable("TRANSPORTEUR");

                entity.HasIndex(e => e.Statusid)
                    .HasName("ASSOCIATION_23_FK");

                entity.Property(e => e.Shippingid).HasColumnName("SHIPPINGID");

                entity.Property(e => e.Shippingcarrierlogo)
                    .HasColumnName("SHIPPINGCARRIERLOGO")
                    .HasColumnType("image");

                entity.Property(e => e.Shippingcarriermail)
                    .HasColumnName("SHIPPINGCARRIERMAIL")
                    .HasMaxLength(100)
                    .IsUnicode(false);

                entity.Property(e => e.Shippingcarriername)
                    .HasColumnName("SHIPPINGCARRIERNAME")
                    .HasMaxLength(150)
                    .IsUnicode(false);

                entity.Property(e => e.Shippingcarrierphone)
                    .HasColumnName("SHIPPINGCARRIERPHONE")
                    .HasMaxLength(20)
                    .IsUnicode(false);

                entity.Property(e => e.Shippingfees).HasColumnName("SHIPPINGFEES");

                entity.Property(e => e.Shippingnotes)
                    .HasColumnName("SHIPPINGNOTES")
                    .HasMaxLength(5000)
                    .IsUnicode(false);

                entity.Property(e => e.Statshippcomment)
                    .HasColumnName("STATSHIPPCOMMENT")
                    .HasMaxLength(200)
                    .IsUnicode(false);

                entity.Property(e => e.Statshippdate)
                    .HasColumnName("STATSHIPPDATE")
                    .HasColumnType("datetime");

                entity.Property(e => e.Statusid).HasColumnName("STATUSID");

                entity.HasOne(d => d.Status)
                    .WithMany(p => p.Transporteur)
                    .HasForeignKey(d => d.Statusid)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK_TRANSPOR_ASSOCIATI_STATUS");
            });

            modelBuilder.Entity<Tva>(entity =>
            {
                entity.HasKey(e => e.Vatid);

                entity.ToTable("TVA");

                entity.Property(e => e.Vatid).HasColumnName("VATID");

                entity.Property(e => e.Vattaux).HasColumnName("VATTAUX");

                entity.Property(e => e.Vattype)
                    .IsRequired()
                    .HasColumnName("VATTYPE")
                    .HasMaxLength(150)
                    .IsUnicode(false);
            });

            OnModelCreatingPartial(modelBuilder);
        }

        partial void OnModelCreatingPartial(ModelBuilder modelBuilder);
    }
}
