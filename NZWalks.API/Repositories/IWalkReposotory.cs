using NZWalks.API.Models.Domain;

namespace NZWalks.API.Repositories
{
    public interface IWalkReposotory
    {
        Task <Walk> CreateAsync(Walk walk);
        Task <List<Walk>> GetAllAsync(String? filterOn = null , String? filterQuery = null, 
            String? sortBy = null, bool isAscending = true, 
            int pageNumber =1,
            int pageSize =1000);
        Task <Walk?> GetByIdAsync(Guid id);
        Task <Walk?> UpdateAsync(Guid id, Walk walk);
        Task <Walk?> DeleteAsync(Guid id);
    }
}
