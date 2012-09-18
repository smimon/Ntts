using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace Ntts.Data.Entities
{
    public class Portfoolio : IdentityEntityBase
    {
        [Key]
        [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        public int Id { get; set; }
        
        [Required]        
        public int UserId { get; set; }
        
        [Required]
        public string Name { get; set; }

        #region Naivgation Properties

        public virtual User User { get; set; }

        public virtual ICollection<PortfolioStock> PortfolioStocks { get; set; }

        #endregion
    }
}
}