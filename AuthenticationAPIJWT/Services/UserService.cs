using System.Security.Claims;

namespace AuthenticationAPIJWT.Services
{
    public class UserService : IUserService
    {

        private readonly IHttpContextAccessor _httpcontextAccessor;

        public UserService(IHttpContextAccessor httpcontextAccessor)
        {
            _httpcontextAccessor = httpcontextAccessor;      
        }
        public string GetMyName()
        {
            var result = string.Empty;

            if (_httpcontextAccessor.HttpContext != null)
            {
                result = _httpcontextAccessor.HttpContext.User.FindFirstValue(ClaimTypes.Name);
            }
            return result;
        }
    }
}
