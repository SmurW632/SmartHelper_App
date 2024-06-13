using SmartHelper.Server.Models.Auth;

namespace SmartHelper.Server.Data.Repositories
{
    public class UserRepository : IRepository<AuthUser>
    {
        public void Delete(AuthUser entity)
        {
            
        }

        public AuthUser GetById(int id)
        {
            throw new NotImplementedException();
        }

        public void Read(AuthUser entity)
        {
            throw new NotImplementedException();
        }

        public void Update(AuthUser entity)
        {
            throw new NotImplementedException();
        }
    }
}
