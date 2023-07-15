using System.Collections.Generic;
using System.Linq;
using PlatformService.Models;

namespace PlatformService.Data 
{
    public class PlatformRepo : IPlatformRepo
    {
        private readonly AppDbContext _context;

        public PlatformRepo(AppDbContext context)
        {
           _context = context; 
        }

        public void CreatePlatform(Platform obj)
        {
            if(obj == null)
            {
                throw new ArgumentNullException(nameof(obj));
            }

            _context.Platforms.Add(obj);
        }

        public Platform GetPlatformById(int id)
        {
            return _context.Platforms.FirstOrDefault(p => p.Id == id);
        }

        public IEnumerable<Platform> GetPlatfroms()
        {
            return _context.Platforms.ToList();
        }

        public bool SaveChanges()
        {
            return (_context.SaveChanges() >= 0);
        }
    }
}