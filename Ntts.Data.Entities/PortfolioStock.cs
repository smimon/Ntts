ing System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
usinpace Ntts.Data.Entities
{
    public class PortfolioPortfolioStock : IdentityEntityBase
    {ired]
        public int PortfolioId { get; set; }

        [Required]
        public int StockId { get; set; }

        #region Naivgation Properties

        public virtual Portfolio Portfolio { get; set; }

        public virtual Stock Stock { get; set; }

        #endregion
    }
}
