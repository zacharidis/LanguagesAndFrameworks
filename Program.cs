using LanguagesAndFrameworks.Data;
using Microsoft.EntityFrameworkCore;

var builder = WebApplication.CreateBuilder(args);
 /*
 *  Programming Languages and frameworks 
 *  A small Web Api (.NET 6 ) that returns various programming languages ,their frameworks and the type of projects you can create by using them. 
 *  Thank you for reading this code on github
 *  written by Georgios Zacharidis while practising C# and Core Framework.
 *  zageo@Outlook.com
 *  
 * **/
// Add services to the container.

builder.Services.AddControllers();
// Learn more about configuring Swagger/OpenAPI at https://aka.ms/aspnetcore/swashbuckle
builder.Services.AddEndpointsApiExplorer();
builder.Services.AddSwaggerGen();

//------------------inject the DbContext

builder.Services.AddDbContext<LanguageDbContext>(options =>
{
    options.UseSqlServer(builder.Configuration.GetConnectionString("LanguagesAndFrameworks"));
});

var app = builder.Build();

// Configure the HTTP request pipeline.
if (app.Environment.IsDevelopment())
{
    app.UseSwagger();
    app.UseSwaggerUI();
}

app.UseHttpsRedirection();

app.UseAuthorization();

app.MapControllers();

app.Run();



