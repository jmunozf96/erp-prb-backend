using AutoMapper;
using ErpSecurity.Domain.Entities;
using ErpSecurity.Domain.Ports.Out;
using ErpSecurity.Infrastructure.Contexts;

namespace ErpSecurity.Infrastructure.Repositories
{
    public class UserRepositoryAdapter : UserRepositoryPort
    {

        private readonly SecurityDbContext Context;
        private readonly IMapper Mapper;

        public UserRepositoryAdapter(SecurityDbContext context, IMapper mapper)
        {
            Context = context;
            Mapper = mapper;
        }

        public User Get(string email)
        {
            var user = Context.Users
                .FirstOrDefault(u => u.Email == email) ?? throw new Exception("El usuario no existe.");
            return Mapper.Map<User>(user);
        }
    }
}
