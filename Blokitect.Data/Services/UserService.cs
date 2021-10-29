using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Claims;
using System.Text;
using System.Threading.Tasks;
using AutoMapper;
using Blokitect.Data.Framework;
using Blokitect.Data.Models;
using Blokitect.Data.Models.Enums;
using Blokitect.Data.ViewModels;
using Microsoft.AspNetCore.Identity;

namespace Blokitect.Data.Services
{
    public class UserService : Service
    {
        private readonly UserManager<AppUser> UserManager;

        private readonly SignInManager<AppUser> SignInManager;

        private readonly CustomerService CustomerService;

        public UserService(
            AppDbContext dbContext,
            IMapper mapper,
            IConfigurationProvider configurationProvider,
            UserManager<AppUser> userManager,
            SignInManager<AppUser> signInManager,
            CustomerService customerService)
            : base(dbContext, mapper, configurationProvider)
        {
            this.UserManager = userManager;
            this.SignInManager = signInManager;
            this.CustomerService = customerService;
        }

        public async Task<ServiceOperationResult> Login(LoginViewModel viewModel)
        {
            var foundUser =
                await this.UserManager.FindByEmailAsync(viewModel.EmailOrUsername)
             ?? await this.UserManager.FindByNameAsync(viewModel.EmailOrUsername);

            if (foundUser != null)
            {
                var signInResult = await this.SignInManager.CheckPasswordSignInAsync(foundUser, viewModel.Password, false);
                if (signInResult.Succeeded)
                {
                    return await this.ProvideToken(foundUser, viewModel.RememberMe);
                }
            }

            return new ServiceOperationResult("Inloggegevens kloppen niet");
        }

        public async Task Logout()
        {
            await this.SignInManager.SignOutAsync();
        }

        public async Task<ServiceOperationResult> RegisterCustomer(RegisterViewModel viewModel)
        {
            foreach (ContactPersonCreateViewModel user in viewModel.ContactPeople)
            {
                var newUser = new ContactPerson
                {
                    Email = user.Email,
                    UserName = $"{user.Firstname[0].ToString().ToUpper()}. {user.Lastname}", // username Example: J. Doe 
                    Id = Guid.NewGuid().ToString(),
                    CompanyId = user.CompanyId,
                    PhoneNumber = user.PhoneNumber.ToString(),
                    IsMainContact = user.IsMainContact,
                    Lastname = user.Lastname,
                    Firstname = user.Firstname,
                    Position = user.Position,                    
                    SupervisorId = user.Supervisor == null ? null : user.Supervisor.Id
                };

                switch(viewModel.UserRole)
                {
                    case UserRole.Admin:
                        newUser.UserRole = UserRole.Admin;
                        break;
                    case UserRole.Customer:
                        newUser.UserRole = UserRole.Customer;
                        break;
                    case UserRole.Supplier:
                        newUser.UserRole = UserRole.Supplier;
                        break;
                    default:
                        throw new ArgumentException("Something went wrong");
                } 

                await this.UserManager.CreateAsync(newUser);                
            }

            var allCustomers = await this.CustomerService.ReadAll();

            if (!allCustomers.Any(i => i.CompanyName == viewModel.CompanyName))
            {
                var companyOfContactPeople = new CustomerCreateViewModel
                {
                    CompanyName = viewModel.CompanyName,
                    ChamberOfCommerceNumber = viewModel.ChamberOfCommerceNumber,
                    MailAddress = viewModel.MailAddress,
                    PhoneNumber = viewModel.PhoneNumber,
                    VATNumber = viewModel.VATNumber,                    
                };

                await this.DbContext.Customers.AddAsync(this.Mapper.Map<Customer>(companyOfContactPeople));
            }

            return await this.SaveChanges();
        }

        public async Task<bool> IsAuthenticated(string userId)
        {
            //this.UserManager.GetAuthenticationTokenAsync();
            throw new NotImplementedException("Method not implemented yet.");
        }



        private async Task<ServiceOperationResult> DestroyToken(AppUser user)
        {
            throw new NotImplementedException("Method not implemented yet.");
        }

        private async Task<ServiceOperationResult> ProvideToken(AppUser user, bool rememberMe)
        {
            switch (user.UserRole)
            {
                case UserRole.Admin:
                    await this.UserManager.SetAuthenticationTokenAsync(user, TokenProvider.Admin.ToString(), (user.UserName ?? user.Email), user.Id.ToString());
                    break;
                case UserRole.Customer:
                    await this.UserManager.SetAuthenticationTokenAsync(user, TokenProvider.Customer.ToString(), (user.UserName ?? user.Email), user.Id.ToString());
                    break;
                case UserRole.Supplier:
                    await this.UserManager.SetAuthenticationTokenAsync(user, TokenProvider.Supplier.ToString(), (user.UserName ?? user.Email), user.Id.ToString());
                    break;
            }

            await this.SignInManager.SignInAsync(user, rememberMe);
            return new ServiceOperationResult(true);
        }
    }
}
