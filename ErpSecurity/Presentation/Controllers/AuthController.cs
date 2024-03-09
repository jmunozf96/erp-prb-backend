using AutoMapper;
using ErpSecurity.Domain.Models;
using ErpSecurity.Domain.Ports.In.Usecases;
using ErpSecurity.Presentation.Dtos;
using Microsoft.AspNetCore.Mvc;

namespace ErpSecurity.Presentation.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class AuthController(SignInUseCase signInUseCase, IMapper mapper) : ControllerBase
    {
        private readonly SignInUseCase signInUseCase = signInUseCase;
        private readonly IMapper mapper = mapper;

        [HttpPost("Login")]
        public IActionResult Login([FromBody] SignInDTO login)
        {
            var input = mapper.Map<InputSignIn>(login);
            var authentication = signInUseCase.Execute(input);
            return Ok(mapper.Map<ResponseAuthDTO>(authentication));
        }
    }
}
