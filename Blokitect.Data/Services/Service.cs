using System;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;
using AutoMapper.QueryableExtensions;
using Blokitect.Data;
using AutoMapper;
using Blokitect.Data.Framework;

namespace Blokitect.Data.Services
{
    public class Service
    {
        protected readonly AppDbContext DbContext;

        protected readonly IMapper Mapper;

        protected readonly IConfigurationProvider ConfigurationProvider;

        public Service(AppDbContext dbContext, IMapper mapper, IConfigurationProvider configurationProvider)
        {
            this.DbContext = dbContext;
            this.Mapper = mapper;
            this.ConfigurationProvider = configurationProvider;
        }

        private void DetermineChanges()
        {

        }

        protected async Task<ServiceOperationResult> SaveChanges()
        {
            this.DetermineChanges();
            return new ServiceOperationResult(
                await this.DbContext.SaveChangesAsync() > 0);
        }
    }
}
