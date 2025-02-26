using System.ComponentModel.DataAnnotations.Schema;
using System.ComponentModel.DataAnnotations;

namespace HallBudgetASPCore.Models
{
    [Table("hall")]
    public class HallDetails
    {
        [Key]
        [Column("id")]
        public int Id { get; set; }
        [Column("hallname")]
        public string HallName { get; set; }
        [Column("ownername")]
        public string OwnerName { get; set; }
        [Column("costperday")]
        public int CostPerDay { get; set; }
        [Column("mobile")]
        public long Mobile { get; set; }
        [Column("address")]
        public string Address {  get; set; }
    }
}
