using DataAccess.Interfaces;
using Domain.Models;
using Microsoft.EntityFrameworkCore;
using System.Collections.Generic;
using System.Linq;

namespace DataAccess.Implementations
{
    public class ResourceRepository : IResourceRepository
    {
        private AppDbContext _appDbContext;
        public ResourceRepository(AppDbContext appDbContext)
        {
            _appDbContext = appDbContext;
        }

        public List<Resource> GetAll()
        {
            return _appDbContext.Resources
                .Include(x=>x.Bookings)
                .ToList();
        }

        public Resource GetById(int id)
        {
            return _appDbContext.Resources
                .Include(x => x.Bookings)
                .FirstOrDefault(x => x.Id == id);
        }

        public void Update(Resource entity)
        {
            _appDbContext.Update(entity);
            _appDbContext.SaveChanges();
        }
    }
}
