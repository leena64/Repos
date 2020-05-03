using Microsoft.EntityFrameworkCore;

namespace Diplom.Models
{
    public class OhranaContext: DbContext
    {
        #region Public Properties
        public DbSet<User> User { get; set; }
        public DbSet<UserContract> UsersContract { get; set; }
        public DbSet<Contract> Contract { get; set; }
        public DbSet<ObjectSec> ObjectSec { get; set; }
        public DbSet<ObjectList> ObjectList { get; set; }
        public DbSet<Post> Post { get; set; }
        public DbSet<Staff> Staff { get; set; }
        public DbSet<TypeList> TypeList { get; set; }
        #endregion
        public OhranaContext() => Database.EnsureCreated();
        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            optionsBuilder
                .UseSqlServer(@"Server=.;Database=Diplom;Trusted_Connection=True;MultipleActiveResultSets=true");
        }
    }
}
