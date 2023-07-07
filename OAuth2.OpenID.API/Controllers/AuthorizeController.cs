using Microsoft.AspNetCore.Mvc;

namespace OAuth2.OpenID.API.Controllers;

[ApiController]
[Route("[controller]")]
public class AuthorizeController: ControllerBase
{
    private readonly ILogger<AuthorizeController> _logger;
    
    public AuthorizeController(ILogger<AuthorizeController> logger)
    {
        _logger = logger;
    }
    
    [HttpGet(Name = "Authenticate")]
    public AuthorizationRequest Get()
    {
        return new AuthorizationRequest
        {
            Scope = "",
            Nonce = "",
            State = "",
            ResponseType = "",
            ClientID = "",
            RedirectURI = ""
        };
    }
}