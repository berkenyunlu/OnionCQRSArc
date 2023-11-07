using Microsoft.Extensions.DependencyInjection;
using OnionArcApi.Application.Interfaces.AutoMapper;

namespace OnionArcApi.Mapper;

public static class Registration
{
    public static void AddCustomMapper(this IServiceCollection services)
    {
        services.AddSingleton<IMapper, AutoMapper.Mapper>();
    }
}
