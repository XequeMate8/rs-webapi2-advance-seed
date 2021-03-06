namespace RS.Core.Data
{
    using System.Data.Entity;
    using System.Data.Entity.ModelConfiguration.Conventions;
    using RS.Core.Domain;

    public class RSCoreDBContext : DbContext
    {
        public RSCoreDBContext()
            : base("name=RSCoreDBContext")
        {
            Configuration.LazyLoadingEnabled = false;
        }

        protected override void OnModelCreating(DbModelBuilder modelBuilder)
        {
            modelBuilder.Conventions.Remove<PluralizingTableNameConvention>();
            modelBuilder.Conventions.Remove<OneToManyCascadeDeleteConvention>();
        }

        /// <summary> 
        /// ToDo: Translate - DataSet objeleri test tarafında ezilip in-memory olarak kullanılacağı için virtual olarak tanımlanmıştır.
        /// </summary>
        public virtual DbSet<User> User { get; set; }
    }
}