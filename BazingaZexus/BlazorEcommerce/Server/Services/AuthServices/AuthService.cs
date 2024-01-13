
namespace BlazorEcommerce.Server.Services.AuthServices
{
    public class AuthService : IAuthService
    {
        private readonly DataContext _context;

        public AuthService(DataContext context)
        {
            _context = context;
        }

        public Task<ServiceResponse<int>> Register(User user, string password)
        {
            throw new NotImplementedException();
        }

        /// <summary>
        /// 用户是否已经存在
        /// </summary>
        /// <param name="email"></param>
        /// <returns></returns>
        /// <exception cref="NotImplementedException"></exception>
        public async Task<bool> UserExists(string email)
        {
            if (await _context.Users.AnyAsync(user => user.Email.ToLower().Equals(email.ToLower())))
            {
                return true;
            }
            return false;
        }
    }
}
