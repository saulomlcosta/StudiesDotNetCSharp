using NetCoreAngularApp.Application.Interfaces;
using NetCoreAngularApp.Application.ViewModels;
using NetCoreAngularApp.Domain.Entities;
using NetCoreAngularApp.Domain.Interfaces;
using System;
using System.Collections.Generic;
using System.Text;

namespace NetCoreAngularApp.Application.Services
{
    public class UserService : IUserService
    {
        private readonly IUserRepository userRepository;

        public UserService(IUserRepository userRepository)
        {
            this.userRepository = userRepository;
        }

        public List<UserViewModel> Get()
        {
            List<UserViewModel> _userViewModels = new List<UserViewModel>();

            IEnumerable<User> _users = this.userRepository.GetAll();

            foreach(var item in _users)
                _userViewModels.Add(new UserViewModel { Id = item.Id, Email = item.Email, Name = item.Name });

            return _userViewModels;
        }
    }
}
