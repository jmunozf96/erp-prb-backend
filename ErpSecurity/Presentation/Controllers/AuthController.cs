using AutoMapper;
using ErpSecurity.Domain.Models;
using ErpSecurity.Domain.Ports.In.Usecases;
using ErpSecurity.Presentation.Dtos;
using Microsoft.AspNetCore.Mvc;

namespace ErpSecurity.Presentation.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class AuthController : ControllerBase
    {
        private readonly SignInUseCase signInUseCase;
        private readonly IMapper mapper;
        public AuthController(SignInUseCase signInUseCase, IMapper mapper)
        {
            this.signInUseCase = signInUseCase;
            this.mapper = mapper;
        }

        [HttpPost("Login")]
        public IActionResult Login([FromBody] SignInDTO login)
        {
            var input = mapper.Map<InputSignIn>(login);
            return Ok(signInUseCase.Execute(input));
        }
    }
}
