namespace WebAPI.Model
{
    public class Tokens
    {
        public string Token { get; set; }
        public string RefreshToken { get; set; }
    }
}

public class Users
{
    public string Name { get; set; }
    public string Password { get; set; }
}
