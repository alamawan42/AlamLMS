using LMS.DOMAIN.Entities;
using System;
using System.Collections.Generic;
using System.Text;

namespace LMS.APPLICATION.Interfaces
{
    public interface IUserRepository
    {
        Task<User?> GetByEmailAsync(string email);
        Task AddAsync(User user);

    }
}
