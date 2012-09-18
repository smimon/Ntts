sing System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
usinpace Ntts.Data.Entities
{
    public class TaskActioTaskActionBatchQueueStatus : IdentityEntityBase
    {ired]
        public string Name { get; set; }

        #region Naivgation Properties

        public virtual ICollection<TaskActionBatchQueue> TaskActionBatchQueues { get; set; }

        #endregion
    }
}

        public enum TaskActionBatchQueueStatusEnum
        {
            Queued = 1,
            InProgress = 2,
            Complete = 3,
            Error = 4
        }
    }
}
