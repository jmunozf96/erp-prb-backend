using ErpSecurity.Domain.Models;
using ErpShared.Domain.Utils;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ErpSecurity.Domain.Ports.In.Usecases
{
    public interface GetAccessTokenUseCase : UseCase<InputGetAccessToken, string>
    {
    }
}
