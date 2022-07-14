using Economic.Application.Interface;
using Economic.Application.Services;
using Economic.Data.EF;

using Microsoft.EntityFrameworkCore;
using Microsoft.OpenApi.Models;
using System.Configuration;
using Microsoft.AspNetCore.Identity;
using Microsoft.Extensions.FileProviders;

var builder = WebApplication.CreateBuilder(args);

// Add services to the container.

builder.Services.AddHttpClient();

builder.Services.AddControllers();
// Learn more about configuring Swagger/OpenAPI at https://aka.ms/aspnetcore/swashbuckle
builder.Services.AddEndpointsApiExplorer();
builder.Services.AddSwaggerGen();

builder.Services.AddCors(options =>
{
    options.AddPolicy(name: "CORS",
                      policy =>
                      {
                          policy.AllowAnyOrigin()
                          .AllowAnyMethod()
                          .AllowAnyHeader();
                      });
});


builder.Services.AddDbContext<EconomicDbContext>(options =>
                options.UseSqlServer(builder.Configuration.GetConnectionString("EconomicDb")));


builder.Services.AddControllers();
builder.Services.AddSwaggerGen(c =>
{
    c.SwaggerDoc("v1", new OpenApiInfo { Title = "Economic.Api", Version = "v1" });
});

//add automapper
//builder.services.addautomapper(appdomain.currentdomain.getassemblies());
builder.Services.AddAutoMapper(typeof(Program).Assembly);

//Declare DI
builder.Services.AddTransient<IProductService, ProductService>();

builder.Services.AddTransient<IProductImageService, ProductImageService>();

builder.Services.AddTransient<IProductTypeService, ProductTypeService>();

builder.Services.AddTransient<ICommentService, CommentService>();

builder.Services.AddTransient<IUserService, UserService>();



var app = builder.Build();

// Configure the HTTP request pipeline.
if (app.Environment.IsDevelopment())
{
    app.UseSwagger();
    //app.UseSwaggerUI();
    app.UseSwaggerUI(c => c.SwaggerEndpoint("/swagger/v1/swagger.json", "Economic.Api v1"));

}

// Configure the HTTP request pipeline.
if (app.Environment.IsDevelopment())
{
    app.UseSwagger();
    app.UseSwaggerUI();
}

app.UseCors("CORS");

app.UseHttpsRedirection();

//app.UseStaticFiles(new StaticFileOptions
//{
//    FileProvider = new PhysicalFileProvider(
//           Path.Combine(builder.Environment.ContentRootPath, "Images")),
//    RequestPath = "/Uploads"
//});

//var webRootProvider = new PhysicalFileProvider(builder.Environment.WebRootPath);
//var newPathProvider = new PhysicalFileProvider(
//  Path.Combine(builder.Environment.ContentRootPath, "Uploads"));

//var compositeProvider = new CompositeFileProvider(webRootProvider,
//                                                  newPathProvider);

//// Update the default provider.
//app.Environment.WebRootFileProvider = compositeProvider;

app.UseStaticFiles();


app.UseAuthorization();

app.MapControllers();

app.Run();
