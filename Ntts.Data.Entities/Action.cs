using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;

namespace Ntts.Data.Entities
{
    public class Actioon : IdentityEntityBase
    {ired]
        public string Name { get; set; }

        [Required]
        public int ActionTypeId { get; set; }

        public int FeedId { get; set; }

        public int PluginId { get; set; }

        #region Naivgation Properties

        public virtual ActionType ActionType { get; set; }

        public virtual Feed Feed { get; set; }

        public virtual Plugin Plugin { get; set; }

        public virtual ICollection<TaskActionBatchQueue> TaskActionBatchQueues { get; set; }

        public virtual ICollection<TaskAction> TaskActions { get; set; }

        #endregion
    }
}
