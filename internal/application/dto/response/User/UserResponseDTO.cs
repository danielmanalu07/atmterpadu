using System;

namespace ATMTerpaduApp.Internal.application.dto.response.User;

public record UserResponseDTO
(
    string Name,
    string Role,
    string Level
);
