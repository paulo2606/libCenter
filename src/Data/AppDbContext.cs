using libCenter.src.Models;
using Microsoft.EntityFrameworkCore;

namespace libCenter.src.Data
{
    public class AppDbContext : DbContext
    {
        public AppDbContext(DbContextOptions<AppDbContext> options) : base(options) { }

        public DbSet<UserData> UserData { get; set; }
        public DbSet<AdmModel> Adms { get; set; }
        public DbSet<PublisherModel> Publishers { get; set; }
        public DbSet<GenderModel> Gender { get; set; }
        public DbSet<AuthorModel> Author { get; set; }
        public DbSet<BookModel> Books { get; set; }
        public DbSet<LoanModel> Loans { get; set; }
        public DbSet<ReserveModel> Reserves { get; set; }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.Entity<LoanModel>()
                .HasOne(l => l.User)
                .WithMany()
                .HasForeignKey(l => l.IdUser);

            modelBuilder.Entity<LoanModel>()
                .HasOne(l => l.Book)
                .WithMany()
                .HasForeignKey(l => l.IdBook);

            modelBuilder.Entity<ReserveModel>()
                .HasOne(r => r.User)
                .WithMany()
                .HasForeignKey(r => r.IdUser);

            modelBuilder.Entity<ReserveModel>()
                .HasOne(r => r.Book)
                .WithMany()
                .HasForeignKey(r => r.IdBook);

            modelBuilder.Entity<BookModel>()
                .HasOne(b => b.Publisher)
                .WithMany()
                .HasForeignKey(b => b.IdPublisher);

            modelBuilder.Entity<BookModel>()
                .HasOne(b => b.Author)
                .WithMany()
                .HasForeignKey(b => b.IdAuthor);

            modelBuilder.Entity<BookModel>()
                .HasOne(b => b.Gender)
                .WithMany()
                .HasForeignKey(b => b.IdGender);

            modelBuilder.Entity<UserData>().ToTable("user_data");
            modelBuilder.Entity<AdmModel>().ToTable("adm");
            modelBuilder.Entity<PublisherModel>().ToTable("publisher");
            modelBuilder.Entity<GenderModel>().ToTable("gender");
            modelBuilder.Entity<AuthorModel>().ToTable("author");
            modelBuilder.Entity<BookModel>().ToTable("book");
            modelBuilder.Entity<LoanModel>().ToTable("loan");
            modelBuilder.Entity<ReserveModel>().ToTable("reserve");

            base.OnModelCreating(modelBuilder);
        }
    }
}