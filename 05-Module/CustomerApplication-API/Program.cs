
namespace CustomerApplication_API
{
    using CustomerApplication_API.Data;
    using CustomerApplication_API.Services;
    using CustomerApplication_API.Services.Interfaces;
    using Microsoft.EntityFrameworkCore;

    public class Program
    {
        public static void Main(string[] args)
        {
            var builder = WebApplication.CreateBuilder(args);

            builder.Services.AddControllers(opt =>
            {
                opt.ReturnHttpNotAcceptable = true;
            }).AddNewtonsoftJson() //config json inputs and outputs
                .AddXmlDataContractSerializerFormatters(); //in case if we have to return xml instead of json
            builder.Services.AddEndpointsApiExplorer();


            var connectionString = builder.Configuration
                .GetConnectionString("DefaultConnection");

            builder.Services.AddDbContext<CustomerApplicationDbContext>(opt =>
            {
                opt.UseSqlServer(connectionString);
            });

            builder.Services.AddScoped<ICustomerService, CustomerService>();
            builder.Services.AddScoped<ICustomerRepository, CustomerRepository>();
            
            builder.Services.AddSwaggerGen();


            var app = builder.Build();

            if (app.Environment.IsDevelopment())
            {
                app.UseSwagger();
                app.UseSwaggerUI();
            }

            app.UseHttpsRedirection();

            app.UseRouting();

            app.UseAuthorization();

            app.UseEndpoints(endpoints =>
            {
                endpoints.MapControllers();
            });

            app.MapControllers();

            app.Run();
        }
    }
}
