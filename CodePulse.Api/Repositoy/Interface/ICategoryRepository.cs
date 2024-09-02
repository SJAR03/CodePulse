using CodePulse.Api.Models.Domain;

namespace CodePulse.Api.Repositoy.Interface
{
    public interface ICategoryRepository
    {
        Task<Category> CreateAsync(Category category);
    }
}
