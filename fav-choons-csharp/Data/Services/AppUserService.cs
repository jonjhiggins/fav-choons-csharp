using fav_choons_csharp.Data.Models;


namespace fav_choons_csharp.Data.Services
{
	public class AppUserService : IAppUserService
    {
        private readonly AppDbContext _context;

        public AppUserService(AppDbContext context)
        {
            _context = context;
        }

        public IEnumerable<AppUser> GetAll() => _context.AppUsers.ToList();

        public AppUser Add(AppUser newAppUser)
        {
            newAppUser.Id = Guid.NewGuid();
            _context.AppUsers.Add(newAppUser);
            _context.SaveChanges();
            return newAppUser;
        }

        public AppUser? GetById(Guid id) => _context.AppUsers.FirstOrDefault(a => a.Id == id);

        public void Remove(Guid id)
        {
            var existing = _context.AppUsers.First(a => a.Id == id);
            _context.AppUsers.Remove(existing);
            _context.SaveChanges();
        }
    }
}

