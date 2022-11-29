using System.ComponentModel.DataAnnotations.Schema;

namespace Data.DAO
{
    /// <summary>
    /// 
    /// </summary>
    [Table("Ressources")]
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
        public string Phone { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public string Mobile { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public string Email { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public string Role { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public int SiteId { get; set; }
        /// <summary>
        /// 
        /// </summary>
        [ForeignKey("SiteId")]
        public virtual Site Site { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public int PoleId { get; set; }
        /// <summary>
        /// 
        /// </summary>
        [ForeignKey("PoleId")]
        public virtual Pole Pole { get; set; }
    }
}
