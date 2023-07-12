#nullable disable
namespace JashimToken.Data
{
    public class JashimTokenDbContext : DbContext
    {
        public JashimTokenDbContext(DbContextOptions options) : base(options)
        {

        }

        public DbSet<User> Users { get; set; }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            base.OnModelCreating(modelBuilder);

            // Create a new super admin user
            var superAdmin = new User
            {
                Id = -1,
                Username = "Jashim",
                PasswordHash = GetPasswordHash("Jashim@1234", out byte[] passwordSalt),
                PasswordSalt = passwordSalt,
                //IsSuperAdmin = true,
            };

            // Add the new user to the Users table
            modelBuilder.Entity<User>().HasData(superAdmin);
        }

        private static byte[] GetPasswordHash(string password, out byte[] passwordSalt)
        {
            using (var hmac = new HMACSHA512())
            {
                passwordSalt = hmac.Key;
                return hmac.ComputeHash(System.Text.Encoding.UTF8.GetBytes(password));
            }
        }
    }
}
