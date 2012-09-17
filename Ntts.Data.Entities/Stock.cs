using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;

namespace Ntts.Data.Entities
{
    public class Stock
    {
        [Key]
        [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        public int Id { get; set; }

        [Required]
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
