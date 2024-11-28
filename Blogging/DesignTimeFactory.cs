
using Blogging.Model;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Design;


namespace Blogging
{
    internal class DesignTimeFactory : IDesignTimeDbContextFactory<BlogContext>
    {
        public BlogContext CreateDbContext(string[] args)
        {
            var optionsBuilder = new DbContextOptionsBuilder<BlogContext>()
                .UseSqlite("Data Source=test.db", b => b.MigrationsAssembly("Blogging"))
                ;

            return new BlogContext(optionsBuilder.Options);
        }
    }
}
