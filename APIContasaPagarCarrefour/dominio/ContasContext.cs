
using APICarrefourContasPagar.Dominio;
using Microsoft.EntityFrameworkCore;




namespace APIContasaPagarCarrefour.dominio
{
    public class ContasContext : DbContext
    {
        private ContasContext _context;

        public DbSet<ContaPagar> ContasPagar { get; set; }

        public ContasContext(DbContextOptions<ContasContext> options) : base(options)
        {

        }
        public ContasContext() 
        {
        }

        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            IConfigurationRoot configuration = new ConfigurationBuilder()
       .SetBasePath(Directory.GetCurrentDirectory())
       .AddJsonFile("appsettings.json")
       .Build();

            string connectionString = configuration.GetConnectionString("DefaultConnection");


            optionsBuilder.UseSqlite(connectionString);
        }

    }
}
