﻿using Domain.Contracts.UseCases.User;
using Microsoft.AspNetCore.Mvc;

namespace Flix.Controllers;

[ApiController]
[Route("[controller]")]
public class UserController : ControllerBase
{
    private readonly IUsuarioUseCase _UsuarioUseCase;

    public UserController(IUsuarioUseCase createUser)
    {
        _UsuarioUseCase = createUser;
    }

    [HttpPost("cadastro")]
    public async Task<IActionResult> RegisterUser(UsuarioInputDto input, CancellationToken cancellationToken)
    {
        var usuario = await _UsuarioUseCase.RegisterUser(input, cancellationToken);

        return Ok(
                new
                {
                    Username = usuario
                });
    }

    [HttpPost("login")]
    public async Task<IActionResult> Login(LoginUsuarioDto input, CancellationToken cancellationToken)
    {
        var token = await _UsuarioUseCase.Login(input, cancellationToken);
        return Ok(token);

    }
}
