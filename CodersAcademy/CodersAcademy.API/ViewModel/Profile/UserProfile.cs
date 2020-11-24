using CodersAcademy.API.Model;
using CodersAcademy.API.ViewModel.Request;
using CodersAcademy.API.ViewModel.Response;

namespace CodersAcademy.API.ViewModel.Profile
{
    public class UserProfile : AutoMapper.Profile
    {
        public UserProfile()
        {
            CreateMap<RegisterRequest, User>();
            CreateMap<User, UserResponse>();
        }
    }
}
