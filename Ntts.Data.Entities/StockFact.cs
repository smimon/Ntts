ing System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
usin
namespace Ntts.Data.Entities
{
    public class StockFact : IdentityEntityBase      [Key]
        [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        public int Id { get; set; }

        [Required]
        public int StockId { get; set; }

        [Required]
        public int FactId { get; set; }

        [Required]
        public object Value { get; set; }

        #region Naivgation Properties

        public virtual Stock Stock { get; set; }

        public virtual Fact Fact { get; set; }

        #endregion
    }
}
