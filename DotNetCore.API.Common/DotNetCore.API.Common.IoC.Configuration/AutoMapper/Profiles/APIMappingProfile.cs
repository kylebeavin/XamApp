using AutoMapper;
using DC = DotNetCore.API.Common.API.DataContracts;
using S = DotNetCore.API.Common.Services.Model;

namespace DotNetCore.API.Common.IoC.Configuration.AutoMapper.Profiles
{
    public class APIMappingProfile : Profile
    {
        public APIMappingProfile()
        {
            CreateMap<DC.User, S.User>().ReverseMap();
            CreateMap<DC.Address, S.Address>().ReverseMap();
        }
    }
}
