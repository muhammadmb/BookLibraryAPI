using BookLibraryApi.Contexts;
using BookLibraryApi.Repositories.AuthorRepository;
using BookLibraryApi.Repositories.BookReposittory;
using BookLibraryApi.Repositories.GenreRepository;
using EmployeeApi.Services;
using Microsoft.AspNetCore.Builder;
using Microsoft.AspNetCore.Hosting;
using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.DependencyInjection;
using Microsoft.Extensions.Hosting;
using Newtonsoft.Json.Serialization;
using System;

namespace BookLibraryApi
{
    public class Startup
    {
        public Startup(IConfiguration configuration)
        {
            Configuration = configuration;
        }

        public IConfiguration Configuration { get; }

        // This method gets called by the runtime. Use this method to add services to the container.
        public void ConfigureServices(IServiceCollection services)
        {
            services.AddControllers()
                .AddNewtonsoftJson(
                    x => x.SerializerSettings.ReferenceLoopHandling =
                    Newtonsoft.Json.ReferenceLoopHandling.Ignore
                    )
                .AddNewtonsoftJson(
                    x =>
                    {
                        x.SerializerSettings.ContractResolver =
                        new CamelCasePropertyNamesContractResolver();
                    }
                    );

            services.AddDbContext<BookContext>(options =>
            {
                options.UseSqlServer(Configuration.GetConnectionString("EmployeeContext"));
            });

            services.AddAutoMapper(AppDomain.CurrentDomain.GetAssemblies());

            services.AddTransient<IPropertyCheckerService, PropertyCheckerService>();

            services.AddScoped<IGenreRepository, GenreRepository>();
            services.AddScoped<IBookRepository, BookRepository>();
            services.AddScoped<IAuthorRepository, AuthorRepository>();

        }


        // This method gets called by the runtime. Use this method to configure the HTTP request pipeline.
        public void Configure(IApplicationBuilder app, IWebHostEnvironment env)
        {
            if (env.IsDevelopment())
            {
                app.UseDeveloperExceptionPage();
            }

            app.UseRouting();

            app.UseAuthorization();

            app.UseEndpoints(endpoints =>
            {
                endpoints.MapControllers();
            });
        }
    }
}
