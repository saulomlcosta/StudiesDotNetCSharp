using AutoMapper;
using NetCoreAngularApp.Application.ViewModels;
using NetCoreAngularApp.Domain.Entities;

namespace NetCoreAngularApp.Application.AutoMapper
{
    public class AutoMapperSetup : Profile
    {
        public AutoMapperSetup()
        {
            #region ViewModelToDomain

                CreateMap<UserViewModel, User>();

            #endregion

            #region DomainToViewModel

                CreateMap<User, UserViewModel>();

            #endregion
        }
    }
}
