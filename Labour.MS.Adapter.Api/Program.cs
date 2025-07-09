using Core.Middleware;
using Labour.MS.Adapter.Api.Extensions;
using Microsoft.OpenApi.Models;

var builder = WebApplication.CreateBuilder(args);

builder.Services.AddSingleton(new HttpClient());

// Add services to the container.
builder.Services.AddApplicationServices(builder.Configuration);

builder.Services.AddControllers();
// Learn more about configuring Swagger/OpenAPI at https://aka.ms/aspnetcore/swashbuckle
builder.Services.AddEndpointsApiExplorer();
builder.Services.AddSwaggerGen();

// Add AutoMapper to build services
//builder.Services.AddAutoMapper(typeof(UserMapper));
builder.Services.AddAutoMapper(AppDomain.CurrentDomain.GetAssemblies());

// Add cors to build services
builder.Services.AddCors(x => x.AddPolicy("corsapp", builder =>
{
    builder.WithOrigins("*").AllowAnyMethod().AllowAnyHeader();
}));

var app = builder.Build();

// Configure the HTTP request pipeline.
if (app.Environment.IsDevelopment())
{
    app.UseSwagger();
    app.UseSwaggerUI();
}


// app cors
app.UseCors("corsapp");

// Configure exception middleware
app.UseMiddleware<CorrelationIdMiddleware>();
app.UseMiddleware<SessionIdMiddleware>();

app.UseHttpsRedirection();

//app.UseAuthentication();

app.UseAuthorization();

app.MapControllers();

app.Run();
