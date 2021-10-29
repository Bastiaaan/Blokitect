using System;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;
using AutoMapper;
using AutoMapper.QueryableExtensions;
using Blokitect.Data.Framework;
using Blokitect.Data.Models;
using Blokitect.Data.ViewModels;
using IConfigurationProvider = AutoMapper.IConfigurationProvider;
using Microsoft.EntityFrameworkCore;

namespace Blokitect.Data.Services
{
    public class ReviewService : Service, ICrudService<Review, ReviewViewModel, ReviewCreateViewModel, ReviewEditViewModel>
    {
        public ReviewService(AppDbContext dbContext, IMapper mapper, IConfigurationProvider provider) : base(dbContext, mapper, provider)
        {

        }

        public ReviewCreateViewModel Create()
        {
            return new ReviewCreateViewModel();
        }

        public Task<ServiceOperationResult> Create(ReviewCreateViewModel viewModel)
        {
            throw new NotImplementedException();
        }

        public Task<ServiceOperationResult> Delete(long id, ReviewViewModel viewModel)
        {
            throw new NotImplementedException();
        }

        public async Task<IList<ReviewViewModel>> ReadAll()
        {
            return await this
                .DbContext
                .Reviews
                .ProjectTo<ReviewViewModel>(this.ConfigurationProvider)
                .ToListAsync();
        }

        public Task<ReviewViewModel> ReadById(long id)
        {
            throw new NotImplementedException();
        }

        public ReviewEditViewModel Update()
        {
            return new ReviewEditViewModel();
        }

        public Task<ServiceOperationResult> Update(long id, ReviewEditViewModel viewModel)
        {
            throw new NotImplementedException();
        }
    }
}
