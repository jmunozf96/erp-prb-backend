using ErpSecurity.Domain.Entities;

namespace ErpSecurity.Domain.Ports.Out
{
    public interface UserRepositoryPort
    {
        User Get(int id);

        User Get(string email);
    }
}
