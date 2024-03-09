using ErpSecurity.Domain.Models;
using ErpSecurity.Domain.Ports.In.Usecases;
using Microsoft.IdentityModel.Tokens;
using System.IdentityModel.Tokens.Jwt;
using System.Security.Claims;
using System.Text;

namespace ErpSecurity.Application.Usecases
{
    public class GetAccessTokenUseCaseImpl : GetAccessTokenUseCase
    {

        public GetAccessTokenUseCaseImpl()
        {
        }

        public string Execute(InputGetAccessToken value)
        {
            var tokenHandler = new JwtSecurityTokenHandler();
            var key = Encoding.ASCII.GetBytes(value.Key);
            var durationInMinutes = value.DurationTokenInMinutes;
            var tokenDescriptor = new SecurityTokenDescriptor
            {
                Subject = new ClaimsIdentity(
                    new Claim[]
                    {
                        new(ClaimTypes.NameIdentifier, value.UserId.ToString())
                    }
                    ),
                Expires = DateTime.UtcNow.AddMinutes(durationInMinutes),
                SigningCredentials = new SigningCredentials(new SymmetricSecurityKey(key), SecurityAlgorithms.HmacSha256Signature)
            };
            var token = tokenHandler.CreateToken(tokenDescriptor);
            return tokenHandler.WriteToken(token);
        }
    }
}
