using fav_choons_csharp.Data.Models;

namespace fav_choons_csharp.Data.Services
{
    public interface IAppUserService
    {
        IEnumerable<AppUser> GetAll();
        AppUser Add(AppUser newAppUser);
        AppUser GetById(Guid id);
        void Remove(Guid id);
    }
}
