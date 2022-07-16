using KindergartenApp.Infrastructure;
using KindergartenApp.Options;

namespace KindergartenApp;

public class Startup
{
    private readonly IConfiguration _configuration;
    
    public Startup(IConfiguration configuration)
    {
        _configuration = configuration;
    }

    public void ConfigureServices(IServiceCollection services)
    {
        services.AddMvc();
        services.AddSwaggerGen();

        services.Configure<Settings>(options =>
        {
            options.ConnectionString = _configuration.GetSection("MongoConnection:ConnectionString").Value;
            options.Database = _configuration.GetSection("MongoConnection:Database").Value;
        });

        services.AddScoped<IRepository, Repository>();
    }

    public void Configure(IApplicationBuilder app, IWebHostEnvironment env)
    {
        app.UseSwagger();
        app.UseSwaggerUI();

        app.UseStaticFiles();
        app.UseStatusCodePages();
        app.UseRouting();

        app.UseEndpoints(endpoints =>
        {
            endpoints.MapControllers();
        });
    }
}