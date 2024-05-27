using Microsoft.EntityFrameworkCore;

namespace DesignPattern.Mediator.DAL
{
    public class Context :DbContext
    {
        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            optionsBuilder.UseSqlServer("server=MSI;initial catalog=DesigPatternMediator;integrated security=true;");
        }
        public  DbSet<Product> Products { get; set; }
    }
}
