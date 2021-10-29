using System;
using System.Collections.Generic;
using System.Linq;
using System.Reflection;
using System.Text;
using System.Threading.Tasks;
using AutoMapper;
using Blokitect.Data.Framework;
using Blokitect.Data.Models;
using Microsoft.EntityFrameworkCore;

namespace Blokitect.Data.Services
{
    public class ManyToManyService<T1, T2, MTM> : Service
        where T1 : Model
        where T2 : Model
        where MTM : ManyToMany
    {

        private readonly MTM ManyToMany;

        public ManyToManyService(AppDbContext dbContext, IMapper mapper, IConfigurationProvider provider) : base(dbContext, mapper, provider)
        {

        }

        public async Task<ServiceOperationResult> CreateRelation(T1 t1, T2 t2)
        {
            if (!this.RelationExists(t1, t2))
            {
                this.DbContext.Set<T1>().Add(t1);
                this.DbContext.Set<T2>().Add(t2);

                var mtm = this.DbContext.Entry(this.ManyToMany).Entity;
                return await this.SaveChanges();
            }

            throw new ArgumentException("This relationship already exists");
        }

        private string T1Name { get { return typeof(T1).Name; } }

        private string T2Name { get { return typeof(T2).Name; } }

        public bool RelationExists(T1 t1, T2 t2)
        {
            var manyToMany = typeof(MTM).GetTypeInfo();
            var table1Id = manyToMany.GetProperty(this.T1Name + "Id");
            var table2Id = manyToMany.GetProperty(this.T2Name + "Id");

            table1Id.SetValue(t1, t1.Id);
            table2Id.SetValue(t2, t2.Id);

            return default;
        }

        public async Task<ServiceOperationResult> DeleteRelation(T1 t1, T2 t2)
        {
            return await this.SaveChanges();
        }
    }
}
