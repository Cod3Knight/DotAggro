namespace Business
{
    /// <summary>
    /// 
    /// </summary>
    public class Ressource
    {
        /// <summary>
        /// 
        /// </summary>
        public int Id { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public string Firstname { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public string Lastname { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public string Mobile { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public string Phone { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public string Email { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public Pole Pole { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public Role Role { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public List<Right> Rights { get; set; }
    }
}
