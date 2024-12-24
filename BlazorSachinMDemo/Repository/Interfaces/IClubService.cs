using BlazorSachinMDemo.Models;

namespace BlazorSachinMDemo.Repository.Interfaces
{
    public interface IClubService
    {
        Task<List<Club>> GetClubs();
        Task<Club> GetClub(int id);
        Task AddClub(Club club);
        Task UpdateClub(Club club);
        Task DeleteClub(int id);
    }
}
