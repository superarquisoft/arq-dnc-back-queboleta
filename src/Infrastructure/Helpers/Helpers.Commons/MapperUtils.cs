using AutoMapper;

namespace Helpers.Commons
{
    public static class MapperUtils
    {

        public static TDestination MapDto<TSource, TDestination>(this TSource source)
        {
            var configuration = new MapperConfiguration(cfg =>
            {
                cfg.CreateMap<TSource, TDestination>().ReverseMap();
            });

            var mapper = configuration.CreateMapper();

            configuration.AssertConfigurationIsValid();

            return mapper.Map<TDestination>(source);
        }

    }
}
