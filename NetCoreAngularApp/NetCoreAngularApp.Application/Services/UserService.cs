using AutoMapper;
using NetCoreAngularApp.Application.Interfaces;
using NetCoreAngularApp.Application.ViewModels;
using NetCoreAngularApp.Auth.Services;
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

        private readonly IMapper mapper;

        public UserService(IUserRepository userRepository, IMapper mapper)
        {
            this.userRepository = userRepository;
            this.mapper = mapper;
        }

        public List<UserViewModel> Get()
        {
            List<UserViewModel> _userViewModels = new List<UserViewModel>();

            IEnumerable<User> _users = userRepository.GetAll();

            _userViewModels = mapper.Map<List<UserViewModel>>(_users);

            //Without AutoMapper

            //foreach(var item in _users)
            //    _userViewModels.Add(new UserViewModel { Id = item.Id, Email = item.Email, Name = item.Name });

            return _userViewModels;
        }

        public bool Post(UserViewModel userViewModel)
        {
            //Without AutoMapper

            //User _user = new User
            //{
            //    Id = Guid.NewGuid(),
            //    Email = userViewModel.Email,
            //    Name = userViewModel.Name
            //};

            if (userViewModel.Id != Guid.Empty)
                throw new Exception("UserID must be empty");

            User _user = mapper.Map<User>(userViewModel);

            userRepository.Create(_user);

            return true;
        }

        public UserViewModel GetById(string id)
        {
            if (!Guid.TryParse(id, out Guid userId))
                throw new Exception("UserID is not valid");

            User _user = userRepository.Find(x => x.Id == userId && !x.IsDeleted);
            if (_user == null)
                throw new Exception("User not found");

            return mapper.Map<UserViewModel>(_user);
        }

        public bool Put(UserViewModel userViewModel)
        {
            if (userViewModel.Id == Guid.Empty)
                throw new Exception("ID is invalid");

            User _user = userRepository.Find(x => x.Id == userViewModel.Id && !x.IsDeleted);
            if (_user == null)
                throw new Exception("User not found");

            _user = mapper.Map<User>(userViewModel);

            userRepository.Update(_user);

            return true;
        }

        public bool Delete(string id)
        {
            if (!Guid.TryParse(id, out Guid userId))
                throw new Exception("UserID is not valid");

            User _user = userRepository.Find(x => x.Id == userId && !x.IsDeleted);
            if (_user == null)
                throw new Exception("User not found");

            userRepository.Delete(_user);

            return true;
        }

        public UserAuthenticateResponseViewModel Authenticate(UserAuthenticateRequestViewModel user)
        {
            if (string.IsNullOrEmpty(user.Email))
                throw new Exception("Email/Password are required.");
            
            User _user = userRepository.Find(x => !x.IsDeleted && x.Email.ToLower() == user.Email.ToLower());
            if (_user == null)
                throw new Exception("User not found");

            return new UserAuthenticateResponseViewModel(mapper.Map<UserViewModel>(_user), TokenService.GenerateToken(_user));
        }
    }
}
