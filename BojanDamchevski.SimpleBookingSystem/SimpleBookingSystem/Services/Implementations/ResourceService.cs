using DataAccess.Interfaces;
using Dtos.ResourceDtos;
using Services.Interfaces;
using System.Collections.Generic;
using Mappers;
using System.Linq;

namespace Services.Implementations
{
    public class ResourceService : IResourceService
    {
        private IResourceRepository _resourceRepository;
        public ResourceService(IResourceRepository resourceRepository)
        {
            _resourceRepository = resourceRepository;
        }

        public List<ResourceListDto> GetAllResources()
        {
            return _resourceRepository.GetAll().Select(x=>x.ToResourceListDto()).ToList();
        }

        public ResourceListDto GetResourceById(int id)
        {
            return _resourceRepository.GetById(id).ToResourceListDto();
        }
    }
}
