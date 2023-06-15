using APICarrefourContasPagar.Dominio;
using APICarrefourContasPagar.Interface;
using APIContasaPagarCarrefour.dominio;
using APIContasaPagarCarrefour.Repository;
using Microsoft.EntityFrameworkCore;
using Microsoft.OpenApi.Models;

namespace APIContasaPagarCarrefour
{
    public class Startup
    {
        public void ConfigureServices(IServiceCollection services)
        {
            string connectionString = Configuration.GetConnectionString("DefaultConnection");
            // Configurações e serviços aqui
            services.AddAuthorization();
            services.AddControllers();
            services.AddScoped<IContaPagarRepository, APIContaPagarRepository>();
            //services.AddDbContext<ContasContext>(); 
            // Adicionar o serviço do Swagger
            services.AddSwaggerGen(c =>
            {
                c.SwaggerDoc("v1", new OpenApiInfo { Title = "APICOntasaPagarCarrefour", Version = "v1" });
            });
        }

        private IConfiguration Configuration { get; }

        public Startup(IConfiguration configuration)
        {
            Configuration = configuration;
        }
        public void Configure(IApplicationBuilder app, IWebHostEnvironment env)
        {
            if (env.IsDevelopment())
            {
                app.UseDeveloperExceptionPage();
            }
            else
            {
                app.UseExceptionHandler("/Home/Error");
                app.UseHsts();
            }

            app.UseHttpsRedirection();
            app.UseStaticFiles();

            app.UseRouting();
            app.UseSwagger();
            app.UseSwaggerUI(c =>
            {
                c.SwaggerEndpoint("/swagger/v1/swagger.json", "Nome da API v1");
            });


            app.UseAuthorization();

            app.UseEndpoints(endpoints =>
            {
                endpoints.MapControllerRoute(
                    name: "default",
                    pattern: "{controller=Home}/{action=Index}/{id?}");
            });
        }
        //public void ConfigureServices(IServiceCollection services)
        //{

        //    var connectionString = Configuration.GetConnectionString("DefaultConnection");

        //    services.AddSingleton<IConfiguration>(Configuration);

        //    services.AddDbContext<ContasContext>(options =>
        //        options.UseSqlite(Configuration.GetConnectionString("DefaultConnection")));
        //    services.AddScoped<IContaPagarRepository, APIContaPagarRepository>();
        //}
    }
}
