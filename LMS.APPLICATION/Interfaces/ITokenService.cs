using LMS.DOMAIN.Entities;
using System;
using System.Collections.Generic;
using System.Text;

namespace LMS.APPLICATION.Interfaces
{
    public interface ITokenService
    {
        string GenerateToken(User user);
    }

}
