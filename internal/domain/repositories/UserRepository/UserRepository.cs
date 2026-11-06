using System;
using ATMTerpaduApp.Internal.domain.Models.Users;

namespace ATMTerpaduApp.Internal.domain.repositories.UserRepository;

public class UserRepository : IUserRepository
{
    Task<IEnumerable<User>> IUserRepository.GetUsers()
    {
        IEnumerable<User> users = new List<User>
        {
            new User { Id = 1, Name = "Daniel Manalu", Role = "Software Engineer", Level = "Senior" },
            new User { Id = 2, Name = "Budi Santoso", Role = "ATM Maintenance", Level = "Mid" },
            new User { Id = 3, Name = "Siti Rahma", Role = "System Administrator", Level = "Lead" }
        };
        return Task.FromResult(users);
    }
}
