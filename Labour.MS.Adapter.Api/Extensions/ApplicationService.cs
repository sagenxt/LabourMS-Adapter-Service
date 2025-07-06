using Core.ApiResponse.Implementation;
using Core.ApiResponse.Interface;
using Core.MSSQL.DataAccess;
using FluentValidation;
using Labour.MS.Adapter.Models.DTOs.Request.Establishment;
using Labour.MS.Adapter.Repository.Implement.Establishment;
using Labour.MS.Adapter.Repository.Interface.Establishment;
using Labour.MS.Adapter.Service.Implement.Establishment;
using Labour.MS.Adapter.Service.Interface.Establishment;
using Labour.MS.Adapter.Service.Validators.Establishment;

namespace Labour.MS.Adapter.Api.Extensions
{
    public static class ApplicationService
    {
        /// <summary>
        /// 
        /// </summary>
        /// <param name="services"></param>
        /// <param name="config"></param>
        /// <returns></returns>
        public static IServiceCollection AddApplicationServices(this IServiceCollection services, IConfiguration config)
        {
            // Add IApiResponseFactory to the container
            services.AddSingleton<IHttpContextAccessor, HttpContextAccessor>();
            services.AddSingleton<ITraceProvider, TraceProvider>();
            services.AddTransient<IApiResponseFactory, ApiResponseFactory>();

            services.AddScoped<IHttpStatusCodeResolver, HttpStatusCodeResolver>();

            // Add Core Data Access service to the container.
            services.AddScoped<IWrapperDbContext, WrapperDbContext>();

            // Add Repositories to the container.
            services.AddScoped<IEstablishmentRepository, EstablishmentRepository>();

            // Add Services to the container.
            services.AddScoped<IEstablishmentService, EstablishmentService>();

            // Add Validators to the container.
            services.AddScoped<IValidator<EstablishmentDetailsRequest>, EstablishmentRequestDetailValidator>();
            services.AddScoped<IValidator<EstablishmentRequest>, EstablishmentRequestValidator>();

            return services;
        }


    }
}
