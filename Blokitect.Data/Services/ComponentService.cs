using AutoMapper;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Blokitect.Data.Models;
using Blokitect.Data.ViewModels;
using Blokitect.Data.Framework;

namespace Blokitect.Data.Services
{
    public class ComponentService : Service, ICrudService<Component, ComponentViewModel, ComponentCreateViewModel, ComponentEditViewModel>
    {
        public ComponentService(AppDbContext dbContext, IMapper mapper, IConfigurationProvider configurationProvider) : base(dbContext, mapper, configurationProvider)
        {

        }

        public ComponentCreateViewModel Create()
        {
            return new ComponentCreateViewModel();
        }

        public async Task<ServiceOperationResult> Create(ComponentCreateViewModel viewModel)
        {
            throw new NotImplementedException();
        }

        public async Task<ServiceOperationResult> Delete(long id, ComponentViewModel viewModel)
        {
            throw new NotImplementedException();
        }

        public async Task<IList<ComponentViewModel>> ReadAll()
        {
            throw new NotImplementedException();
        }

        public async Task<ComponentViewModel> ReadById(long id)
        {
            throw new NotImplementedException();
        }

        public ComponentEditViewModel Update()
        {
            return new ComponentEditViewModel();
        }

        public async Task<ServiceOperationResult> Update(long id, ComponentEditViewModel viewModel)
        {
            throw new NotImplementedException();
        }
    }
}
