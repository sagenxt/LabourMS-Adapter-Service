﻿using Core.ApiResponse.Implementation;
using Core.ApiResponse.Interface;
using Core.MSSQL.DataAccess;
using FluentValidation;
using Labour.MS.Adapter.Models.DTOs.Request.Establishment;
using Labour.MS.Adapter.Repository.Implement.Establishment;
using Labour.MS.Adapter.Repository.Implement.Masters;
using Labour.MS.Adapter.Repository.Interface.Establishment;
using Labour.MS.Adapter.Repository.Interface.Masters;
using Labour.MS.Adapter.Service.Implement.Establishment;
using Labour.MS.Adapter.Service.Implement.Masters;
using Labour.MS.Adapter.Service.Interface.Establishment;
using Labour.MS.Adapter.Service.Interface.Masters;
using Labour.MS.Adapter.Service.Validators.Establishment;

namespace Labour.MS.Adapter.Api.Extensions
{
    public static class ServiceCollectionExtension
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

            services.AddScoped<IVillageAreaService, VillageAreaService>();
            services.AddScoped<IVillageAreaRepository, VillageAreaRepository>();

            services.AddScoped<ICitiesService, CitiesService>();
            services.AddScoped<ICitiesRepository, CitiesRepository>();

            services.AddScoped<IDistrictsService, DistrictsService>();
            services.AddScoped<IDistrictsRepository, DistrictsRepository>();

            return services;
        }


    }
}
