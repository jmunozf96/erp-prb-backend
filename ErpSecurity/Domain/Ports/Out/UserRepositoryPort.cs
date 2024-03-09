using ErpSecurity.Domain.Entities;

namespace ErpSecurity.Domain.Ports.Out
{
    public interface UserRepositoryPort
    {
        User Get(string email);
    }
}
