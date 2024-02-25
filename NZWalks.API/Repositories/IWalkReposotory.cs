using NZWalks.API.Models.Domain;

namespace NZWalks.API.Repositories
{
    public interface IWalkReposotory
    {
        Task <Walk> CreateAsync (Walk walk);
        Task <List<Walk>> GetAllAsync();
    }
}
