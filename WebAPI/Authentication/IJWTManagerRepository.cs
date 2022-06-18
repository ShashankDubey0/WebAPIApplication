using WebAPI.Model;

namespace WebAPI.Authentication
{
    public interface IJWTManagerRepository
    {
        Tokens Authenticate(Users users);
    }
}
