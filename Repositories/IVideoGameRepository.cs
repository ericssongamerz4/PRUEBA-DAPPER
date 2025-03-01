using PRUEBA_DAPPER.Models;

namespace PRUEBA_DAPPER.Repositories
{
    // Define una interfaz llamada IVideoGameRepository.
    // Una interfaz es un contrato que especifica qué métodos debe implementar una clase que la use.
    public interface IVideoGameRepository
    {
        // Define un método asíncrono llamado GetAllAsync.
        // Este método devuelve una lista de objetos de tipo VideoGame.
        // Task<List<VideoGame>> indica que el método es asíncrono y devuelve una lista de VideoGame.
        Task<List<VideoGame>> GetAllAsync();

        // Define un método asíncrono llamado GetByIdAsync.
        // Este método recibe un parámetro de tipo int (id) y devuelve un objeto de tipo VideoGame.
        // Task<VideoGame> indica que el método es asíncrono y devuelve un solo VideoGame.
        Task<VideoGame> GetByIdAsync(int id);

        // Define un método asíncrono llamado AddAsync.
        // Este método recibe un parámetro de tipo VideoGame (videoGame) y no devuelve ningún valor.
        // Task indica que el método es asíncrono y no devuelve un resultado específico.
        Task AddAsync(VideoGame videoGame);

        // Define un método asíncrono llamado UpdateAsync.
        // Este método recibe un parámetro de tipo VideoGame (videoGame) y no devuelve ningún valor.
        // Task indica que el método es asíncrono y no devuelve un resultado específico.
        Task UpdateAsync(VideoGame videoGame);

        // Define un método asíncrono llamado DeleteAsync.
        // Este método recibe un parámetro de tipo int (id) y no devuelve ningún valor.
        // Task indica que el método es asíncrono y no devuelve un resultado específico.
        Task DeleteAsync(int id);
    }
}
