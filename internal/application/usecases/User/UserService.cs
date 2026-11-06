using System;
using ATMTerpaduApp.Internal.application.dto.response.User;
using ATMTerpaduApp.Internal.domain.repositories.UserRepository;

namespace ATMTerpaduApp.Internal.application.usecases.User;

public class UserService : IUserService
{
    private readonly IUserRepository _userRepository;

    public UserService(IUserRepository userRepository)
    {
        _userRepository = userRepository;
    }
    async Task<IEnumerable<UserResponseDTO>> IUserService.GetUsers()
    {
        var users = await _userRepository.GetUsers();

        return users.Select(u => new UserResponseDTO(
            u.Name,
            u.Role,
            u.Level
        ));
    }
}
