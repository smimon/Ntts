sing System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
usin
namespace Ntts.Data.Entities
{
    public class Facct : IdentityEntityBase      [Key]
        [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        public int Id { get; set; }

        [Required]
        public string Name { get; set; }

        [Required]
        public int FactTypeId { get; set; Data}

        public int FeedId { get; set; }

        public string Selector { get; set; }

        #region Naivgation Properties

        public virtual FactType FactType { get; set; }DataType FactData public virtual Feed Feed { get; set; }

        public virtual ICollection<StockFact> StockFacts { get; set; }

        #endregion
    }
}
