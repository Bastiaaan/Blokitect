using System;
using System.Collections.Generic;
using System.Text;
using AutoMapper.QueryableExtensions;
using Blokitect.Data.Models;
using Blokitect.Data.Services;
using Blokitect.Data.ViewModels;
using Microsoft.Extensions.DependencyInjection;
using Microsoft.Extensions.Configuration;
using Microsoft.IdentityModel.Tokens;
using Microsoft.AspNetCore.Authentication.JwtBearer;
using Microsoft.AspNetCore.Identity;
using Microsoft.EntityFrameworkCore;
using Microsoft.AspNetCore.Http;

namespace Blokitect.Data.Framework
{
    public static class ConfigurationExtensions
    {
        public static void InjectCustomDependencies(this IServiceCollection serviceDescriptors, IConfiguration configuration)
        {
            serviceDescriptors.AddDbContext<AppDbContext>(opt =>
                opt.UseSqlServer(configuration["DatabaseConnections:DefaultConnection"])
            );

            serviceDescriptors.AddIdentityCore<AppUser>().AddRoles<IdentityRole>()
                .AddEntityFrameworkStores<AppDbContext>()
                .AddDefaultTokenProviders();

            serviceDescriptors.AddTransient<RoleManager<IdentityRole>>();
            serviceDescriptors.AddTransient<UserManager<AppUser>>();
            serviceDescriptors.AddTransient<SignInManager<AppUser>>();
            serviceDescriptors.AddTransient<CustomerService>();
            serviceDescriptors.AddTransient<UserService>();
            serviceDescriptors.AddTransient<ProjectService>();
            serviceDescriptors.AddTransient<ReviewService>();
            serviceDescriptors.AddTransient<ManyToManyService<Model, Model, ManyToMany>>();
            serviceDescriptors.AddTransient<SupplierService>();
            serviceDescriptors.AddTransient<ContactPersonService>();
            serviceDescriptors.AddTransient<ComponentService>();
            serviceDescriptors.AddSingleton<IHttpContextAccessor, HttpContextAccessor>(); // Required to activate the API
        }

        public static void InjectAutoMapperProfile(this IServiceCollection serviceDescriptors, IConfiguration configuration)
        {
            serviceDescriptors.AddAutoMapper(typeof(AutoMapperProfile));
        }

        public static void InjectAuthTokenSettings(this IServiceCollection services, IConfiguration configuration)
        {
            var key = Encoding.ASCII.GetBytes(configuration["App_Secret:JWTToken"].ToString());
            services.AddAuthentication(x =>
            {
                x.DefaultAuthenticateScheme = JwtBearerDefaults.AuthenticationScheme;
                x.DefaultScheme = JwtBearerDefaults.AuthenticationScheme;
                x.DefaultChallengeScheme = JwtBearerDefaults.AuthenticationScheme;

            }).AddJwtBearer(x => {
                x.RequireHttpsMetadata = false;
                x.SaveToken = true;
                x.TokenValidationParameters = new TokenValidationParameters
                {
                    ValidateIssuerSigningKey = true,
                    IssuerSigningKey = new SymmetricSecurityKey(key),
                    ValidateIssuer = false,
                    ValidateAudience = false,
                    ClockSkew = TimeSpan.Zero
                };
            }); 

            services.ConfigureExternalCookie(config =>
            {
                config.Cookie.HttpOnly = true;
            });
        }
    }
}
