using Dtos.ResourceDtos;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Services.Interfaces;
using Shared.CustomExceptions;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace SimpleBookingSystemApp.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class ResourceController : ControllerBase
    {
        private IResourceService _resourceService;
        public ResourceController(IResourceService resourceService)
        {
            _resourceService = resourceService;
        }

        [HttpGet("get-all-resources")]
        public ActionResult<List<ResourceListDto>> GetAllResources()
        {
            try
            {
                List<ResourceListDto> resourceList = _resourceService.GetAllResources();
                return StatusCode(StatusCodes.Status200OK, resourceList);
            }
            catch (ResourceException)
            {
                return StatusCode(StatusCodes.Status400BadRequest, "Can't get resources");
            }
            catch (Exception)
            {
                return StatusCode(StatusCodes.Status500InternalServerError, "An error occured");
            }
        }

        [HttpGet("get-resource-by-id")]
        public ActionResult<ResourceListDto> GetResourceById(int id)
        {
            try
            {
                ResourceListDto resource = _resourceService.GetResourceById(id);
                return StatusCode(StatusCodes.Status200OK, resource);
            }
            catch (ResourceException)
            {
                return StatusCode(StatusCodes.Status400BadRequest, "Can't get resource");
            }
            catch (Exception)
            {
                return StatusCode(StatusCodes.Status500InternalServerError, "An error occured");
            }
        }
    }
}
