using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotationssinpace Ntts.Data.Entities
{
    public class TaskActioTaskActionBatchQueue : IdentityEntityBase
    {ired]
        public int TaskActionBatchId { get; set; }

        [Required]
        public int ActionId { get; set; }

        [Required]
        public DateTime RunDateTime { get; set; }

        [Required]
        public int TaskActionBatchQueueStatusId { get; set; }

        #region Naivgation Properties

        public virtual TaskActionBatch TaskActionBatch { get; set; }

        public virtual Action Action { get; set; }

        public virtual TaskActionBatchQueueStatus TaskActionBatchQueueStatus { get; set; }

        #endregion
    }
}
public virtual ICollection<TaskActionBatchQueueParameter> TaskActionBatchQueueParameters { get; set; }

        #endregion
    }
}
