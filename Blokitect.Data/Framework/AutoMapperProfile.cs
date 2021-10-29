using System;
using System.Collections.Generic;
using System.Reflection;
using System.Text;
using System.Linq;
using AutoMapper;
using Blokitect.Data.Models;

namespace Blokitect.Data.Framework
{
    public class AutoMapperProfile : Profile
    {
        public AutoMapperProfile()
        {
            var assembly = typeof(AutoMapperProfile).GetTypeInfo().Assembly;
            var types = assembly.GetExportedTypes();
            this.ConfigureProfile(types);
        }

        private void ConfigureProfile(IEnumerable<Type> types)
        {
            var mapps = (from t in types
                         from i in t.GetInterfaces()
                         where i.GetTypeInfo().IsGenericType && i.GetGenericTypeDefinition() == typeof(IMapFrom<>)
                         //&& !i.GetTypeInfo().IsAbstract
                         //&& !i.GetTypeInfo().IsInterface
                         select new
                         {
                             Source = i.GetGenericArguments()[0],
                             Destination = t,
                         }).ToArray();

            foreach (var map in mapps)
            {
                Console.WriteLine($"{map.Source} is linked to: {map.Destination}");
                this.CreateMap(map.Source, map.Destination);
            }
        }
    }
}
