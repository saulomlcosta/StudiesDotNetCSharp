using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using AutoMapper;
using Moq;
using NetCoreAngularApp.Application.AutoMapper;
using NetCoreAngularApp.Application.Services;
using NetCoreAngularApp.Application.ViewModels;
using NetCoreAngularApp.Domain.Entities;
using NetCoreAngularApp.Domain.Interfaces;
using Xunit;

namespace NetCoreAngularApp.Application.Tests.Services
{
    public class UserServiceTests
    {
        private UserService userService;

        public UserServiceTests()
        {
            userService = new UserService(new Mock<IUserRepository>().Object, new Mock<IMapper>().Object);
        }

        #region ValidatingSendingID

        [Fact]
        public void Post_SendingValidId()
        {
            Exception exception = Assert.Throws<Exception>(() => userService.Post(new UserViewModel { Id = Guid.NewGuid() }));
            Assert.Equal("UserID must be empty", exception.Message);
        }

        [Fact]
        public void GetById_SendingEmptyGuid()
        {
            Exception exception = Assert.Throws<Exception>(() => userService.GetById(""));
            Assert.Equal("UserID is not valid", exception.Message);
        }

        [Fact]
        public void Put_SendingEmptyGuid()
        {
            Exception exception = Assert.Throws<Exception>(() => userService.Put(new UserViewModel()));
            Assert.Equal("ID is invalid", exception.Message);
        }

        [Fact]
        public void Delete_SendingEmptyGuid()
        {
            Exception exception = Assert.Throws<Exception>(() => userService.Delete(""));
            Assert.Equal("UserID is not valid", exception.Message);
        }

        [Fact]
        public void Authenticate_SendingEmptyValues()
        {
            Exception exception = Assert.Throws<Exception>(() => userService.Authenticate(new UserAuthenticateRequestViewModel()));
            Assert.Equal("Email/Password are required.", exception.Message);
        }

        #endregion

        #region ValidatingCorrectObject

        [Fact]
        public void Post_SendingValidObject()
        {
            bool result = userService.Post(new UserViewModel { Name = "Saulo Costa", Email = "saulo.costa@gmail.com" });
            Assert.True(result);
        }

        [Fact]
        public void Get_ValidatingObject()
        {
            List<User> _users = new List<User>();
            _users.Add(new User { Id = Guid.NewGuid(), Name = "Saulo Costa", Email = "saulo.costa@gmail.com", DateCreated = DateTime.Now });

            Mock<IUserRepository> _userRepository = new Mock<IUserRepository>();
            _userRepository.Setup(x => x.GetAll()).Returns(_users);

            AutoMapperSetup _autoMapperProfile = new AutoMapperSetup();
            MapperConfiguration _configuration = new MapperConfiguration(x => x.AddProfile(_autoMapperProfile));
            IMapper _mapper = new Mapper(_configuration);

            userService = new UserService(_userRepository.Object, _mapper);
            List<UserViewModel> result = userService.Get();
            Assert.True(result.Count > 0);
        }

        #endregion

        #region ValidatingRequiredFields

        [Fact]
        public void Post_SendingInvalidObject()
        {
            Exception exception = Assert.Throws<ValidationException>(() => userService.Post(new UserViewModel { Name = "Saulo Costa" }));
            Assert.Equal("The Email field is required.", exception.Message);
        }

        #endregion      
    }
}
