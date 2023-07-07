namespace OAuth2.OpenID.API;

public class AuthorizationRequest
{
    public String ResponseType { get; set; }
    public String ClientID { get; set; }
    public String RedirectURI { get; set; }
    public String Scope { get; set; }
    public String State { get; set; }
    public String Nonce { get; set; }
}