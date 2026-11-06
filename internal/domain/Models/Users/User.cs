using System;

namespace ATMTerpaduApp.Internal.domain.Models.Users;

public class User
{
    public int Id { get; set; }
    public string Name { get; set; } = string.Empty;
    public string Role { get; set; } = string.Empty;
    public string Level { get; set; } = string.Empty;
}
