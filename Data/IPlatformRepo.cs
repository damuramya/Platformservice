using PlatformService.Models;

namespace PlatformService.Data
{
    public interface IPlatformRepo 
    {
        bool SaveChanges();

        IEnumerable<Platform> GetPlatfroms();
        Platform GetPlatformById(int id);
        void CreatePlatform(Platform obj);
    }
}