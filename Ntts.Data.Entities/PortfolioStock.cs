using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;

namespace Ntts.Data.Entities
{
    public class PortfolioStock
    {
        [Key]
        [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        public int Id { get; set; }

        [Required]
        public int PortfolioId { get; set; }

        [Required]
        public int StockId { get; set; }

        #region Naivgation Properties

        public virtual Portfolio Portfolio { get; set; }

        public virtual Stock Stock { get; set; }

        #endregion
    }
}
