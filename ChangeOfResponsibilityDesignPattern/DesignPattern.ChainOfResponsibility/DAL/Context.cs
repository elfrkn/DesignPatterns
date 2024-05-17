using Microsoft.EntityFrameworkCore;

namespace DesignPattern.ChainOfResponsibility.DAL
{
    public class Context :DbContext
    {
        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            optionsBuilder.UseSqlServer("server=MSI;initial catalog=DesigPatternCOR;integrated security=true;");
        }
        public  DbSet<CustomerProcess> CustomerProcesses { get; set; }
    }
}
