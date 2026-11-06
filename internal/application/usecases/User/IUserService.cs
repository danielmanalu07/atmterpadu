using System;
using ATMTerpaduApp.Internal.application.dto.response.User;

namespace ATMTerpaduApp.Internal.application.usecases.User;

public interface IUserService
{
    Task<IEnumerable<UserResponseDTO>> GetUsers();
}
