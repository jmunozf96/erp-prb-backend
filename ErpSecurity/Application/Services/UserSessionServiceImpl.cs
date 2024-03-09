using ErpSecurity.Domain.Entities;
using ErpSecurity.Domain.Ports.In.Services;
using ErpSecurity.Domain.Ports.Out;
using Microsoft.AspNetCore.Http;
using System.Security.Claims;

namespace ErpSecurity.Application.Services
{
    public class UserSessionServiceImpl : UserSessionService
    {
        private readonly UserRepositoryPort _repositoryPort;
        private readonly IHttpContextAccessor _httpContextAccessor;
        private User _usuario;

        public UserSessionServiceImpl(UserRepositoryPort repositoryPort, IHttpContextAccessor httpContextAccessor)
        {
            _repositoryPort = repositoryPort;
            _httpContextAccessor = httpContextAccessor;
        }

        public User GetUser()
        {
            _usuario ??= _repositoryPort.Get(GetUserId());
            return _usuario;
        }

        public int GetUserId()
        {
            var claim = GetUserClaim();
            return Convert.ToInt32(claim.Value);
        }

        private Claim GetUserClaim()
        {
            return GetHttpContext()?.User.FindFirst(ClaimTypes.NameIdentifier)
                ?? throw new InvalidOperationException("Usuario no autenticado.");
        }

        private HttpContext? GetHttpContext() { 
            return _httpContextAccessor.HttpContext;
        }
    }
}
