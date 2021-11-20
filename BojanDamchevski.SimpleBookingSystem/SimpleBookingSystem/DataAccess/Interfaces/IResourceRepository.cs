using Domain.Models;
using System.Collections.Generic;

namespace DataAccess.Interfaces
{
    public interface IResourceRepository
    {
        List<Resource> GetAll();
        Resource GetById(int id);
        void Update(Resource entity);
    }
}
