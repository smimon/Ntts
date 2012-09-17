using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;

namespace Ntts.Data.Entities
{
    public class Fact
    {
        [Key]
        [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        public int Id { get; set; }

        [Required]
        public string Name { get; set; }

        [Required]
        public int FactTypeId { get; set; }

        public int FeedId { get; set; }

        public string Selector { get; set; }

        #region Naivgation Properties

        public virtual FactType FactType { get; set; }

        public virtual Feed Feed { get; set; }

        public virtual ICollection<StockFact> StockFacts { get; set; }

        #endregion
    }
}
