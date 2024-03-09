using ErpSecurity.Domain.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using ErpShared.Domain.Utils;

namespace ErpSecurity.Domain.Ports.In.Usecases
{
    public interface SignInUseCase : UseCase<InputSignIn, OutputSignIn>
    {
    }
}
