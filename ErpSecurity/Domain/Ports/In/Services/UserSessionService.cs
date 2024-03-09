using ErpSecurity.Domain.Entities;

namespace ErpSecurity.Domain.Ports.In.Services
{
    public interface UserSessionService
    {
        int GetUserId();
        User GetUser();
    }
}
