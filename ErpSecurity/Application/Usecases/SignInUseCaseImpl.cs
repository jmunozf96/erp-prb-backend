using ErpSecurity.Domain.Models;
using ErpSecurity.Domain.Ports.In.Usecases;
using ErpSecurity.Domain.Ports.Out;
using ErpCore.Options;
using Microsoft.Extensions.Options;

namespace ErpSecurity.Application.Usecases
{
    public class SignInUseCaseImpl : SignInUseCase
    {
        private readonly UserRepositoryPort _repositoryPort;
        private readonly GetAccessTokenUseCase _getAccessTokenUseCase;
        private readonly JwtOption _jwtOption;

        public SignInUseCaseImpl(UserRepositoryPort repositoryPort, GetAccessTokenUseCase getAccessTokenUseCase, IOptionsSnapshot<JwtOption> jwtOption)
        {
            _repositoryPort = repositoryPort;
            _getAccessTokenUseCase = getAccessTokenUseCase;
            _jwtOption = jwtOption.Value;
        }

        public OutputSignIn Execute(InputSignIn entity)
        {
            var user = _repositoryPort.Get(email: entity.Email);
            bool verified = BCrypt.Net.BCrypt.Verify(entity.Password, user.Password);

            if (!verified)
            {
                throw new Exception("La contraseña no es correcta.");
            }

            var accessToken = _getAccessTokenUseCase.Execute(new(user.Id, _jwtOption.DurationTokenInMinutes, _jwtOption.Key));
            var refreshToken = _getAccessTokenUseCase.Execute(new(user.Id, _jwtOption.RefreshKey));

            return new(accessToken, refreshToken);
        }
    }
}
