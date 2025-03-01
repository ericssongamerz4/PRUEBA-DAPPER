using PRUEBA_DAPPER.Models;

namespace PRUEBA_DAPPER.Repositories
{
    public interface IVideoGameRepository
    {
        Task<List<VideoGame>> GetAllAsync();

    }
}
