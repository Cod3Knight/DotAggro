using Data.DAO;
using Microsoft.EntityFrameworkCore;

namespace Data
{
    /// <summary>
    /// 
    /// </summary>
    public class DataContext : DbContext
    {
        /// <summary>
        /// 
        /// </summary>
        /// <param name="options"></param>
        public DataContext(DbContextOptions<DataContext> options) : base(options)
        {
        }

        /// <summary>
        /// 
        /// </summary>
        /// <param name="builder"></param>
        protected override void OnModelCreating(ModelBuilder builder)
        {
            base.OnModelCreating(builder);
        }

        /// <summary>
        /// 
        /// </summary>
        public DbSet<Pole> Poles { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public DbSet<Ressource> Ressources { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public DbSet<Site> Sites { get; set; }
    }
}