using NZWalks.API.Models.Domain;

namespace NZWalks.API.Repositories
{
    public interface IWalkReposotory
    {
        Task <Walk> CreateAsync(Walk walk);
        Task <List<Walk>> GetAllAsync(String? filterOn = null , String? filterQuery = null);
        Task <Walk?> GetByIdAsync(Guid id);
        Task <Walk?> UpdateAsync(Guid id, Walk walk);
        Task <Walk?> DeleteAsync(Guid id);
    }
}
