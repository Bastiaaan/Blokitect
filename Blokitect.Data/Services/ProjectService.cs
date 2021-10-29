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
    public class ProjectService : Service, ICrudService<Project, ProjectViewModel, ProjectCreateViewModel, ProjectEditViewModel>
    {
        public ProjectService(AppDbContext dbContext, IMapper mapper, IConfigurationProvider configurationProvider) : base(dbContext, mapper, configurationProvider)
        {

        }

        public async Task<ServiceOperationResult> Create(ProjectCreateViewModel viewModel)
        {
            if(this.DbContext.Projects.Find(viewModel.Name) == null)
            {
                var dbModel = this.Mapper.Map<Project>(viewModel);
                this.DbContext.Projects.Add(dbModel);
                return await this.SaveChanges();
            }

            throw new Exception("Dit project bestaat al");
        }

        public async Task<ServiceOperationResult> Delete(long id, ProjectViewModel viewModel)
        {
            return await this.SaveChanges();
        }

        public async Task<IList<ProjectViewModel>> ReadAll()
        {
            return await this.DbContext
                .Projects
                .Include(i => i.Components)
                .Where(i => i.IsOnline)
                .ProjectTo<ProjectViewModel>(this.ConfigurationProvider)
                .ToListAsync();

            //TODO: If supplier had several projects made within the same sector. 
            // This helps suppliers' last experience to create even better apps for future customers/clients
        }

        public async Task<ProjectViewModel> ReadById(long id)
        {
            throw new NotImplementedException();
        }

        public async Task<ServiceOperationResult> Update(long id, ProjectEditViewModel viewModel)
        {
            return await this.SaveChanges();
        }

        public ProjectCreateViewModel Create()
        {
            return new ProjectCreateViewModel();
        }

        public ProjectEditViewModel Update()
        {
            return new ProjectEditViewModel();
        }
    }
}
