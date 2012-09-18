sing System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
usin
namespace Ntts.Data.Entities
{
    public class StoStock : IdentityEntityBase
    {d]
        public string Code { get; set; }

        [Required]
        public string Name { get; set; }

        #region Naivgation Properties

        public virtual Market Market { get; set; }

        public virtual ICollection<Portfolio> Portfolios { get; set; }

        public virtual ICollection<StockFact> StockFacts { get; set; }

        #endregion
    }
}
