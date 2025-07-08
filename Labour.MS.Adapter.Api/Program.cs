using Core.Middleware;
using Labour.MS.Adapter.Api.Extensions;
using Labour.MS.Adapter.Repository.Implement.Masters;
using Labour.MS.Adapter.Repository.Interface.Masters;
using Labour.MS.Adapter.Service.Implement.Masters;
using Labour.MS.Adapter.Service.Interface.Masters;
using Microsoft.OpenApi.Models;

var builder = WebApplication.CreateBuilder(args);

builder.Services.AddSingleton(new HttpClient());

// Add services to the container.
builder.Services.AddApplicationServices(builder.Configuration);

builder.Services.AddControllers();
// Learn more about configuring Swagger/OpenAPI at https://aka.ms/aspnetcore/swashbuckle
builder.Services.AddEndpointsApiExplorer();
builder.Services.AddSwaggerGen(c =>
{
   

    c.SwaggerDoc("v1", new OpenApiInfo { Title = "Villages-Areas API", Version = "v1" });

    c.DocInclusionPredicate((docName, apiDesc) =>
    {
        // Only include MyController
        var controllerName = apiDesc.ActionDescriptor.RouteValues["controller"];
        return controllerName == "VillagesAreas";
    });

    //c.SwaggerDoc("v1", new OpenApiInfo { Title = "Cities API", Version = "v1" });

    //c.DocInclusionPredicate((docName, apiDesc) =>
    //{
    //    // Only include MyController
    //    var controllerName = apiDesc.ActionDescriptor.RouteValues["controller"];
    //    return controllerName == "Cities";
    //});

    //c.SwaggerDoc("v1", new OpenApiInfo { Title = "Districts API", Version = "v1" });

    //c.DocInclusionPredicate((docName, apiDesc) =>
    //{
    //    // Only include MyController
    //    var controllerName = apiDesc.ActionDescriptor.RouteValues["controller"];
    //    return controllerName == "Districts";
    //});
});
builder.Services.AddScoped<IVillageAreaService, VillageAreaService>();
builder.Services.AddScoped<IVillageAreaRepository, VillageAreaRepository>();

builder.Services.AddScoped<ICitiesService, CitiesService>();
builder.Services.AddScoped<ICitiesRepository, CitiesRepository>();

builder.Services.AddScoped<IDistrictsService, DistrictsService>();
builder.Services.AddScoped<IDistrictsRepository, DistrictsRepository>();



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
