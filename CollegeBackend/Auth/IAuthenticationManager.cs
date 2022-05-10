﻿using CollegeBackend.Objects;
using CollegeBackend.Objects.Database;

namespace CollegeBackend.Auth;

public interface IAuthenticationManager
{
    /// <summary>
    /// Authenticate referenced user
    /// </summary>
    /// <param name="user">Referencing user</param>
    /// <returns>TokenizedUser with token and referenced user, null when already exists in cache</returns>
    TokenizedUser? Authenticate(User user);

    /// <inheritdoc cref="Authenticate"/>
    Task<TokenizedUser?> AuthenticateAsync(User user);

    /// <summary>
    /// Get tokenized user by token
    /// </summary>
    /// <param name="token">User token</param>
    /// <returns>Tokenized user, null when doesn't authenticated</returns>
    TokenizedUser? this[Guid token] { get; }

    /// <inheritdoc cref="this[Guid]"/>
    Task<TokenizedUser?> GetAsync(Guid token);
}