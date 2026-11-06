using System;
using ATMTerpaduApp.Internal.domain.Models.Users;

namespace ATMTerpaduApp.Internal.domain.repositories.UserRepository;

public interface IUserRepository
{
    Task<IEnumerable<User>> GetUsers();
}
