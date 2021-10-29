using System;
using System.Collections.Generic;
using System.Linq;
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
    public class CustomerService : Service, ICrudService<Customer, CustomerViewModel, CustomerCreateViewModel, CustomerEditViewModel>
    {
        private readonly ProjectService ProjectService;

        public CustomerService(
            AppDbContext dbContext, 
            IMapper mapper, 
            IConfigurationProvider configurationProvider,
            ProjectService projectService) : base(dbContext, mapper, configurationProvider)
        {
            this.ProjectService = projectService;
        }

        public CustomerCreateViewModel Create()
        {
            return new CustomerCreateViewModel();
        }

        public async Task<ServiceOperationResult> Create(CustomerCreateViewModel viewModel)
        {
            try
            {
                foreach (var contactPerson in viewModel.ContactPeople)
                {
                    var _contactPerson = this.Mapper.Map<ContactPerson>(contactPerson);
                    //this.UserService.Register()
                }

                var model = this.Mapper.Map<Customer>(viewModel);
                this.DbContext.Customers.Add(model);

                return await this.SaveChanges();
            }
            catch (ArgumentException)
            {
                throw;
            }
        }

        public Task<ServiceOperationResult> Delete(long id, CustomerViewModel viewModel)
        {
            throw new NotImplementedException();
        }

        public async Task<IList<CustomerViewModel>> ReadAll()
        {
            return await this.DbContext
                .Customers  
                .ProjectTo<CustomerViewModel>(this.ConfigurationProvider)
                .ToListAsync();
        }

        public Task<CustomerViewModel> ReadById(long id)
        {
            throw new NotImplementedException();
        }

        public CustomerEditViewModel Update()
        {
            return new CustomerEditViewModel();
        }

        public Task<ServiceOperationResult> Update(long id, CustomerEditViewModel viewModel)
        {
            throw new NotImplementedException();
        }
    }
}
