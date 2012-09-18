sing System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
usin
namespace Ntts.Data.Entities
{
    public class MarMarket : IdentityEntityBase
    {d]
        public string Name { get; set; }

        #region Naivgation Properties

        public virtual ICollection<Stock> Stocks { get; set; }

        #endregion
    }
}
