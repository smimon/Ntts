sing System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
usin
namespace Ntts.Data.Entities
{
    public class TasTask : IdentityEntityBase
    {d]
        public string Name { get; set; }

        [Required]
        public int UserId { get; set; }

        [Required]
        public bool IsAppliedToAllStocks { get; set; }

        #region Naivgation Properties

        public virtual User User { get; set; }

        public virtual ICollection<TaskActionBatch> TaskActionBatches { get; set; }

        public virtual ICollection<TaskAction> TaskActions { get; set; }

        #endregion
    }
}
