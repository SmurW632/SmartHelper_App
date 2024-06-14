using SmartHelper.Server.Interfaces;
using SmartHelper.Server.Models.Auth;

namespace SmartHelper.Server.Data.Repositories
{
    public class AuthUserRepository : IRepository<AuthUser>
    {
        public bool Add(AuthUser entity)
        {
            if(entity == null) return false;

            using SmarthelperDbContext db = new();

            db.AuthUsers.Add(entity);
            db.SaveChanges();
            return true;
        }

        public bool Delete(AuthUser entity)
        {
            if (entity == null) return false;

            using SmarthelperDbContext db = new();

            db.AuthUsers.Remove(entity);
            db.SaveChanges();
            return true;
        }

        public AuthUser GetById(int id)
        {
            using SmarthelperDbContext db = new();

            var user = db.AuthUsers.FirstOrDefault(u => u.UserId == id);
            if (user == null) return null!;

            return user;
        }

        public bool Update(AuthUser entity)
        {
            if (entity == null) return false;

            using SmarthelperDbContext db = new();

            db.Update(entity);
            db.SaveChanges();
            return true;
        }
    }
}
