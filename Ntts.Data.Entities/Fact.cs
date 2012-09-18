sing System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
usin
namespace Ntts.Data.Entities
{
    public class FacFact : IdentityEntityBase
    {d]
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
