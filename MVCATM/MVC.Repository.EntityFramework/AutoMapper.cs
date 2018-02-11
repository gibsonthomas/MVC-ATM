using AutoMapper;
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
            configuration.CreateMap<User, UserAccount>();
        }

        public static IMapper Mapper
        {
            get { return _mapper; }
        }
    }
}
