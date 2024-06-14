using SmartHelper.Server.Interfaces;
using SmartHelper.Server.Models.Auth;

namespace SmartHelper.Server.Data.Repositories
{
    public class AuthUserRepository : IRepository<AuthUser>
    {
        private static SmarthelperDbContext _db;

        public AuthUserRepository()
        {
            _db = new SmarthelperDbContext();
        }
        public void Add(AuthUser entity)
        {
            _db.AuthUsers.Add(entity);
            _db.SaveChanges();
        }

        public void Delete(AuthUser entity)
        {
            throw new NotImplementedException();
        }

        public AuthUser GetById(int id)
        {
            throw new NotImplementedException();
        }

        public void Update(AuthUser entity)
        {
            throw new NotImplementedException();
        }
    }
}
