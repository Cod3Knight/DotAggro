using Business;
using Data;

namespace Service
{
    /// <summary>
    /// 
    /// </summary>
    public class ServiceAuthentication
    {
        /// <summary>
        /// 
        /// </summary>
        private readonly DataContext _ctx;

        /// <summary>
        /// 
        /// </summary>
        /// <param name="context"></param>
        public ServiceAuthentication(DataContext context)
        {
            _ctx = context;
        }

        /// <summary>
        /// 
        /// </summary>
        /// <param name="model"></param>
        /// <returns></returns>
        public async Task<AuthenticationResult> AuthenticateAsync(Authentication model)
        {
            if (model.Email == "admin@test.fr" && model.Password == "password")
                return AuthenticationResult.Success;
            else
                return AuthenticationResult.Error;
        }
    }
}
