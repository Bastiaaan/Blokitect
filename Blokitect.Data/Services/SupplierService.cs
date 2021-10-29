using System;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;
using AutoMapper;
using AutoMapper.QueryableExtensions;
using Blokitect.Data.Framework;
using Blokitect.Data.Models;
using Blokitect.Data.ViewModels;
using Microsoft.EntityFrameworkCore;

namespace Blokitect.Data.Services
{
    public class SupplierService : Service, ICrudService<Supplier, SupplierViewModel, SupplierCreateViewModel, SupplierEditViewModel>
    {
        public SupplierService(AppDbContext dbContext, IMapper mapper, IConfigurationProvider configurationProvider) 
            : base(dbContext, mapper, configurationProvider)
        {
                
        }

        public SupplierCreateViewModel Create()
        {
            return new SupplierCreateViewModel();
        }

        public Task<ServiceOperationResult> Create(SupplierCreateViewModel viewModel)
        {
            throw new NotImplementedException();
        }

        public Task<ServiceOperationResult> Delete(long id, SupplierViewModel viewModel)
        {
            throw new NotImplementedException();
        }

        public async Task<IList<SupplierViewModel>> ReadAll()
        {
            try
            {
                return await this.DbContext
                    .Suppliers
                    .ProjectTo<SupplierViewModel>(this.ConfigurationProvider)
                    .ToListAsync();
            }
            catch(InvalidOperationException)
            {
                throw;
            }
        }

        public Task<SupplierViewModel> ReadById(long id)
        {
            throw new NotImplementedException();
        }

        public SupplierEditViewModel Update()
        {
            return new SupplierEditViewModel();
        }

        public Task<ServiceOperationResult> Update(long id, SupplierEditViewModel viewModel)
        {
            throw new NotImplementedException();
        }
    }
}
