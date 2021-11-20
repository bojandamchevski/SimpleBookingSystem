using Domain.Models;
using Dtos.ResourceDtos;

namespace Mappers
{
    public static class ResourceMappers
    {
        public static ResourceListDto ToResourceListDto(this Resource resource)
        {
            return new ResourceListDto()
            {
                ResourceId = resource.Id,
                CurrentQuantity = resource.Quantity,
                Name = resource.Name
            };
        }
    }
}
