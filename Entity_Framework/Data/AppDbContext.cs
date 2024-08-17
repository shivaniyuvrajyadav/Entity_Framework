using Microsoft.EntityFrameworkCore;

namespace Entity_Framework.Data
{
    public class AppDbContext : DbContext
    { 

        public AppDbContext(DbContextOptions<AppDbContext> options) : base(options) {
        }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {   
            modelBuilder.Entity<Student>().HasData(
            new Student() { Id =1, Name ="shivani",Div="a"},
            new Student() { Id =2,Name="ash",Div="b"},
            new Student() { Id =3,Name="abc",Div="c"}
            );


          
        }
      

        public DbSet<Student> Students { get; set; }

        public DbSet<Employee> Employees { get; set; }

    }
}
