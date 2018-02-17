using AutoMapper;
using MVC.Models.Enums;
using MVC.Models.Models;

namespace MVC.Repository.EntityFramework
{
    public class AutoMapper
    {
        static IMapper _mapper;

        public static void Initialize()
        {
            var mapperConfiguration = new MapperConfiguration(cfg =>
            {
                DoMap(cfg);

            });

            _mapper = mapperConfiguration.CreateMapper();
        }

        private static void DoMap(IMapperConfigurationExpression configuration)
        {
            configuration.CreateMap<User, UserModel>()
                .ForMember(ua => ua.AccountType, m => m.MapFrom(u => (AccountType)u.AccountType.Value));
            configuration.CreateMap<UserModel, User>()
                .ForMember(u => u.AccountType, m => m.MapFrom(ua => (byte)ua.AccountType));
        }

        public static IMapper Mapper
        {
            get { return _mapper; }
        }
    }
}
