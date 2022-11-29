using System.ComponentModel.DataAnnotations.Schema;

namespace Data.DAO
{
    /// <summary>
    /// 
    /// </summary>
    [Table("Sites")]
    public class Site
    {
        /// <summary>
        /// 
        /// </summary>
        public int Id { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public string City { get; set; }
    }
}
