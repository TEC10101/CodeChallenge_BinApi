namespace BinApi.Repositories.Bin
{
    using Microsoft.EntityFrameworkCore;

    public class BinDb : DbContext
    {
        public BinDb(DbContextOptions<BinDb> options)
            : base(options) { }

        public DbSet<Bin> Bins => Set<Bin>();
    }
}