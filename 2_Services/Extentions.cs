using _2_Services.Models;
using _3_Repository;
using _3_Repository.Interfaces;
using _3_Repository.Repositories;
using AutoMapper;
using Entity.Entities;
using Microsoft.AspNetCore.Http;
using Microsoft.Extensions.DependencyInjection;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _2_Services
{
    public static class Extentions
    {
        public static void AddRepoDepend(this IServiceCollection services)
        {
            services.AddScoped<IUser, UserRepository>();
            services.AddScoped<IChild, ChildRepository>();

            MapperConfiguration config = new MapperConfiguration(conf => {
                conf.CreateMap<User, UserModel>().ReverseMap();
                conf.CreateMap<Child, ChildModel>().ReverseMap();
            });
            IMapper Mapper = config.CreateMapper();
            services.AddSingleton(Mapper);
            services.AddDbContext<IDataSource, Context>();
            services.AddSingleton<IHttpContextAccessor, HttpContextAccessor>();
        }
    }
}
