using Contact.Api.Communication;
using Contact.Repository;
using Contact.Service;

var builder = WebApplication.CreateBuilder(args);

// Add services to the container.
IConfiguration Configuration = builder.Configuration;
IWebHostEnvironment environment = builder.Environment;

AppContext.SetSwitch("Npgsql.EnableLegacyTimestampBehavior", true); // Configuration Datetime For postgresql

builder.Services.AddControllers();
builder.Services.AddEndpointsApiExplorer();
builder.Services.AddSwaggerGen();
builder.Services.AddGrpc();

builder.Services.AddRepositories(Configuration);
builder.Services.AddServices();

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
app.MapGrpcService<ContactGrpc>();

app.Run();
