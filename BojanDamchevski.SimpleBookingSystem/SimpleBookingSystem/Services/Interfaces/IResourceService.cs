using Dtos.ResourceDtos;
using System.Collections.Generic;

namespace Services.Interfaces
{
    public interface IResourceService
    {
        List<ResourceListDto> GetAllResources();
        ResourceListDto GetResourceById(int id);
    }
}
