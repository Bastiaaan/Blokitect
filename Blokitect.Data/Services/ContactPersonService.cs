using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using IConfigurationProvider = AutoMapper.IConfigurationProvider;
using System.Threading.Tasks;
using AutoMapper;
using AutoMapper.QueryableExtensions;
using Blokitect.Data.Framework;
using Blokitect.Data.Models;
using Blokitect.Data.ViewModels;
using Microsoft.EntityFrameworkCore;

namespace Blokitect.Data.Services
{
    public class ContactPersonService : Service, ICrudService<ContactPerson, ContactPersonViewModel, ContactPersonCreateViewModel, ContactPersonEditViewModel>
    {

        public ContactPersonService(AppDbContext dbContext, IMapper mapper, IConfigurationProvider configurationProvider)
            : base(dbContext, mapper, configurationProvider)
        {

        }

        public ContactPersonCreateViewModel Create()
        {
            return new ContactPersonCreateViewModel();
        }

        public async Task<ServiceOperationResult> Create(ContactPersonCreateViewModel viewModel)
        {
            throw new NotImplementedException();
        }

        public async Task<ServiceOperationResult> Delete(long id, ContactPersonViewModel viewModel)
        {
            throw new NotImplementedException();
        }

        public async Task<IList<ContactPersonViewModel>> ReadAll()
        {
            try
            {
                return await this.DbContext
                    .ContactPeople
                    .ProjectTo<ContactPersonViewModel>(this.ConfigurationProvider)
                    .ToListAsync();
            }
            catch(Exception)
            {
                throw;
            }
        }

        public async Task<ContactPersonViewModel> ReadById(long id)
        {
            throw new NotImplementedException();
        }

        public ContactPersonEditViewModel Update()
        {
            return new ContactPersonEditViewModel();
        }

        public async Task<ServiceOperationResult> Update(long id, ContactPersonEditViewModel viewModel)
        {
            throw new NotImplementedException();
        }
    }
}
