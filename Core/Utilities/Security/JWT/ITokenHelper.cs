using Core.Entities.Cocncrete;
using System;
using System.Collections.Generic;
using System.Text;

namespace Core.Security.JWT
{
    public interface ITokenHelper
    {
        AccessToken CreateToken(User user, List<OperationClaim> operationClaims);
    }
}
