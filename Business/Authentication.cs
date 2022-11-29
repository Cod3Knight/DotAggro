namespace Business
{
    /// <summary>
    /// 
    /// </summary>
    public enum AuthenticationResult { Success, Error, NotFound, AccountError }

    /// <summary>
    /// 
    /// </summary>
    public class Authentication
    {
        /// <summary>
        /// 
        /// </summary>
        public int Id { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public string Email { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public string Password { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public bool RememberMe { get; set; }
    }
}
